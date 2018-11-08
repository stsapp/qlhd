namespace QLHD.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tour")]
    public partial class tour
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tour()
        {
            tourhuongdans = new HashSet<tourhuongdan>();
            tourKhaches = new HashSet<tourKhach>();
        }

        [Key]
        [StringLength(20)]
        public string sic { get; set; }

        [StringLength(20)]
        public string sgtCode { get; set; }

        [StringLength(20)]
        public string codeKhach { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ngay { get; set; }

        [StringLength(50)]
        public string nguoiyeucau { get; set; }

        [StringLength(50)]
        public string tenkh { get; set; }

        public bool? khachle { get; set; }

        [StringLength(70)]
        public string diachikhach { get; set; }

        [StringLength(70)]
        public string dtlienlac { get; set; }

        [StringLength(100)]
        public string lotrinh { get; set; }

        public int? sokhach { get; set; }

        public int? sohdv { get; set; }

        [StringLength(50)]
        public string ngoaingu { get; set; }

        public bool? suottuyen { get; set; }

        [StringLength(100)]
        public string nuocden { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ngaykhoihanh { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ngayketthuc { get; set; }

        public DateTime? ngayhopdoan { get; set; }

        [StringLength(70)]
        public string diadiemhop { get; set; }

        [StringLength(50)]
        public string nvsale { get; set; }

        [StringLength(50)]
        public string nvdieuhanh { get; set; }

        public byte[] ctTour { get; set; }

        public int? loaitourId { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ngayhuy { get; set; }

        [StringLength(100)]
        public string lydohuy { get; set; }

        [StringLength(50)]
        public string nguoinhap { get; set; }

        [StringLength(50)]
        public string nguoihuy { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tourhuongdan> tourhuongdans { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tourKhach> tourKhaches { get; set; }
    }
}
