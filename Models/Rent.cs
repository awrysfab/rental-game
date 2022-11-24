using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace game_rental.Models
{
    public class Rent
    {
        public int ID { get; set; }
        public DateTime? RentDate { get; set; }
        public DateTime? DueDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public int? GameID { get; set; }
        public int? RenterID { get; set; }
        public virtual Game Game { get; set; }
        public virtual Renter Renter { get; set; }
    }
}