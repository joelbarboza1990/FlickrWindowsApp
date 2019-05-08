using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlickrViewerApplication.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FlickrViewerApplicationUnitTest
{
    [TestClass]
    public class FlickrServiceTest
    {

        [TestMethod]
        public void BuildJsonData_NullParam()
        {
            FlickrService instance = new FlickrService();
            var returnValue = instance.BuildFlickrJsonData("");
            Assert.AreEqual(null,returnValue);
        }

        [TestMethod]
        public void BuildJsonData_ValidStringParam()
        {
            FlickrService instance = new FlickrService();
            var returnValue = instance.BuildFlickrJsonData(TestData.GetJsonData());
            Assert.IsNotNull(returnValue);
            Assert.AreEqual(20,returnValue.Items.Count);
            Assert.IsNotNull(returnValue.Description);
            Assert.IsNotNull(returnValue.Modified);
        }
    }
}
