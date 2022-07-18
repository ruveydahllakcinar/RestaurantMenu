using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RestaurantMenu.Models.Classes
{
    public class FoodList
    {
        [Key]
        public int Id { get; set; }
        public string EatName { get; set; }
        public string Price { get; set; }
        public string Img { get; set; }
        public string Explanation { get; set; }

        public int TypeId { get; set; }
        public virtual TypeFood TypeFood { get; set; }

    }
}