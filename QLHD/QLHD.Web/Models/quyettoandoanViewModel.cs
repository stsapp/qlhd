using System;

namespace QLHD.Web.Models
{
    public class quyettoandoanViewModel
    {
        public decimal Id { get; set; }

        public string CodeDoan { get; set; }

        public string mahd { get; set; }

        public DateTime? ngaytamung { get; set; }

        public string phieutamung { get; set; }

        public string lydo { get; set; }

        public decimal? sotien { get; set; }

        public string loaitien { get; set; }

        public decimal? tigia { get; set; }

        public decimal? tienvnd { get; set; }

        public string phieuhoanung { get; set; }

        public DateTime? ngayhoanung { get; set; }

        public virtual dmhuongdanViewModel dmhuongdan { get; set; }
    }
}