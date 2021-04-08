using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LTQL_quanlythuvien.Models
{
    [Table("NhaXuatBans")]
    public class NhaXuatBan
    {
        [Key]
        public string MaNXB { get; set; }
        public string TenNXB { get; set; }
        public string Ghichu { get; set; }
        public virtual ICollection<Sach> Saches { get; set; }

    }
}