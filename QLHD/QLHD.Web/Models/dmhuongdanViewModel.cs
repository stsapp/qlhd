using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QLHD.Web.Models
{
    public class dmhuongdanViewModel
    {
        public string mahd { get; set; }

        public string tenhd { get; set; }

        public string tendn { get; set; }

        public string matkhau { get; set; }

        public bool? quantri { get; set; }

        public string hopdong { get; set; }

        public bool? phai { get; set; }

        public DateTime? ngaysinh { get; set; }

        public string noisinh { get; set; }

        public string socmnd { get; set; }

        public DateTime? ngaycmnd { get; set; }

        public string noicapcmnd { get; set; }

        public string dienthoaidd { get; set; }

        public string dienthoainha { get; set; }

        public string email { get; set; }

        public string passmail { get; set; }

        public string diachithuongtru { get; set; }

        public string diachitamtru { get; set; }

        public bool? honnhan { get; set; }

        public string chucdanh { get; set; }

        public string kinhnghiem { get; set; }

        public string sothehdv { get; set; }

        public DateTime? hanthehdv { get; set; }

        public string hochieu { get; set; }

        public DateTime? hieuluchochieu { get; set; }

        public DateTime? hanvisa { get; set; }

        public string ghichuvisa { get; set; }

        public string ngoaingu { get; set; }

        public string chinhanh { get; set; }

        public string trinhdo { get; set; }

        public string truong1 { get; set; }

        public string he1 { get; set; }

        public string nganh1 { get; set; }

        public string nam1 { get; set; }

        public string truong2 { get; set; }

        public string he2 { get; set; }

        public string nganh2 { get; set; }

        public string nam2 { get; set; }

        public string tenthannhan { get; set; }

        public string quanhe { get; set; }

        public string dtquanhe { get; set; }

        public string lylich { get; set; }

        public bool? Status { get; set; }

        public virtual ICollection<phepViewModel> pheps { get; set; }

        public virtual ICollection<quyettoandoanViewModel> quyettoandoans { get; set; }

        public virtual ICollection<tamungViewModel> tamungs { get; set; }
    }
}