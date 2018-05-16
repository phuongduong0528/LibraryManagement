using LibraryManagement.DbManager.Controller.ControllerInterface;
using LibraryManagement.DbManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.DbManager.Controller
{
    public class PhieuMuonController : IPhieuMuonController
    {
        private LibraryDbContext _libraryDbContext;
        public PhieuMuonController()
        {
            _libraryDbContext = new LibraryDbContext();
        }

        public int Add(string IdNql, string IdDocGia, DateTime HanTra)
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
                return phieuMuon.ID;
            }
            catch(Exception ex)
            {
                return -1;
            }
        }

        public PhieuMuon GetById(int id)
        {
            return _libraryDbContext.PhieuMuons.SingleOrDefault(pm => pm.ID == id);
        }

        public List<int> GetId(string searchStr)
        {
            return _libraryDbContext
                .PhieuMuons
                .Select(pm => pm.ID)
                .Take(20)
                .ToList();
        }
    }
}
