using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RestaurantMenu.Models.Classes
{
    public class Abouts
    {
        [Key]
        public int Id { get; set; }
        public string ChefName { get; set; }
        public string FotoUrl { get; set; }
        public string Explanation { get; set; }
    }
}