using NUnit.Framework;
using ServiceLayer;
using ServiceLayer.Models;
using System;

namespace MosaicTextProject
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
           PickList pick = new PickList();
            pick.Complete = true;
            pick.DateStamp = DateTime.Now;
            pick.ItemCount = 3;
            pick.JobID = 1304;
            pick.PickListID = 13345;
            Assert.IsTrue(pick.Complete == true);
            
        }
       
    }
}