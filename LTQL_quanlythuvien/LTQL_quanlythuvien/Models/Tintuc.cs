using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LTQL_quanlythuvien.Models
{
    [Table("Tintucs")]
    public class Tintuc
    {
        [Key]
        public string TintucID { get; set; }
        public string Tentacgia { get; set; }
        [AllowHtml]
        public string Noidung { get; set; }
    }
}