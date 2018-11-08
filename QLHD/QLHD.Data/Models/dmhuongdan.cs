namespace QLHD.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("dmhuongdan")]
    public partial class dmhuongdan
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public dmhuongdan()
        {
            pheps = new HashSet<phep>();
            quyettoandoans = new HashSet<quyettoandoan>();
            tamungs = new HashSet<tamung>();
        }

        [Key]
        [StringLength(4)]
        public string mahd { get; set; }

        [StringLength(50)]
        public string tenhd { get; set; }

        [StringLength(30)]
        public string tendn { get; set; }

        public string matkhau { get; set; }

        public bool? quantri { get; set; }

        [StringLength(50)]
        public string hopdong { get; set; }

        public bool? phai { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ngaysinh { get; set; }

        [StringLength(50)]
        public string noisinh { get; set; }

        [StringLength(20)]
        public string socmnd { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ngaycmnd { get; set; }

        [StringLength(50)]
        public string noicapcmnd { get; set; }

        [StringLength(50)]
        public string dienthoaidd { get; set; }

        [StringLength(50)]
        public string dienthoainha { get; set; }

        [StringLength(50)]
        public string email { get; set; }

        [StringLength(100)]
        public string passmail { get; set; }

        [StringLength(100)]
        public string diachithuongtru { get; set; }

        [StringLength(100)]
        public string diachitamtru { get; set; }

        public bool? honnhan { get; set; }

        [StringLength(50)]
        public string chucdanh { get; set; }

        [StringLength(10)]
        public string kinhnghiem { get; set; }

        [StringLength(50)]
        public string sothehdv { get; set; }

        [Column(TypeName = "date")]
        public DateTime? hanthehdv { get; set; }

        [StringLength(30)]
        public string hochieu { get; set; }

        [Column(TypeName = "date")]
        public DateTime? hieuluchochieu { get; set; }

        [Column(TypeName = "date")]
        public DateTime? hanvisa { get; set; }

        [StringLength(200)]
        public string ghichuvisa { get; set; }

        [StringLength(50)]
        public string ngoaingu { get; set; }

        [StringLength(4)]
        public string chinhanh { get; set; }

        [StringLength(50)]
        public string trinhdo { get; set; }

        [StringLength(50)]
        public string truong1 { get; set; }

        [StringLength(50)]
        public string he1 { get; set; }

        [StringLength(50)]
        public string nganh1 { get; set; }

        [StringLength(10)]
        public string nam1 { get; set; }

        [StringLength(50)]
        public string truong2 { get; set; }

        [StringLength(50)]
        public string he2 { get; set; }

        [StringLength(50)]
        public string nganh2 { get; set; }

        [StringLength(10)]
        public string nam2 { get; set; }

        [StringLength(50)]
        public string tenthannhan { get; set; }

        [StringLength(50)]
        public string quanhe { get; set; }

        [StringLength(20)]
        public string dtquanhe { get; set; }

        public string lylich { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<phep> pheps { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<quyettoandoan> quyettoandoans { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tamung> tamungs { get; set; }
    }
}
