using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using DataLayer.Entity;
using DataLayer.Data;

namespace ServiceLayer
{

    public class SuppliersService  {

        MosaicContext _context;

        public SuppliersService(MosaicContext Context) {

            _context = Context;
        }

        public List<Supplier> GetAll()
        {
            return _context.Suppliers.ToList();
        }

        public bool Exist(int supplierID) {
                       
            return _context.Suppliers.Any(c => c.SupplierID == supplierID);          
        }

        public Supplier Find(int supplierID) {

            return _context.Suppliers.Where(c => c.SupplierID == supplierID).FirstOrDefault();
        }

        public List<Supplier> Find(string supplierName) {

            List<Supplier> result;
            result = _context.Suppliers.Where(c => c.SupplierName.StartsWith(supplierName)).ToList();        
            return result;
        }

        public List<Supplier> SuppliersWithOpenOrders()
        {
            return _context.Suppliers.FromSqlRaw("select * FROM Supplier WHERE SupplierID IN (SELECT supplierID from PurchaseOrder WHERE RECIEVED = 0)").ToList();
        }

        public void InsertOrUpdate(Supplier supplier) {

            if (supplier.SupplierID == default(int))
            {
                //_context.Entry(supplier).State = EntityState.Added;
                _context.Suppliers.Add(supplier);
            }
            else
            {
                _context.Suppliers.Attach(supplier);
            }
        }

        public void Save() { _context.SaveChanges(); }


    }
}
