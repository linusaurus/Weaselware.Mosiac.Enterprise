using DataLayer.Entity;
using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Models
{
    public class OrderReceiptItemWrapper : ObservableObject
    {
        private readonly OrderReceiptItems orderReceiptItems;

        public OrderReceiptItemWrapper(OrderReceiptItems orderReceiptItems) => this.orderReceiptItems = orderReceiptItems;

        public int OrderReceiptLineID 
        { 
            get => this.orderReceiptItems.OrderReceiptLineID;
            set => SetProperty(orderReceiptItems.OrderReceiptLineID,value,orderReceiptItems,(u,n) => u.OrderReceiptLineID = n); 
        }
        public int? LineID
        {
            get => orderReceiptItems.LineID;
            set => SetProperty(orderReceiptItems.LineID, value, orderReceiptItems, (u, n) => u.LineID = n);
            
        }
        public int? PurchaseOrderID
        {
            get => this.orderReceiptItems.PurchaseOrderID;
            set => SetProperty(orderReceiptItems.PurchaseOrderID, value , orderReceiptItems, (u,n) => u.PurchaseOrderID = n);
        }
        public int? JobID
        {
            get => this.orderReceiptItems.JobID;
            set => SetProperty(orderReceiptItems.JobID, value, orderReceiptItems, (u, n) => u.JobID = n);
        }
        public int? UnitOfMeasureID
        {
            get => this.orderReceiptItems.UnitOfMeasureID; 
            set => SetProperty(orderReceiptItems.UnitOfMeasureID, value, orderReceiptItems, (u, n) => u.UnitOfMeasureID = n);
        }
        public int? PartID
        {
            get => this.orderReceiptItems.PartID; 
            set => SetProperty(orderReceiptItems.PartID, value, orderReceiptItems, (u, n) => u.PartID = n);
        }
        public decimal? QuantityOrdered
        {
            get => this.orderReceiptItems.QuantityOrdered;
            set => SetProperty(orderReceiptItems.QuantityOrdered, value, orderReceiptItems, (u, n) => u.QuantityOrdered = n);
        }
        public decimal? QuantityReceived
        {
            get => this.orderReceiptItems.QuantityReceived; 
            set => SetProperty(orderReceiptItems.QuantityReceived, value, orderReceiptItems, (u, n) => u.QuantityReceived = n);
        }
        public decimal? Balance
        {
            get => this.orderReceiptItems.Balance;
            set => SetProperty(orderReceiptItems.Balance, value, orderReceiptItems, (u, n) => u.Balance = n);
        }
        public string Description
        {
            get => this.orderReceiptItems.Description;
            set => SetProperty(orderReceiptItems.Description, value,orderReceiptItems, (u, n) => u.Description = n);
        }
        public decimal? Price
        {
            get => this.orderReceiptItems.Price; set => SetProperty(orderReceiptItems.Price, value, orderReceiptItems, (u, n) => u.Price = n);
        }
        public decimal? Extended
        {
            get => this.orderReceiptItems.Extended; 
            set => SetProperty(orderReceiptItems.Extended, value,orderReceiptItems, (u, n) => u.Extended = n);
        }
        public bool? IsComplete
        {
            get => this.orderReceiptItems.IsComplete; 
            set => SetProperty(orderReceiptItems.IsComplete, value, orderReceiptItems, (u, n) => u.IsComplete = n);
        }
        public int? OrderReceiptID
        {
            get => this.orderReceiptItems.OrderReceiptID;
            set => SetProperty(orderReceiptItems.OrderReceiptID, value, orderReceiptItems, (u, n) => u.OrderReceiptID = n);
        }
        public string Note
        {
            get => this.orderReceiptItems.Note; 
            set => SetProperty(orderReceiptItems.Note, value, orderReceiptItems, (u, n) => u.Note = n);
        }
        //public decimal? InventoryAmount
        //{
        //    get => this.orderReceiptItems.InventoryAmount;
        //    set=> SetProperty(orderReceiptItems.InventoryAmount, value, orderReceiptItems, (u, n) => u.InventoryAmount = n);
        //}
        public bool? Pushed
        {
            get => this.orderReceiptItems.Pushed;
            set => SetProperty(orderReceiptItems.Pushed, value, orderReceiptItems, (u, n) => u.Pushed = n);
        }
        
    }
}
