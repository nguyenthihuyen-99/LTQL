using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LTQL_quanlythuvien.Models
{
    [Table("Muons")]
    public class Muon
    {
        [Key]
        public string Mamuon { get; set; }
        public string Madocgia { get; set; }
        public string Masach { get; set; }
        public string MaNV { get; set; }
        public string Ngaymuon { get; set; }
        public string Hanphaitra { get; set; }
        public string Ghichu { get; set; }
        public virtual Docgia Docgias { get; set; }
        public virtual Sach Sachs { get; set; }
        public virtual Nhanvien Nhanviens { get; set; }
        
        

    }
}