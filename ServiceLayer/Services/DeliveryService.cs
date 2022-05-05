using System;
using System.Collections.Generic;
using System.Text;
using DataLayer.Data;
using ServiceLayer.Models;

namespace ServiceLayer.Services
{

    
    public class DeliveryService
    {
        private readonly MosaicContext _ctx;

        public DeliveryService(MosaicContext context)
        {
            _ctx = context;
        }


    }
}
