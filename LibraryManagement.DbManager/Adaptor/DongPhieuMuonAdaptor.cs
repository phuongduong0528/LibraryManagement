using LibraryManagement.DbManager.Dto;
using LibraryManagement.DbManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.DbManager.Adaptor
{
    public class DongPhieuMuonAdaptor
    {
        public static DongPhieuMuonDto GetDongPhieuMuonDto(DongPhieuMuon dongPhieuMuon)
        {
            DongPhieuMuonDto dongPhieuMuonDto = new DongPhieuMuonDto();
            dongPhieuMuonDto.ID = dongPhieuMuon.ID;
            dongPhieuMuonDto.IdPhieuMuon = dongPhieuMuon.IDPhieuMuon.ToString();
            dongPhieuMuonDto.IdSach = dongPhieuMuon.IDQuyenSach;
            dongPhieuMuonDto.TenSach = dongPhieuMuon.QuyenSach.DauSach.TenSach;
            dongPhieuMuonDto.NgayMuon = dongPhieuMuon.PhieuMuon.NgayMuonSach.ToString("dd/MM/yyyy");
            dongPhieuMuonDto.NgayHenTra = dongPhieuMuon.PhieuMuon.HanTraSach.ToString("dd/MM/yyyy");
            if(dongPhieuMuon.NgayTraSach != null)
            {
                dongPhieuMuonDto.NgayTra = dongPhieuMuon.NgayTraSach.Value.ToString("dd/MM/yyyy");
            }
            else
            {
                dongPhieuMuonDto.NgayTra = "";
            }
            dongPhieuMuonDto.TinhTrang = dongPhieuMuon.TinhTrangSachTra;
            return dongPhieuMuonDto;
        }

        public static List<DongPhieuMuonDto> GetListDongPhieuMuonDto(List<DongPhieuMuon> dongPhieuMuons)
        {
            List<DongPhieuMuonDto> dongPhieuMuonDtos = new List<DongPhieuMuonDto>();
            foreach(DongPhieuMuon dongphieu in dongPhieuMuons)
            {
                dongPhieuMuonDtos.Add(GetDongPhieuMuonDto(dongphieu));
            }
            return dongPhieuMuonDtos;
        }
    }
}
