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

        public bool CheckDuplicateBooks(string idPhieuMuon, string idQuyenSach)
        {
            return _libraryDbContext.DongPhieuMuons.Where(dpm => dpm.IDPhieuMuon.Equals(idPhieuMuon))
            .Any(dpm2 => dpm2.IDQuyenSach.Equals(idQuyenSach));
        }

        public bool Edit(int idPhieuMuon,int iddongphieu,DateTime ngayTra, string tinhTrang, string NoiDung, int tienPhat)
        {
            DongPhieuMuon dongPhieuMuon = _libraryDbContext.DongPhieuMuons.SingleOrDefault(dpm => dpm.IDPhieuMuon == idPhieuMuon
            && dpm.ID == iddongphieu);
            if(dongPhieuMuon != null)
            {
                dongPhieuMuon.NgayTraSach = ngayTra;
                dongPhieuMuon.TinhTrangSachTra = tinhTrang;
                dongPhieuMuon.NoiDungPhat = NoiDung;
                dongPhieuMuon.TienPhat = tienPhat;

                _quyenSachController.Edit(dongPhieuMuon.IDQuyenSach, tinhTrang, NoiDung);
                _libraryDbContext.Entry(dongPhieuMuon).State = System.Data.Entity.EntityState.Modified;
                _libraryDbContext.SaveChanges();
                return true;
            }
            return false;
        }

        public List<DongPhieuMuon> GetListByDocGia(string idDocGia)
        {
            return _libraryDbContext
                .DongPhieuMuons
                .Where(dpm => dpm.PhieuMuon.DocGia.ID.Equals(idDocGia))
                .ToList();
        }

        public List<DongPhieuMuon> GetListByMaSinhVien(string msv)
        {
            return _libraryDbContext.DongPhieuMuons.Where(dpm => dpm.PhieuMuon.DocGia.SinhVien.MaSV.Equals(msv)).ToList();
        }

        public List<DongPhieuMuon> GetListByPhieuMuon(int idPhieuMuon)
        {
            return _libraryDbContext.DongPhieuMuons.Where(dpm => dpm.IDPhieuMuon == idPhieuMuon).ToList();
        }

        public List<DongPhieuMuon> GetListCurrentlyBookedBooks(string idDocGia)
        {
            return _libraryDbContext
                .DongPhieuMuons
                .Where(dpm => dpm.PhieuMuon.DocGia.ID.Equals(idDocGia) && dpm.NgayTraSach.Value == null)
                .ToList();
        }

        public bool Add(int idPhieuMuon, List<string> idQuyenSachs)
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

        public bool ResetMoney(int iddongphieu)
        {
            DongPhieuMuon dongPhieuMuon = _libraryDbContext.DongPhieuMuons.SingleOrDefault(dpm => dpm.IDPhieuMuon == iddongphieu
            && dpm.ID == iddongphieu);
            if (dongPhieuMuon != null)
            {
                dongPhieuMuon.TienPhat = 0;
                _libraryDbContext.Entry(dongPhieuMuon).State = System.Data.Entity.EntityState.Modified;
                _libraryDbContext.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
