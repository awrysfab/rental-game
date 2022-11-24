using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace game_rental.Models
{
    public class Genre
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Game> Games { get; set; }
    }
}