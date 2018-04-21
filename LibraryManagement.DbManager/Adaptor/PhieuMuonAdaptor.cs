using LibraryManagement.DbManager.Dto;
using LibraryManagement.DbManager.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.DbManager.Adaptor
{
    public class PhieuMuonAdaptor
    {
        public static PhieuMuonDto GetPhieuMuonDto(PhieuMuon phieuMuon)
        {
            PhieuMuonDto phieuMuonDto = new PhieuMuonDto();
            phieuMuonDto.Id = phieuMuon.ID;
            phieuMuonDto.NguoiQl = phieuMuon.NguoiQL.HoTen;
            phieuMuonDto.NgayMuonSach = phieuMuon.NgayMuonSach.ToString(@"dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            phieuMuonDto.HanTraSach = phieuMuon.HanTraSach.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);
            phieuMuonDto.IdDocGia = phieuMuon.IDDocGia;
            phieuMuonDto.DocGia = phieuMuon.DocGia.SinhVien.HoTen;
            return phieuMuonDto;
        }

        public List<PhieuMuonDto> GetListPhieuMuonDto(List<PhieuMuon> phieuMuons)
        {
            List<PhieuMuonDto> phieuMuonDtos = new List<PhieuMuonDto>();
            foreach (PhieuMuon pm in phieuMuons)
            {
                phieuMuonDtos.Add(GetPhieuMuonDto(pm));
            }
            return phieuMuonDtos;
        }
    }
}
