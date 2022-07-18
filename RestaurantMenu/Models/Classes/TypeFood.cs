using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RestaurantMenu.Models.Classes
{
    public class TypeFood
    {
        [Key]
        public int TypeId { get; set; }
        public string TypeName { get; set; }
        public ICollection<FoodList> FoodLists { get; set; }
    }
}