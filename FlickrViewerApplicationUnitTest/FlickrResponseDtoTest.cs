using FlickrViewerApplication.Dto;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FlickrViewerApplicationUnitTest
{
    [TestClass]
    public class FlickrResponseDtoTest
    {
        private FlickrResponseDto _instance;

        [TestInitialize]
        public void Initialize()
        {
            _instance = new FlickrResponseDto();
        }
        [TestMethod]
        public void FlickrResponseDto_BasicConstructorTest()
        {
            Assert.AreEqual(null,_instance.Items);
            Assert.AreEqual("", _instance.Title);
            Assert.AreEqual("", _instance.Description);
            Assert.AreEqual("", _instance.Generator);
            Assert.AreEqual("", _instance.Link);
            Assert.AreEqual("", _instance.Modified);
        }

        [TestMethod]
        public void FlickrResponseDto_AreNotEqual_BasicConstructorTest()
        {
            Assert.AreNotEqual("", _instance.Items);
            Assert.AreNotEqual(0, _instance.Title);
            Assert.AreNotEqual(0, _instance.Description);
            Assert.AreNotEqual(0, _instance.Generator);
            Assert.AreNotEqual(0, _instance.Link);
            Assert.AreNotEqual(0, _instance.Modified);
        }
    }
}
