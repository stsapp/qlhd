using AutoMapper;
using QLHD.Data.Models;
using QLHD.Web.Models;

namespace QLHD.Web.Mappings
{
    public class AutoMapperConfiguration
    {
        public static void Configuration()
        {
            Mapper.CreateMap<dmhuongdan, dmhuongdanViewModel>();
            Mapper.CreateMap<phep, phepViewModel>();
            Mapper.CreateMap<quyettoandoan, quyettoandoanViewModel>();
            Mapper.CreateMap<tamung, tamungViewModel>();
        }
    }
}