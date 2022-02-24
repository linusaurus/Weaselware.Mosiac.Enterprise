using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using DataLayer.Entity;
using ServiceLayer.Models;
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

        public List<SuppliersListDto> Search(string term)
        {
            var result = _context.Suppliers.AsNoTracking().Where(f => f.SupplierName.Contains(term)).Select(d => new SuppliersListDto
            {
               SupplierID = d.SupplierID,
               SupplierName = d.SupplierName
            });
            return result.ToList();
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

        public List<SupplierOrdersListDto> GetSupplierOrders(int SupplierID)
        {
            var result = _context.PurchaseOrders.AsNoTracking().Include(j => j.Job).Where(f => f.SupplierID == SupplierID).OrderByDescending(d => d.OrderDate).Select(d => new SupplierOrdersListDto
            {
                OrderNumber = d.PurchaseOrderID,
                OrderDate = d.OrderDate.GetValueOrDefault(),
                Purchaser = d.Employee.firstname + " " + d.Employee.lastname,
                JobName = d.Job.jobname,
                OrderTotal = d.OrderTotal.GetValueOrDefault(),
                Received = d.Recieved.GetValueOrDefault()
            }) ;

            return result.ToList();

        }

        public List<Supplier> SuppliersWithOpenOrders()
        {
            return _context.Suppliers.FromSqlRaw("select * FROM Supplier WHERE SupplierID IN (SELECT supplierID from PurchaseOrder WHERE OrderState = 1 Or OrderState = 3)").ToList();
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
