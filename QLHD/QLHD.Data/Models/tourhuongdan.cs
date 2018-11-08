namespace QLHD.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tourhuongdan")]
    public partial class tourhuongdan
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal Id { get; set; }

        [StringLength(20)]
        public string sic { get; set; }

        [StringLength(20)]
        public string sgtCode { get; set; }

        [StringLength(4)]
        public string mahd { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ngaytq { get; set; }

        [StringLength(10)]
        public string giobatdau { get; set; }

        [StringLength(10)]
        public string gioketthuc { get; set; }

        [StringLength(100)]
        public string chuongtrinh { get; set; }

        [StringLength(100)]
        public string Ghichu { get; set; }

        public virtual tour tour { get; set; }
    }
}
