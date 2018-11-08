namespace QLHD.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("loaitour")]
    public partial class loaitour
    {
        public int loaitourId { get; set; }

        [StringLength(70)]
        public string tenloaitour { get; set; }
    }
}
