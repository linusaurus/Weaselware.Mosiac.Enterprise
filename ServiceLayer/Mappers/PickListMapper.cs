using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Entity;
using Boxed.Mapping;
using ServiceLayer.Models;

namespace ServiceLayer.Mappers
{
    public class PickListMapper : IMapper<PickList, PickListDto>
    {

        private readonly IMapper<PickListItem, PickListItemDto> lineMapper = new PickListItemMapper();
        public void Map(PickList source, PickListDto destination)
        {
            destination.PickListID = source.PickListID;
            destination.DateStamp = source.DateStamp.GetValueOrDefault();
            destination.PickListID = source.PickListID;
            destination.EmployeeID = source.EmployeeID.GetValueOrDefault();
            destination.JobID = source.JobID.GetValueOrDefault();
           if (source.Job != null) { destination.JobName = source.Job.jobname; }
            if (source.Employee != null) { destination.Preparer = source.Employee.firstname; }

            destination.ItemCount = source.pickListItems.Count;
            destination.Delivered = source.Delivered.GetValueOrDefault();
            destination.DeliveryDate = source.DeliveryDate.GetValueOrDefault();
            destination.Submitted = source.Submitted.GetValueOrDefault();
            destination.PickListItems = lineMapper.MapList(source.pickListItems);
        }

        public class PickListItemMapper : IMapper<PickListItem , PickListItemDto>
        {
            public void Map(PickListItem source, PickListItemDto destination)
            {
                destination.PickListItemID = source.PickListItemID;
                destination.PickListID = source.PickListID.GetValueOrDefault();
                destination.Qnty = source.Qnty.GetValueOrDefault();
                destination.Description = source.Description;
                destination.Delivered = source.Delivered.GetValueOrDefault();
                destination.PartID = source.PartID.GetValueOrDefault();
                destination.Onboard = source.Onboard.GetValueOrDefault();
                destination.Delivered = source.Delivered.GetValueOrDefault();
                destination.ProductID = source.ProductID.GetValueOrDefault();
                destination.StockTransActionID = source.StockTransActionID.GetValueOrDefault();
            }
    
        }
    }
}
