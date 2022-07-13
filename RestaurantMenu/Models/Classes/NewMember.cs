using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RestaurantMenu.Models.Classes
{
    public class NewMember
    {
        [Key]
        public int MemberId { get; set; }
        public string MemberName { get; set; }
        public string MemberSurname { get; set; }
        public string MemberPassword { get; set; }
        public string MemberMail{ get; set; }
        public string MemberCity { get; set; }
    }
}