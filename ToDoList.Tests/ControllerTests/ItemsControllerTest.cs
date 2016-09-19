using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ToDoList.Controllers;
using ToDoList.Models;
using Xunit;

namespace ToDoList.Tests.ControllerTests
{
    public class ItemsControllerTest
    {
        [Fact]
        public void Get_ViewResult_Index_Test()
        {
            ItemsController controller = new ItemsController();

            var result = controller.Index();

            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Get_ModelList_Index_Test()
        {
            ItemsController controller = new ItemsController();
            IActionResult actionResult = controller.Index();
            ViewResult indexView = controller.Index() as ViewResult;

            var result = indexView.ViewData.Model;

            Assert.IsType<List<Item>>(result);
        }
         
        [Fact]
        public void Post_MethodAddsItem_Test()
        {
            ItemsController controller = new ItemsController();
            Item testItem = new Item();
            testItem.Description = "Test Item";

            controller.Create(testItem);
            ViewResult indexView = new ItemsController().Index() as ViewResult;
            var collection = indexView.ViewData.Model as IEnumerable<Item>;

            Assert.Contains<Item>(testItem, collection);
        } 
    }
}
