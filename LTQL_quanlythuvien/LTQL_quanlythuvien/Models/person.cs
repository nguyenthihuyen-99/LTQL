using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LTQL_quanlythuvien.Models
{
    [Table("persons")]
    public class person
    {
        [Key]
        public string CCCD { get; set; }
        public string hoten { get; set; }
    }
}