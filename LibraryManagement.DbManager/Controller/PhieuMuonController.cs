using LibraryManagement.DbManager.Controller.ControllerInterface;
using LibraryManagement.DbManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.DbManager.Controller
{
    class PhieuMuonController : IPhieuMuonController
    {
        private LibraryDbContext _libraryDbContext;
        public PhieuMuonController()
        {
            _libraryDbContext = new LibraryDbContext();
        }

        public bool AddNew(string IdNql, string IdDocGia, DateTime HanTra)
        {
            try
            {
                PhieuMuon phieuMuon = new PhieuMuon();
                phieuMuon.ID = _libraryDbContext.PhieuMuons.Count() + 1;
                phieuMuon.IDNguoiQL = IdNql;
                phieuMuon.IDDocGia = IdDocGia;
                phieuMuon.NgayMuonSach = DateTime.Now;
                phieuMuon.HanTraSach = HanTra;
                _libraryDbContext.PhieuMuons.Add(phieuMuon);
                _libraryDbContext.SaveChanges();
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }
    }
}
