namespace btapvidu.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("sach")]
    public partial class sach
    {
        [Key]
        [StringLength(10)]
        public string masach { get; set; }

        [StringLength(10)]
        public string tensach { get; set; }

        [StringLength(10)]
        public string Matacgia { get; set; }
    }
}
