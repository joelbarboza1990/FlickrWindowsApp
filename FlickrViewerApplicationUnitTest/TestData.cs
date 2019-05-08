using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FlickrViewerApplicationUnitTest
{
    public class TestData
    {
        public static string GetJsonData()
        {
            var stream = File.OpenText(AppDomain.CurrentDomain.BaseDirectory +"\\JsonTestData.json");
            //Read the file              
            return stream.ReadToEnd();
        }
    }
}
