using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LTQL_quanlythuvien.Models
{
    [Table("Sachs")]
    public class Sach
    {
        [Key]
        [StringLength(30)]
        public string Masach { get; set; }
        public string Tensach { get; set; }
        public string Tentacgia { get; set; }
        public string Matacgia { get; set; }
        public string Matheloai { get; set; }
        public int NamXB { get; set; }
        public string MaNXB { get; set; }
        public virtual ICollection<Muon> Muons { get; set; }
        public virtual Tacgia Tacgias { get; set; }
        public virtual Theloai Theloais { get; set; }
        public virtual NhaXuatBan NhaXuatBans { get; set; }
    }
}