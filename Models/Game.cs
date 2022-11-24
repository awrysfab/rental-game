using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace game_rental.Models
{
    public class Game
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }
        public string Photo { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public int? Stock { get; set; }
        public int? GenreID { get; set; }
        public virtual Genre Genre { get; set; }
    }
}