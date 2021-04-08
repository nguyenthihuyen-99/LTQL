using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LTQL_quanlythuvien.Models
{
    [Table("Docgias")]
    public class Docgia
    {
        [Key]
        public string Madocgia { get; set; }
        public string Tendocgia { get; set; }
        public string Mamuon { get; set; }
        public string Ngaysinh { get; set; }
        public string Ghichu { get; set; }
        public virtual ICollection<Muon> Muons { get; set; }
    }
}