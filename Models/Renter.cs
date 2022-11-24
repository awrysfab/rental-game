using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace game_rental.Models
{
    public class Renter
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public virtual ICollection<Rent> Rents { get; set; }
    }
}