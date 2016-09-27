using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AroundRouter.Models;
using Xunit;

namespace AroundRouter.Tests
{
    public class LocationTest
    {
        [Fact]
        public void GetDescriptionTest()
        {
            var Location = new Location();
            Location.Description = "Wash the Parakeet";
            var result = Location.Description;
            Assert.Equal("Wash the Parakeet", result);
        }
    }
}
