using LibraryManagement.DbManager.Dto;
using LibraryManagement.DbManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.DbManager.Adaptor
{
    public class DauSachAdaptor
    {
        public static DauSachDto GetDauSAchDto(DauSach dauSach)
        {
            DauSachDto dauSachDto = new DauSachDto();
            dauSachDto.Id = dauSach.ID;
            dauSachDto.TenSach = dauSach.TenSach;
            dauSachDto.TacGia = dauSach.TacGia.TenTacGia;
            dauSachDto.NhaXuatBan = dauSach.NhaXuatBan.TenNhaXuatBan;
            dauSachDto.NamXuatBan = dauSach.NamXuatBan;
            dauSachDto.TheLoai = dauSach.TheLoai.TenTheLoai;
            dauSachDto.KeSach = dauSach.KeSach;
            return dauSachDto;
        }

        public static List<DauSachDto> GetListDauSachDto(List<DauSach> dauSaches)
        {
            List<DauSachDto> dauSachDtos = new List<DauSachDto>();
            foreach(DauSach ds in dauSaches)
            {
                dauSachDtos.Add(GetDauSAchDto(ds));
            }
            return dauSachDtos;
        }
    }
}
