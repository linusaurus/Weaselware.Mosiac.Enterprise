using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.IO;
using Microsoft.Data.SqlClient;
using DataLayer.Data;
using DataLayer.Entity;
using ServiceLayer.Models;
using ServiceLayer.Mappers;
using ServiceLayer.Overloads;
using System.ComponentModel;
using Dapper;

namespace ServiceLayer
{
    public class PartsService : IDisposable
    {
        MosaicContext _context;
        String user = string.Empty;

        public PartsService(MosaicContext context)
        {
            _context = context;
            EmployeeService empService = new EmployeeService(_context);           
            user = empService.FullName(8);
            
           
        }

        public List<UnitOfMeasure> Units()
        {
           return  _context.UnitOfMeasures.ToList();
        }
      

        public bool AssociateSKU(Part part, string sku)
        {
            bool result = false;
            if (part == null){ return false; }
            var originalPart = _context.Parts.Find(part.PartID);
            originalPart.SKU = sku;
            try
            {
                _context.SaveChanges();
                result = true;
            }
            catch (Exception)
            {
                throw;
            }
           
            return result;            
        }

        public void Delete(int partID)
        {
            var part = _context.Parts.Find(partID);
            _context.Parts.Remove(part);
            _context.SaveChanges();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                // free managed resources
            }
            // free native resources if there are any.
        }


        public bool Exist(int PartID)
        {
            bool result = false;
            if (_context.Parts.Any(c => c.PartID == PartID))
            {
                result = true;
            }

            return result;
        }
      
       

        public List<PartFastSearchDto> SearchParts(string searchTerm, SearchOptions option)
        {
            if (option == SearchOptions.Contains)
            {
                return _context.Parts.AsNoTracking().Where(p => p.ItemDescription.Contains(searchTerm)).Select(d => new PartFastSearchDto
                {
                    PartID = d.PartID,
                    Itemdescription = d.ItemDescription,
                    PartNumber = d.PartNum

                }).ToList();
                
            }
            else if (option == SearchOptions.StartsWith)
            {
                return _context.Parts.AsNoTracking().Where(p => p.ItemDescription.StartsWith(searchTerm)).Select(d => new PartFastSearchDto
                {
                    PartID = d.PartID,
                    Itemdescription = d.ItemDescription,
                    PartNumber = d.PartNum
                }).ToList();
            }
            else
            {
                return null;
            }


        }
        // Return Part of null if not found
        public Part Find(int PartID)
        {
            if (String.IsNullOrEmpty(PartID.ToString()))
            {
                return null;
            }
            return _context.Parts.Include(r => r.Resources).Where(p => p.PartID == PartID).FirstOrDefault();
        }

        public Part FindBySKU(string sku)
        {
            return _context.Parts.Where(p => p.SKU == sku).FirstOrDefault();
        }

        public List<Part> GetAllParts()
        {
            return _context.Parts.ToList();
        }

