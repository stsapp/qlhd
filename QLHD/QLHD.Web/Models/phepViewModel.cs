using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QLHD.Web.Models
{
    public class phepViewModel
    {
        public decimal Id { get; set; }

        
        public string mahd { get; set; }

        public DateTime? tungay { get; set; }

        public DateTime? denngay { get; set; }

        public string lydo { get; set; }

        public virtual dmhuongdanViewModel dmhuongdan { get; set; }

    }
}