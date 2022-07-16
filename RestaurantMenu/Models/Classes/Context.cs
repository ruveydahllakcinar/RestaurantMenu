using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RestaurantMenu.Models.Classes
{
    public class Context:DbContext
    {
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Abouts> Abouts { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Comments> Comments { get; set; }
        public DbSet<FoodList> FoodLists { get; set; }
        public DbSet<TypeofFood> TypeofFoods { get; set; }
        public DbSet<NewMember> NewMembers  { get; set; }
        public DbSet<Writer> Writers  { get; set; }
    }
}