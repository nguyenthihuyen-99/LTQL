using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LTQL_quanlythuvien.Models
{
    [Table("AccountModels")]
    public class AccountModel
    {
        //validation with Model
        //User ko dc để trống
        [Key]
        [Required(ErrorMessage = "Username is required.")]
        public string Username { get; set; }

        //password ko dc để trống
        [Required(ErrorMessage = "Password is required.")]
        //định nghĩa datatype
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public string RoleID { get; set; }
    }
}