using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LTQL_quanlythuvien.Models
{
    [Table("Accounts")]
    public class Account
    {
        [Key]
        public string Username { get; set; }
        public string Password { get; set; }
    }
}