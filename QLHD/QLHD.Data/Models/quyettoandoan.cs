namespace QLHD.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("quyettoandoan")]
    public partial class quyettoandoan
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal Id { get; set; }

        [StringLength(20)]
        public string CodeDoan { get; set; }

        [StringLength(4)]
        public string mahd { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ngaytamung { get; set; }

        [StringLength(20)]
        public string phieutamung { get; set; }

        [StringLength(150)]
        public string lydo { get; set; }

        public decimal? sotien { get; set; }

        [StringLength(3)]
        public string loaitien { get; set; }

        public decimal? tigia { get; set; }

        public decimal? tienvnd { get; set; }

        [StringLength(20)]
        public string phieuhoanung { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ngayhoanung { get; set; }

        public virtual dmhuongdan dmhuongdan { get; set; }
    }
}
