using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AroundRouter.Models
{
    [Table("Locations")]
    public class Location
    {
        [Key]
        public int LocationId { get; set; }
        public string Name { get; set; }
        public string AddressLine { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public virtual Route Route { get; set; }

        

        public override bool Equals(System.Object otherLocation)
        {
            if (otherLocation is Location)
            {
                Location newLocation = (Location)otherLocation;
                return this.LocationId.Equals(newLocation.LocationId);
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            return this.LocationId.GetHashCode();
        }
    }

}
