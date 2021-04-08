using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LTQL_quanlythuvien.Models
{
    [Table("Theloais")]
    public class Theloai
    {
        [Key]
        public string Matheloai { get; set; }
        public string Tentheloai { get; set; }
        public string Ghichu { get; set; }
        public virtual ICollection<Sach> Sachs { get; set; }
    }
}