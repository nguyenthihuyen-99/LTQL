using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LTQL_quanlythuvien.Models
{
    [Table("ChitietMuons")]
    public class ChiTietMuon
    {
        [Key]
        public string MaCTmuon { get; set; }
        public string Mamuon { get; set; }
        public DateTime Ngaytra { get; set; }
        public int Songayquahan { get; set; }
        public int Tienphat { get; set; }
        public string Ghichu { get; set; }
        public virtual Muon Muons { get; set; }
    }
}