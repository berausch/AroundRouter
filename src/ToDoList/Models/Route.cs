using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace AroundRouter.Models
{
    [Table("Routes")]
    public class Route
    {
        public Route()
        {
            this.Locations = new HashSet<Location>();
        }
        [Key]
        public int RouteId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Location> Locations { get; set; }
    }
}
