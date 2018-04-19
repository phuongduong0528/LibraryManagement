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

        public bool AddNew(string Msv,int expireYear,string password)
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

        public bool ChangePassword(string id, string newpassword)
        {
            DocGia docGia = _libraryDbContext.DocGias.SingleOrDefault(dg => dg.ID.Equals(id));
            if (docGia != null)
            {
                docGia.MatKhau = Utilities.CalculateHash(newpassword + docGia.ID);
                _libraryDbContext.Entry(docGia).State = System.Data.Entity.EntityState.Modified;
                _libraryDbContext.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
