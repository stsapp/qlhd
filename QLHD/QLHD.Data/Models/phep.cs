namespace QLHD.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("phep")]
    public partial class phep
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal Id { get; set; }

        [Required]
        [StringLength(4)]
        public string mahd { get; set; }

        [Column(TypeName = "date")]
        public DateTime? tungay { get; set; }

        [Column(TypeName = "date")]
        public DateTime? denngay { get; set; }

        [StringLength(100)]
        public string lydo { get; set; }

        public virtual dmhuongdan dmhuongdan { get; set; }
    }
}
