using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RestaurantMenu.Models.Classes
{
    public class Writer
    {
        [Key]
        public int WriterId { get; set; }
        public string WriterName { get; set; }
        public string WriterSurname { get; set; }
        public string WriterPassword { get; set; }
        public string WriterMail { get; set; }

        public int BlogId { get; set; }
        public virtual Blog Blog { get; set; }
    }
}