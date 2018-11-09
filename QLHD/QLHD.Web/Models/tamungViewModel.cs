using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QLHD.Web.Models
{
    public class tamungViewModel
    {
        public decimal Id { get; set; }

        public DateTime? ngaytamung { get; set; }

        public string mahd { get; set; }

        public string codeDoan { get; set; }

        public string lydo { get; set; }

        public decimal? sotien { get; set; }

        public string loaitien { get; set; }

        public DateTime? ngayhoanung { get; set; }

        public decimal? sotienhoanung { get; set; }

        public byte[] chitiet { get; set; }

        public virtual dmhuongdanViewModel dmhuongdan { get; set; }
    }
}