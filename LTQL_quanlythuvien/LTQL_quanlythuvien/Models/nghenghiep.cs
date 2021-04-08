using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LTQL_quanlythuvien.Models
{
    [Table("nghenghieps")]
    public class nghenghiep : person
    {
        public string congty { get; set; }
    }
}