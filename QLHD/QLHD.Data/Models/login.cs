namespace QLHD.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("login")]
    public partial class login
    {
        [Key]
        [StringLength(50)]
        public string tendn { get; set; }

        public string matkhau { get; set; }

        [StringLength(50)]
        public string hoten { get; set; }

        public bool? quantri { get; set; }

        [StringLength(50)]
        public string email { get; set; }

        [StringLength(100)]
        public string passmail { get; set; }

        [StringLength(4)]
        public string mahd { get; set; }
    }
}
