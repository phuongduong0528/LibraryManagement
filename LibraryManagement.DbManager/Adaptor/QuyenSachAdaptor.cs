using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagement.DbManager.Controller;
using LibraryManagement.DbManager.Dto;
using LibraryManagement.DbManager.Models;

namespace LibraryManagement.DbManager.Adaptor
{
    public class QuyenSachAdaptor
    {
        public static QuyenSachDto GetQuyenSachDto(QuyenSach quyenSach)
        {
            QuyenSachDto quyenSachDto = new QuyenSachDto();

            DongPhieuMuonController dongPhieuMuonController = new DongPhieuMuonController();
            List<DongPhieuMuon> bookedBooks = dongPhieuMuonController.GetListCurrentlyBooked();
            DongPhieuMuon dongPhieuMuon = bookedBooks.SingleOrDefault(dpm => dpm.IDQuyenSach.Equals(quyenSach.ID));

            quyenSachDto.Id = quyenSach.ID;
            quyenSachDto.TenSach = quyenSach.DauSach.TenSach;
            quyenSachDto.NgayMuon = dongPhieuMuon.PhieuMuon.NgayMuonSach.ToString("dd/MM/yyyy",CultureInfo.InvariantCulture);
            quyenSachDto.DocGiaMuon = dongPhieuMuon.PhieuMuon.DocGia.SinhVien.HoTen;
            quyenSachDto.IdDocGiaMuon = dongPhieuMuon.PhieuMuon.IDDocGia;

            return quyenSachDto;
        }

        public static List<QuyenSachDto> GetListQuyenSachDto(List<QuyenSach> quyenSaches)
        {
            List<QuyenSachDto> quyenSachDtos = new List<QuyenSachDto>();
            foreach (QuyenSach qs in quyenSaches)
            {
                quyenSachDtos.Add(GetQuyenSachDto(qs));
            }

            return quyenSachDtos;
        }
    }
}
