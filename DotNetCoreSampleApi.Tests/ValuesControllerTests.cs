using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using DotNetCoreSampleApi.Controllers;

namespace DotNetCoreSampleApi.Tests
{
    [TestClass]
    public class ValuesControllerTest
    {
        [TestMethod]
        public void Get_ShouldReturn_Value1AndValue2()
        {
            var controller = new ValuesController();

            var values = controller.Get().ToList(); // retrieves values as a list of string

            Assert.IsTrue(values.Contains("value1"), "value1 is not returned");
            Assert.IsTrue(values.Contains("value2"), "value2 is not returned");
        }
    }
}