using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AroundRouter.Controllers;
using AroundRouter.Models;
using Xunit;

namespace AroundRouter.Tests.ControllerTests
{
    public class LocationsControllerTest
    {
        [Fact]
        public void Get_ViewResult_Index_Test()
        {
            LocationsController controller = new LocationsController();

            var result = controller.Index();

            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Get_ModelList_Index_Test()
        {
            LocationsController controller = new LocationsController();
            IActionResult actionResult = controller.Index();
            ViewResult indexView = controller.Index() as ViewResult;

            var result = indexView.ViewData.Model;

            Assert.IsType<List<Location>>(result);
        }
         
        [Fact]
        public void Post_MethodAddsLocation_Test()
        {
            LocationsController controller = new LocationsController();
            Location testLocation = new Location();
            testLocation.Description = "Test Location";

            controller.Create(testLocation);
            ViewResult indexView = new LocationsController().Index() as ViewResult;
            var collection = indexView.ViewData.Model as IEnumerable<Location>;

            Assert.Contains<Location>(testLocation, collection);
        } 
    }
}
