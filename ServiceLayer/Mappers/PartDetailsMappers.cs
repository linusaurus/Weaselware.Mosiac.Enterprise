using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Entity;
using ServiceLayer.Models;
using Boxed.Mapping;
using System.Security.Cryptography;

namespace ServiceLayer.Mappers
{
    public class PartMapper : IMapper<Part, PartDetailDTO>
    {

        private readonly IMapper<Resource, ResourceDto> resourceMapper = new PartResourceMapper();


        public void Map(Part source, PartDetailDTO destination)
        {
            if (source == null) { return; }
            destination.PartID = source.PartID;
            destination.ItemDescription = source.ItemDescription;
            destination.ItemName = source.ItemName;
            destination.PartNum = source.PartNum;
            destination.PartTypeID = source.PartTypeID.GetValueOrDefault();
            destination.Location = source.Location;
            destination.UnitCost = source.Cost.GetValueOrDefault();
            destination.UID = source.UnitOfMeasureID.GetValueOrDefault();
            destination.ManuId = source.ManuID.GetValueOrDefault();
            destination.MarkUp = source.MarkUp.GetValueOrDefault();
            destination.AddedBy = source.AddedBy;
            destination.DateAdded = source.DateAdded.GetValueOrDefault();
            destination.ModifiedBy = source.ModifiedBy;
            destination.ModifiedDate = source.ModifiedDate.GetValueOrDefault();
            destination.Sku = source.SKU;
            destination.Weight = source.Weight.GetValueOrDefault();
            destination.Waste = source.Waste.GetValueOrDefault();
            destination.Obsolete = source.ObsoluteFlag.GetValueOrDefault();
            destination.CarbTrack = source.CARBtrack.GetValueOrDefault();
           destination.Resources = resourceMapper.MapList(source.Resources);
           
        }
    }

    public class PartResourceMapper : IMapper<Resource, ResourceDto>
    {

        public void Map(Resource source, ResourceDto destination)
        {
            destination.ResourceID = source.ResourceID;
            destination.PartID = source.PartID.GetValueOrDefault();
            destination.Createdby = source.Createdby;
            destination.CreationDate = source.CreationDate.GetValueOrDefault();
            destination.ResourceDescription = source.ResourceDescription;
            destination.ResourceID = source.ResourceID;
            destination.Filesize = source.FileSize;
            destination.Filesource = source.filesource;
            destination.Payload = source.payload;
        }
    }
}
