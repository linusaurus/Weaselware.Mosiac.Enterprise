﻿using System;
using System.Collections.Generic;
using System.Linq;
using DataLayer.Data;
using DataLayer.Entity;
using ServiceLayer.Mappers;
using ServiceLayer.Models;
using ServiceLayer.Overloads;
using Microsoft.EntityFrameworkCore;


namespace ServiceLayer {
    public class EmployeeService  {

        MosaicContext context;

        public EmployeeService(MosaicContext Context) {

            context = Context;
        }

        public List<EmployeeListDto> All()
        {
            var _emps = context.Employee.AsNoTracking().OrderBy(p => p.lastname).Select(d => new EmployeeListDto
            {
                EmployeeID = d.employeeID,
                FullName = String.Format("{0} {1}",d.firstname, d.lastname)

            }).ToList();
            return _emps; 
        }

        public List<EmployeeListDto> Active()
        {
            var _emps = context.Employee.AsNoTracking().OrderBy(p => p.lastname).Where(a => a.Show==true).Select(d => new EmployeeListDto
            {
                EmployeeID = d.employeeID,
                FullName = String.Format("{0} {1}", d.firstname, d.lastname)

            }).ToList();
            return _emps;
        }

        public List<Employee> AllIncluding(params System.Linq.Expressions.Expression<Func<Employee, object>>[] includeProperties) {
            throw new NotImplementedException();
        }

        public Employee Find(int id) {
            return context.Employee.Find(id);
        }

        public List<PurchaseOrder> EmployeeOrders(int employeeID) {

            return context.PurchaseOrder.Where(e => e.EmployeeID == employeeID).ToList();
        }

        public List<OrderReciept> EmployeeReciepts(int employeeID) {

            return context.OrderReciept.Where(e => e.EmployeeID == employeeID).ToList();
        }

        public Employee Find(string firstName) {

            return context.Employee.Where(e => e.firstname.Contains(firstName)).FirstOrDefault();
        }

        public void InsertOrUpdate(Employee employee) {
            if (employee.employeeID == default(int))
            { context.Entry(employee).State = EntityState.Added; }

            else
            { context.Entry(employee).State = EntityState.Modified; }

        }

        public void Delete(int id) {
            var employee = context.Employee.Find(id);
            context.Employee.Remove(employee);
        }

        public void Save() {
            context.SaveChanges();
        }

        public void Dispose()
        {
            context = null;
            this.Dispose();
        }

        public string FullName(int EmpID)
        {
           var emp =  context.Employee.Find(EmpID);
            return emp.firstname + " " + emp.lastname;
            
        }

       
    }
}
