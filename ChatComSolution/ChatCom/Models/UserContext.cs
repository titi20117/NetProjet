using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ChatCom.Models
{
    public class UserContext : DbContext
    {
        public UserContext() : base("ChatComConnection")
        {

        }
        public static UserContext Create()
        {
            return new UserContext();
        }
        public DbSet<User> Users { get; set; }
    }
}