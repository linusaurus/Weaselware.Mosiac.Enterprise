using DataLayer.Entity;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Models
{
    public class InventoryWrapper : ObservableObject
    {
        private readonly Inventory inventory;

        public InventoryWrapper(Inventory inventory) => this.inventory = inventory;

        public int StockTransactionID
        {
            get => this.inventory.StockTransactionID;
            set => SetProperty(inventory.StockTransactionID, value, inventory, (u, n) => u.StockTransactionID = n);
        }
        public int? OrderReceiptID
        {
            get => this.inventory.OrderReceiptID;
            set => SetProperty(inventory.OrderReceiptID, value, inventory, (u, n) => u.OrderReceiptID = n);
        }

        public int? LineID
        {
            get => this.inventory.LineID;
            set => SetProperty(inventory.LineID, value,inventory,(u,n) => u.LineID = n);
        }

        public int? PartID
        {
            get => this.inventory.PartID; 
            set => SetProperty(inventory.PartID, value, inventory, (u, n) => u.PartID = n); 
        }

        public int? JobID
        {
            get => this.inventory.JobID;
            set => SetProperty(inventory.JobID, value, inventory, (u, n) => u.JobID = n);
        }

        public string Location
        {
            get => this.inventory.Location;
            set => SetProperty(inventory.Location, value, inventory, (u, n) => u.Location = n);
        }

        public int? ProductID
        {
            get => inventory.ProductID;
            set => SetProperty(inventory.ProductID, value, inventory, (u, n) => u.ProductID = n);
        }

        public DateTime? DateStamp
        {
            get => inventory.DateStamp;
            set => SetProperty(inventory.DateStamp, value, inventory, (u, n) => u.DateStamp = n);
        }

        public decimal? QntyOrdered
        {
            get => inventory.QntyOrdered; 
            set => SetProperty(inventory.QntyOrdered, value, inventory, (u, n) => u.QntyOrdered = n);
        }

        public string Note
        {
            get => this.inventory.Note;
            set=> SetProperty(inventory.Note, value, inventory, (u, n) => u.Note = n);
        }
        public string Description
        {
            get => this.inventory.Description;
            set => SetProperty(inventory.Description, value, inventory, (u, n) => u.Description = n);
        }
        public int? UnitOfMeasureID
        {
            get => inventory.UnitOfMeasureID; 
            set => SetProperty(inventory.UnitOfMeasureID, value, inventory, (u, n) => u.UnitOfMeasureID = n);
        }

        public int? TransActionType
        {
            get => inventory.TransActionType; 
            set => SetProperty(inventory.TransActionType, value, inventory, (u, n) => u.TransActionType = n);
        }
        public int? EmpID
        {
            get => inventory.EmpID; 
            set => SetProperty(inventory.EmpID, value, inventory, (u, n) => u.EmpID = n);
        }

        public decimal? QntyReceived
        {
            get => inventory.QntyReceived; 
            set => SetProperty(inventory.QntyReceived, value, inventory, (u, n) => u.QntyReceived = n);
        }
        public decimal? InventoryAmount
        {
            get => inventory.InventoryAmount; 
            set => SetProperty(inventory.InventoryAmount, value, inventory, (u, n) => u.InventoryAmount = n);
        }
    }
}
