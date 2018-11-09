namespace QLHD.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Error")]
    public partial class Error
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        public string Message { get; set; }

        public string StackTrace { get; set; }

        public DateTime? CreatedDate { get; set; }
    }
}
