using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LTQL_quanlythuvien.Models
{
    [Table("students")]
    public class student : person
    {
        public string tentruong { get; set; }
    }
}