using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Sky.Models
{
    public class User
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string Firstname { get; set; }

        [StringLength(70)]
        public string Lastname { get; set; }

        [StringLength(50), Required]
        public string Username { get; set; }

        [StringLength(150), Required]
        public string Email { get; set; }
    }
}