        public List<PartFastSearchDto> GetManufacturerParts(int ManuID)
        {
            var result = _context.Parts.AsNoTracking().Where(p => p.ManuID == ManuID).Select(d => new PartFastSearchDto
            {
                Itemdescription = d.ItemDescription,
                PartID = d.PartID,
                PartNumber = d.PartNum
                //Orders = _context.PurchaseLineItems.AsNoTracking().Where(o => o.PartID == d.PartID).Count()

            }).ToList();

            return result;
        }

       
        public int InsertOrUpdate(PartDetailDTO partDTO,string user)
        {
          
                
            var part = _context.Parts.Include(r => r.Resources).FirstOrDefault(o => o.PartID == partDTO.PartID);
            if (part == null)
            {
                part = new Part();
                part.DateAdded = DateTime.Today;
                part.AddedBy = user;
                _context.Parts.Add(part);
            }

            //Map properties
            part.PartNum= partDTO.PartNum;
            part.ModifiedDate = DateTime.Today;
            part.ModifiedBy = user;
            part.ObsoluteFlag = partDTO.Obsolete;
            part.Cost = partDTO.UnitCost;
            part.UnitOfMeasureID = partDTO.UID;
            part.Location = partDTO.Location;
            part.PartTypeID = partDTO.PartTypeID;
            part.ManuID = partDTO.ManuId;
            part.ItemDescription = partDTO.ItemDescription;
            part.ItemName = partDTO.ItemName;
            part.PartNum = partDTO.PartNum;
            part.MarkUp = partDTO.MarkUp;
            part.Waste = partDTO.Waste;
            part.Weight = partDTO.Weight;

            //remove deleted resource -
            part.Resources
            .Where(d => !partDTO.Resources.Any(ResourceDto => ResourceDto.ResourceID == d.ResourceID)).ToList()
            .ForEach(deleted => _context.Resources.Remove(deleted));

            //update or add resource
            partDTO.Resources.ToList().ForEach(detailDTO =>
            {
                var detail = part.Resources.FirstOrDefault(d => d.ResourceID == detailDTO.ResourceID);
                if (detail == null)
                {
                    detail = new Resource();
                    detail.CreationDate = DateTime.Today;
                    detail.Createdby = user;                  
                    part.Resources.Add(detail);
                }
               
                detail.ResourceDescription = detailDTO.ResourceDescription;
                detail.PartID = detailDTO.PartID;
                //detail.payload = detailDTO.Payload;
                detail.FileSize = FileHelperService.GetSizeInMemory(detailDTO.Payload.Length);

            });
                _context.SaveChanges();
            return part.PartID;
        }

        public void Save()
        {
            _context.SaveChanges();
        }
        /// <summary>
        /// Return new fleshed out part not saved
        /// </summary>
        /// <returns></returns>
        public Part New()
        {
            Part result = new Part();
           
           
            result.CARBtrack = false;
            result.Cost = 0.0m;
            result.PartNum = string.Empty;
            result.DateAdded = DateTime.Today;
            result.ItemName = string.Empty;
            result.UseSupplierNameFlag = false;
            result.Cost= 0.0m;
            result.UnitOfMeasureID = 1;
            result.ManuID = 1;
            result.SKU= string.Empty;
            result.Waste = 0.0m;
            result.Weight = 0.0m;
            result.AddedBy = "Rich";
            result.MarkUp = 0.0m;
           
              
            return result;
        }

        /// <summary>
        /// TODO this should be moved to another repo of data service
        /// </summary>
        /// <returns></returns>
        public List<Manu> Manufacturers()
        {
            return _context.Manus.ToList();
        }
        /// <summary>
        /// TODO this shuld be moved tomore general list data source
        /// </summary>
        /// <returns></returns>
       

        public void DeleteResource(Document document, Part part)
        {          
            
        }

        public void AddResource(Document document, Part part)
        {
            //if(document.DocId == 0)
            //{
            //    _context.Document.Add(document);
            //    _context.SaveChanges();
            //}
            //part.DocumentParts.Add(new DocumentParts { PartId = part.PartID, DocId = document.DocId });
            //_context.SaveChanges();
        }

        public Part Add(Part part)
        {
            if (part.PartID != 0)
            {
                _context.Parts.Add(part);
                _context.SaveChanges();
                
            }
            return part;
        }

        public List<PartCategory> GetPartCategories()
        {
            var result = _context.PartCategories.AsNoTracking().Include(p => p.PartTypes).ToList();
            return result;
        }

        public List<PartListDto> PartsCategorieList(int Categoryid)
        {
            List<PartListDto> result;
            var dynamicParameters = new DynamicParameters();
            dynamicParameters.Add("PartCategoryID", Categoryid);
            
            string con = "Server = 192.168.10.34; database = Badger; uid = sa; pwd = Kx09a32x;";
            string sql = "SELECT  p.PartID,p.ItemDescription,p.Location, m.Manufacturer FROM Part p, Manu m " +
                         " WHERE PartTypeID IN(SELECT PartTypeID from PartTypes Where PartCategoryID = @ID) AND m.ManuID = p.ManuID";

            using (var connection = new SqlConnection(con))
            {
                connection.Open();
                result = connection.Query<PartListDto>(sql,new { ID = Categoryid}).ToList();
            }
            return result;         
        }

