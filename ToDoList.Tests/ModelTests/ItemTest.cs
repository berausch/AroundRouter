using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoList.Models;
using Xunit;

namespace ToDoList.Tests
{
    public class ItemTest
    {
        [Fact]
        public void GetDescriptionTest()
        {
            var item = new Item();
            item.Description = "Wash the Parakeet";
            var result = item.Description;
            Assert.Equal("Wash the Parakeet", result);
        }
    }
}
