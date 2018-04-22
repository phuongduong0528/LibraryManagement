using LibraryManagement.DbManager.Controller.ControllerInterface;
using LibraryManagement.DbManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.DbManager.Controller
{
    public class DongPhieuMuonController : IDongPhieuMuonController
    {
        private LibraryDbContext _libraryDbContext;
        private QuyenSachController _quyenSachController;
        public DongPhieuMuonController()
        {
            _libraryDbContext = new LibraryDbContext();
            _quyenSachController = new QuyenSachController();
        }

        public bool Check(string idPhieuMuon, string idQuyenSach)
        {
            return _libraryDbContext.DongPhieuMuons.Where(dpm => dpm.IDPhieuMuon.Equals(idPhieuMuon))
            .Any(dpm2 => dpm2.IDQuyenSach.Equals(idQuyenSach));
        }

        public bool EditLine(int idPhieuMuon,string idQuyenSach,DateTime ngayTra, string tinhTrang, string NoiDung, int tienPhat)
        {
            DongPhieuMuon dongPhieuMuon = _libraryDbContext.DongPhieuMuons.SingleOrDefault(dpm => dpm.IDPhieuMuon == idPhieuMuon
            && dpm.IDQuyenSach.Equals(idQuyenSach));
            if(dongPhieuMuon != null)
            {
                dongPhieuMuon.NgayTraSach = ngayTra;
                dongPhieuMuon.TinhTrangSachTra = tinhTrang;
                dongPhieuMuon.NoiDungPhat = NoiDung;
                dongPhieuMuon.TienPhat = tienPhat;
                _libraryDbContext.Entry(dongPhieuMuon).State = System.Data.Entity.EntityState.Modified;
                _libraryDbContext.SaveChanges();
                return true;
            }
            return false;
        }

        public List<DongPhieuMuon> GetByDocGia(string idDocGia)
        {
            return _libraryDbContext.DongPhieuMuons.Where(dpm => dpm.PhieuMuon.DocGia.ID.Equals(idDocGia)).ToList();
        }

        public List<DongPhieuMuon> GetByMaSinhVien(string msv)
        {
            return _libraryDbContext.DongPhieuMuons.Where(dpm => dpm.PhieuMuon.DocGia.SinhVien.MaSV.Equals(msv)).ToList();
        }

        public bool NewLine(int idPhieuMuon, List<string> idQuyenSachs)
        {
            DongPhieuMuon dpm;
            try
            {
                foreach (string idquyensach in idQuyenSachs)
                {
                    dpm = new DongPhieuMuon();
                    dpm.ID = _libraryDbContext.DongPhieuMuons.Count() + 1;
                    if (_quyenSachController.IsBorrowed(idquyensach))
                    {
                        continue;
                    }
                    dpm.IDQuyenSach = idquyensach;
                    dpm.IDPhieuMuon = idPhieuMuon;
                    dpm.TinhTrangSachTra = "";
                    dpm.NoiDungPhat = "";
                    _libraryDbContext.DongPhieuMuons.Add(dpm);
                    _libraryDbContext.SaveChanges();
                }
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }
    }
}
