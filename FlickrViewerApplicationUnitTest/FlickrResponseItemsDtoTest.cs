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
    public class FlickrResponseItemsDtoTest
    {
        private FlickrResponseItemsDto _instance;

        [TestInitialize]
        public void Initialize()
        {
            _instance = new FlickrResponseItemsDto();
        }

        [TestMethod]
        public void FlickrResponseItemsDto_BasicConstructorTest()
        {
            Assert.AreEqual(null, _instance.Media);
            Assert.AreEqual("", _instance.Title);
            Assert.AreEqual("", _instance.Description);
            Assert.AreEqual("", _instance.Author);
            Assert.AreEqual("", _instance.Link);
            Assert.AreEqual("", _instance.AuthorId);
            Assert.AreEqual("", _instance.Published);
            Assert.AreEqual("", _instance.Tags);
        }

        [TestMethod]
        public void FlickrResponseItemsDto_AreNotEqual_BasicConstructorTest()
        {
            Assert.AreNotEqual("", _instance.Media);
            Assert.AreNotEqual(0, _instance.Title);
            Assert.AreNotEqual(0, _instance.Description);
            Assert.AreNotEqual(0, _instance.Author);
            Assert.AreNotEqual(0, _instance.Link);
            Assert.AreNotEqual(0, _instance.AuthorId);
            Assert.AreNotEqual(0, _instance.Published);
            Assert.AreNotEqual(0, _instance.Tags);
        }
    }
}
