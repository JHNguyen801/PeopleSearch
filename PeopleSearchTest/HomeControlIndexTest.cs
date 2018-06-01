using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PeopleSearch.Controllers;
using PeopleSearch.Models;
using System.Threading.Tasks;

namespace PeopleSearchTest
{
    [TestClass]
    public class HomeControlIndexTest
    {
        [TestMethod]
        public void HomeIndexTests()
        {
            PeopleController controller = new PeopleController();
            ViewResult result = controller.View() as ViewResult;
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void HomeCreateTests()
        {
            PeopleController controller = new PeopleController();
            ViewResult result = controller.Create() as ViewResult;
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void HomeViewTests()
        {
            PeopleController controller = new PeopleController();
            ViewResult result = controller.View() as ViewResult;
            Assert.IsNotNull(result);
        }

    }
}