        public List<PartListDto> PartsPartTypeList(int partypeid)
        {
            throw new NotImplementedException();
        }

        public string PartTypeName(int typeID)
        {
            PartType pt = _context.PartTypes.Where(r => r.PartTypeID == typeID).FirstOrDefault();
            PartCategory ct = _context.PartCategories.Where(c => c.PartCategoryID == pt.PartCategoryID).FirstOrDefault();

            return $"{ct.PartCategoryName.Trim()} - {pt.PartTypeName.Trim()}";
        }

        public List<ManuListDTO> GetManus()
        {
            var m = _context.Manus.AsNoTracking().OrderBy(s => s.Manufacturer).Select(d => new ManuListDTO
            {
                ManufacturerName = d.Manufacturer,
                ManuID = d.ManuID
            }).ToList();
            return m;
        }

        public List<PartFastSearchDto> ReturnAllParts()
        {
              var result = _context.Parts.AsNoTracking()
                     .Select(d => new PartFastSearchDto
                     {
                         Itemdescription= d.ItemDescription,
                         PartID = d.PartID,
                         PartNumber = d.PartNum,
                         AddedBy = d.AddedBy,
                         DateAdded = d.DateAdded.GetValueOrDefault().ToShortDateString()


                     }).OrderByDescending(p => p.PartID).ToList();

            return result;
 
        }

        public List<PartSearchDto> SearchPart(string search)
        {
            var result = _context.Parts.AsNoTracking().Where(p => p.ItemDescription.Contains(search)).Select(d => new PartSearchDto
            {
                Description = d.ItemDescription,
                PartID = d.PartID

            }).ToList();

            return result;
        }
        public List<PartFastSearchDto> SearchPart(int partID)
        {


            var result = _context.Parts.AsNoTracking().Where(p => p.PartID.Equals(partID)).Select(d => new PartFastSearchDto
                 {
                     Itemdescription = d.ItemDescription,
                     PartID = d.PartID,
                     PartNumber = d.PartNum,
                     AddedBy = d.AddedBy,
                        DateAdded = d.DateAdded.GetValueOrDefault().ToShortDateString()

            }).OrderByDescending(p => p.PartID).ToList();

            return result;
        }
        /// <summary>
        /// Main Part Searching engine
        /// needs to be optimized for better preformance
        /// </summary>
        /// <param name="search"></param>
        /// <param name="manufactererID"></param>
        /// <param name="manuFilter"></param>
        /// <returns></returns>
            public async Task<List<PartFastSearchDto>> SearchPartAsync(string search, int manufactererID, bool manuFilter, string term2="")
            {

            
     
            // if (manufactererID != 0 || manufactererID == 1)
            if (manuFilter)
            {
                 var result = _context.Parts.AsNoTracking().Where(p => p.ItemDescription.Contains(search))
                     .Where(m => m.ManuID == manufactererID).Select(d => new PartFastSearchDto
                     {
                         Itemdescription = d.ItemDescription,
                         PartID = d.PartID,
                         PartNumber = d.PartNum,
                         AddedBy = d.AddedBy,
                         DateAdded = d.DateAdded.GetValueOrDefault().ToShortDateString()

                     }).OrderByDescending(p => p.PartID).ToListAsync();
            
                return await result;
            }
            else
            {
                
                
                    var  result = _context.Parts.AsNoTracking().Where(p => p.ItemDescription.Contains(search)).Select(d => new PartFastSearchDto
                    {
                        Itemdescription = d.ItemDescription,
                        PartID = d.PartID,
                        PartNumber = d.PartNum,
                        AddedBy = d.AddedBy,
                        DateAdded = d.DateAdded.GetValueOrDefault().ToShortDateString()

                    }).ToListAsync();
                    
                
               
            return await result;
            }

        }



