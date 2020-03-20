using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ChatCom.Models
{
    public class User
    {
        public User()
        {

        }

        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string name { get; set; }
        public DateTime Created_at { get; set; }
    }
}