using QLHD.Data.Models;
using QLHD.Web.Models;

namespace QLHD.Web.infrastructure.Extensions
{
    public static class EntityExtensions
    {
        public static void Updatedmhuongdan(this dmhuongdan dmhuongdan, dmhuongdanViewModel dmhuongdanViewModel)
        {
            dmhuongdan.mahd = dmhuongdanViewModel.mahd;

            dmhuongdan.tenhd = dmhuongdanViewModel.tenhd;
            dmhuongdan.tendn = dmhuongdanViewModel.tendn;
            dmhuongdan.matkhau = dmhuongdanViewModel.matkhau;
            dmhuongdan.quantri = dmhuongdanViewModel.quantri;
            dmhuongdan.hopdong = dmhuongdanViewModel.hopdong;

            dmhuongdan.phai = dmhuongdanViewModel.phai;
            dmhuongdan.ngaysinh = dmhuongdanViewModel.ngaysinh;
            dmhuongdan.noisinh = dmhuongdanViewModel.noisinh;
            dmhuongdan.socmnd = dmhuongdanViewModel.socmnd;
            dmhuongdan.ngaycmnd = dmhuongdanViewModel.ngaycmnd;

            dmhuongdan.noicapcmnd = dmhuongdanViewModel.noicapcmnd;
            dmhuongdan.dienthoaidd = dmhuongdanViewModel.dienthoaidd;
            dmhuongdan.dienthoainha = dmhuongdanViewModel.dienthoainha;
            dmhuongdan.email = dmhuongdanViewModel.email;

            dmhuongdan.passmail = dmhuongdanViewModel.passmail;
            dmhuongdan.diachithuongtru = dmhuongdanViewModel.diachithuongtru;
            dmhuongdan.diachitamtru = dmhuongdanViewModel.diachitamtru;
            dmhuongdan.honnhan = dmhuongdanViewModel.honnhan;
            dmhuongdan.chucdanh = dmhuongdanViewModel.chucdanh;
            dmhuongdan.kinhnghiem = dmhuongdanViewModel.kinhnghiem;
            dmhuongdan.sothehdv = dmhuongdanViewModel.sothehdv;

            dmhuongdan.hanthehdv = dmhuongdanViewModel.hanthehdv;
            dmhuongdan.hochieu = dmhuongdanViewModel.hochieu;
            dmhuongdan.hieuluchochieu = dmhuongdanViewModel.hieuluchochieu;
            dmhuongdan.hanvisa = dmhuongdanViewModel.hanvisa;

            dmhuongdan.ghichuvisa = dmhuongdanViewModel.ghichuvisa;
            dmhuongdan.ngoaingu = dmhuongdanViewModel.ngoaingu;
            dmhuongdan.chinhanh = dmhuongdanViewModel.chinhanh;
            dmhuongdan.trinhdo = dmhuongdanViewModel.trinhdo;

            dmhuongdan.truong1 = dmhuongdanViewModel.truong1;
            dmhuongdan.he1 = dmhuongdanViewModel.he1;
            dmhuongdan.nganh1 = dmhuongdanViewModel.nganh1;
            dmhuongdan.nam1 = dmhuongdanViewModel.nam1;

            dmhuongdan.truong2 = dmhuongdanViewModel.truong2;
            dmhuongdan.he2 = dmhuongdanViewModel.he2;
            dmhuongdan.nganh2 = dmhuongdanViewModel.nganh2;
            dmhuongdan.nam2 = dmhuongdanViewModel.nam2;

            dmhuongdan.tenthannhan = dmhuongdanViewModel.tenthannhan;

            dmhuongdan.quanhe = dmhuongdanViewModel.quanhe;

            dmhuongdan.dtquanhe = dmhuongdanViewModel.dtquanhe;

            dmhuongdan.lylich = dmhuongdanViewModel.lylich;

            dmhuongdan.Status = dmhuongdanViewModel.Status;
        }

        public static void Updatephep(this phep phep, phepViewModel phepViewModel)
        {
            phep.Id = phepViewModel.Id;

            phep.mahd = phepViewModel.mahd;
            phep.tungay = phepViewModel.tungay;
            phep.denngay = phepViewModel.denngay;
            phep.lydo = phepViewModel.lydo;
        }

        public static void Updatequyettoandoan(this quyettoandoan quyettoandoan, quyettoandoanViewModel quyettoandoanViewModel)
        {
            quyettoandoan.Id = quyettoandoanViewModel.Id;
            quyettoandoan.CodeDoan = quyettoandoanViewModel.CodeDoan;
            quyettoandoan.mahd = quyettoandoanViewModel.mahd;
            quyettoandoan.ngaytamung = quyettoandoanViewModel.ngaytamung;
            quyettoandoan.phieutamung = quyettoandoanViewModel.phieutamung;
            quyettoandoan.lydo = quyettoandoanViewModel.lydo;
            quyettoandoan.sotien = quyettoandoanViewModel.sotien;
            quyettoandoan.loaitien = quyettoandoanViewModel.loaitien;
            quyettoandoan.tigia = quyettoandoanViewModel.tigia;
            quyettoandoan.tienvnd = quyettoandoanViewModel.tienvnd;
            quyettoandoan.phieutamung = quyettoandoanViewModel.phieutamung;
            quyettoandoan.ngayhoanung = quyettoandoanViewModel.ngayhoanung;
        }

        public static void Updatetamung(this tamung tamung, tamungViewModel tamungViewModel)
        {
            tamung.Id = tamungViewModel.Id;
            tamung.ngaytamung = tamungViewModel.ngaytamung;
            tamung.mahd = tamungViewModel.mahd;
            tamung.codeDoan = tamungViewModel.codeDoan;
            tamung.lydo = tamungViewModel.lydo;
            tamung.sotien = tamungViewModel.sotien;
            tamung.loaitien = tamungViewModel.loaitien;
            tamung.ngayhoanung = tamungViewModel.ngayhoanung;
            tamung.sotienhoanung = tamungViewModel.sotienhoanung;
            tamung.chitiet = tamungViewModel.chitiet;
        }
    }
}