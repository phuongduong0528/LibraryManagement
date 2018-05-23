using LibraryManagement.DbManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.DbManager.Controller
{
    public class DocGiaController : IDocGiaController
    {
        private LibraryDbContext _libraryDbContext;

        public DocGiaController()
        {
            _libraryDbContext = new LibraryDbContext();
        }

        public bool Add(string Msv,int expireYear,string password)
        {
            try
            {
                DocGia docGia = new DocGia();
                docGia.ID = "DG" + _libraryDbContext.DocGias.Count().ToString("D5");
                docGia.MaSV = Msv;
                docGia.NgayDangKi = DateTime.Now.Date;
                docGia.HanTheThuVien = new DateTime(expireYear, 12, 31);
                docGia.TrangThai = "OK";
                docGia.MatKhau = Utilities.CalculateHash(password+docGia.ID);
                _libraryDbContext.DocGias.Add(docGia);
                _libraryDbContext.SaveChanges();
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        public bool Edit(string id, string newpassword)
        {
            DocGia docGia = GetByID(id);
            if (docGia != null)
            {
                docGia.MatKhau = Utilities.CalculateHash(newpassword + docGia.ID);
                _libraryDbContext.Entry(docGia).State = System.Data.Entity.EntityState.Modified;
                _libraryDbContext.SaveChanges();
                return true;
            }
            return false;
        }

        public List<DocGia> GetAll()
        {
            return _libraryDbContext.DocGias.ToList();
        }

        public List<DocGia> GetByRegisterDate(DateTime date1, DateTime date2)
        {
            if (date1 > date2)
            {
                return _libraryDbContext.DocGias.Where(dg => dg.NgayDangKi <= date1 && dg.NgayDangKi >= date2).ToList();
            }

            if (date1 < date2)
            {
                return _libraryDbContext.DocGias.Where(dg => dg.NgayDangKi >= date1 && dg.NgayDangKi <= date2).ToList();
            }

            if (date1.Date.Equals(date2.Date))
            {
                return _libraryDbContext.DocGias.Where(dg => dg.NgayDangKi.Date.Equals(date1.Date)).ToList();
            }

            return null;
        }

        public DocGia GetByID(string id)
        {
            return _libraryDbContext.DocGias.SingleOrDefault(dg => dg.ID.Equals(id));
        }

        public DocGia GetByMsv(string Msv)
        {
            return _libraryDbContext.DocGias.SingleOrDefault(dg => dg.SinhVien.MaSV.Equals(Msv));
        }

        public List<DocGia> SearchByName(string name)
        {
            if (!string.IsNullOrEmpty(name))
            {
                return _libraryDbContext.DocGias.Where(dg => dg.SinhVien.HoTen.Contains(name)).ToList();
            }
            return GetAll();
        }

        public List<string> SearchByID_string(string searchStr)
        {
            return _libraryDbContext.DocGias
                .Where(dg => dg.ID.Contains(searchStr))
                .Select(dg => dg.ID)
                .Take(10)
                .ToList();
        }

        public int SoLuotMuon(string id)
        {
            return _libraryDbContext.DongPhieuMuons.Count(dpm => dpm.PhieuMuon.IDDocGia.Equals(id));
        }

        public List<object> BookedTimesPerReader()
        {
            List<object> resultsList = new List<object>();
            foreach (DocGia dg in GetAll().OrderByDescending(a=>a.PhieuMuons.Count))
            {
                int count = _libraryDbContext.PhieuMuons.Count(pm => pm.IDDocGia.Equals(dg.ID));
                int count2 = _libraryDbContext.DongPhieuMuons.Count(dpm => dpm.PhieuMuon.IDDocGia.Equals(dg.ID)); 
                resultsList.Add(new{dg.ID,dg.SinhVien.HoTen,count,count2});
            }

            return resultsList;
        }

        public List<DocGia> SearchByID(string searchStr)
        {
            return _libraryDbContext.DocGias.Where(dg => dg.ID.Contains(searchStr)).ToList();
        }

        public List<DocGia> SearchByMSV(string searchStr)
        {
            return _libraryDbContext.DocGias.Where(dg => dg.MaSV.Contains(searchStr)).ToList();
        }

        public bool Remove(string id)
        {
            try
            {
                DocGia dg = GetByID(id);
                _libraryDbContext.DocGias.Remove(dg);
                _libraryDbContext.SaveChanges();
                return true;
            }
            catch(Exception e)
            {
                return false;
            }
        }
    }
}
