namespace btapvidu.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tacgia")]
    public partial class tacgia
    {
        [Key]
        [StringLength(10)]
        public string Matacgia { get; set; }

        [StringLength(10)]
        public string Tentacgia { get; set; }
    }
}