        public IEnumerable<PartFastSearchDto> FastPartSearch(string term)
        {

            List<PartFastSearchDto> result;
            var dynamicParameters = new DynamicParameters();
            dynamicParameters.Add("TERM", term);

            string con = "Data Source=DBServer;Initial Catalog=Mosaic;Integrated Security=True";
            string sql = "select PartID,ItemDescription,AddedBy,CONVERT(CHAR, DateAdded, 1) AS DateAdded,ModifiedBy,PartNum from Part " +
                            "where ItemDescription LIKE '%' + @term + '%' ";

            using (var connection = new SqlConnection(con))
            {
                connection.Open();
                result = connection.Query<PartFastSearchDto>(sql, new { term = term }).ToList();
            }
            return result;


        }
        /// <summary>
        /// dapper query result orders with this partID in the items
        /// </summary>
        /// <param name="partID"></param>
        /// <returns></returns>
        public List<PartOrdersDto> GetPartOrders(int partID)
        {
           
            List<PartOrdersDto> result;
            var dynamicParameters = new DynamicParameters();
            dynamicParameters.Add("PartID", partID);
            string con = "Data Source=Dbserver;Initial Catalog=Mosaic;Integrated Security=True";
            string sql = "select p.PurchaseOrderID, s.SupplierName,j.jobname,p.OrderDate FROM PurchaseOrder AS p " +
                            "INNER JOIN Supplier s ON p.SupplierID = p.SupplierID " +
                            "INNER JOIN Job j ON p.JobID = j.jobID " +
                            "where PurchaseOrderID in (select PurchaseOrderID from PurchaseLineItem where PartID = @ID ) " +
                            "and p.SupplierID = s.SupplierID " +
                            "and p.JobID = p.JobID";

            using (var connection = new SqlConnection(con))
            {
                connection.Open();
                result = connection.Query<PartOrdersDto>(sql, new { ID = partID }).ToList();
            }
            return result;
        }

      
        public void CreateOrUpdatePart(PartDetailDTO partdto, string user)
        {
            var part = _context.Parts.Include(r => r.Resources).FirstOrDefault(p => p.PartID == partdto.PartID);
            if (part == null)
            {
                part = new Part();
                part.AddedBy = user;
                part.DateAdded = DateTime.Today;
                _context.Parts.Add(part);

            }
            // Map Properties --
            part.Amount_Required= 0;
            part.Cost = partdto.UnitCost;
            part.ItemDescription = partdto.ItemDescription;
            part.ModifiedDate = DateTime.Today;
            part.ObsoluteFlag = partdto.Obsolete;
            part.PartNum = partdto.PartNum;
            part.ItemName = partdto.ItemName;
            part.PartTypeID = partdto.PartTypeID;
            part.SKU = partdto.Sku;
            part.Waste = partdto.Waste;
            part.Weight = partdto.Weight;
            part.ModifiedBy = user;
            part.UnitOfMeasureID = partdto.UID;
            part.ManuID = partdto.ManuId;
           
            part.Location = partdto.Location;

            // Remove deleted resources ------------------------
            part.Resources
                .Where(d => !partdto.Resources.Any(DTO => DTO.ResourceID == d.ResourceID)).ToList()
                   .ForEach(deleted => _context.Resources.Remove(deleted));

            partdto.Resources.ToList().ForEach(pr =>
            {
                var resource = part.Resources.FirstOrDefault(r => r.ResourceID == pr.ResourceID);
                if (resource == null)
                {
                    resource = new Resource();
                    resource.Createdby = user;
                    resource.CreationDate = DateTime.Today;
                    part.Resources.Add(resource);
                }
                resource.FileSize = pr.Filesize;
                resource.filesource = pr.Filesource;
                resource.Lastmod = DateTime.Today;
                resource.PartID = pr.PartID;
                resource.ResourceDescription = pr.ResourceDescription;
               // resource.payload = pr.Payload;


            });

            _context.SaveChanges();

        }

      
    }
}
