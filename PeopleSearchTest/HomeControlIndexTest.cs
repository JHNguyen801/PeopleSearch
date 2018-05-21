using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PeopleSearch.Controllers;
using System.Threading.Tasks;

namespace PeopleSearchTest
{
    [TestClass]
    public class HomeControlIndexTest
    {
        [TestMethod]
        public void HomeIndexTests()
        {
            HomeController controller = new HomeController();
            ViewResult result = controller.Index() as ViewResult;
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void ContactResult()
        {
            HomeController controller = new HomeController();

            ViewResult result = controller.Contact() as ViewResult;
            Assert.IsNotNull(result);
        }
    }
}
