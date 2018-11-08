namespace QLHD.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tamung")]
    public partial class tamung
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal Id { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ngaytamung { get; set; }

        [Required]
        [StringLength(4)]
        public string mahd { get; set; }

        [StringLength(100)]
        public string codeDoan { get; set; }

        [StringLength(100)]
        public string lydo { get; set; }

        public decimal? sotien { get; set; }

        [StringLength(5)]
        public string loaitien { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ngayhoanung { get; set; }

        public decimal? sotienhoanung { get; set; }

        public byte[] chitiet { get; set; }

        public virtual dmhuongdan dmhuongdan { get; set; }
    }
}
