namespace QLHD.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tourKhach")]
    public partial class tourKhach
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal Id { get; set; }

        [StringLength(20)]
        public string sic { get; set; }

        [StringLength(20)]
        public string sgtCode { get; set; }

        [StringLength(50)]
        public string tenkhach { get; set; }

        [StringLength(100)]
        public string diachi { get; set; }

        [StringLength(30)]
        public string dienthoai { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ngaysinh { get; set; }

        public bool? gioitinh { get; set; }

        [StringLength(20)]
        public string hochieu { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ngaycaphc { get; set; }

        [Column(TypeName = "date")]
        public DateTime? hieuluchc { get; set; }

        [StringLength(100)]
        public string ghichu { get; set; }

        public virtual tour tour { get; set; }
    }
}
