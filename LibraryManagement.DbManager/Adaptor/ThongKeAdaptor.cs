using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;
using LibraryManagement.DbManager.Controller;
using LibraryManagement.DbManager.Dto;
using LibraryManagement.DbManager.Models;

namespace LibraryManagement.DbManager.Adaptor
{
    public class SachMuonNhieuAdaptor
    {
        public static SachMuonNhieuDto GetSachMuonNhieuDto(DauSach dauSach)
        {
            DauSachController dauSachController = new DauSachController();
            SachMuonNhieuDto sachMuonNhieuDto = new SachMuonNhieuDto();
            sachMuonNhieuDto.IdDauSach = dauSach.ID;
            sachMuonNhieuDto.TenSach = dauSach.TenSach;
            sachMuonNhieuDto.TacGia = dauSach.TacGia.TenTacGia;
            sachMuonNhieuDto.TheLoai = dauSach.TheLoai.TenTheLoai;
            sachMuonNhieuDto.Nxb = dauSach.NhaXuatBan.TenNhaXuatBan;
            sachMuonNhieuDto.SoLuotMuon = dauSachController.GetTotalBorrowed(dauSach.ID);
            return sachMuonNhieuDto;
        }

        public static List<SachMuonNhieuDto> GetListSachMuonNhieuDtos(List<DauSach> dauSaches)
        {
            List<SachMuonNhieuDto> sachMuonNhieuDtos = new List<SachMuonNhieuDto>();
            foreach (DauSach ds in dauSaches)
            {
                sachMuonNhieuDtos.Add(GetSachMuonNhieuDto(ds));
            }

            return sachMuonNhieuDtos.OrderByDescending(smn=>smn.SoLuotMuon).ToList();
        }

    }
}
