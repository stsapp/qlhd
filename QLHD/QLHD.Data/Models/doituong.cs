namespace QLHD.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("doituong")]
    public partial class doituong
    {
        [Key]
        [StringLength(2)]
        public string madoituong { get; set; }

        [StringLength(50)]
        public string tendoituong { get; set; }
    }
}
