using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlickrViewerApplication.Dto;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FlickrViewerApplicationUnitTest
{
    [TestClass]
    public class MediaDtoTest
    {
        private MediaDto _instance;

        [TestInitialize]
        public void Initialize()
        {
            _instance = new MediaDto();
        }

        [TestMethod]
        public void FlickrResponseItemsDto_BasicConstructorTest()
        {
            Assert.AreEqual("", _instance.m);
        }
        [TestMethod]
        public void FlickrResponseItemsDto_WrongValues_BasicConstructorTest()
        {
            Assert.AreNotEqual(0, _instance.m);
        }
    }
}
