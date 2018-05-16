using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagement.DbManager.Models;

namespace LibraryManagement.DbManager.Controller
{
    public class SinhVienController : ISinhVienController
    {
        LibraryDbContext _libraryDbContext;
        public SinhVienController()
        {
            _libraryDbContext = new LibraryDbContext();
        }

        public bool Add(SinhVien sv)
        {
            try
            {
                _libraryDbContext.SinhViens.Add(sv);
                _libraryDbContext.SaveChanges();
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }

        }

        public bool Edit(SinhVien sv)
        {
            try
            {
                SinhVien sinhVien = _libraryDbContext.SinhViens.SingleOrDefault(sv1 => sv1.MaSV.Equals(sv.MaSV));
                sinhVien.HoTen = sv.HoTen;
                sinhVien.NgaySinh = sv.NgaySinh;
                sinhVien.GioiTinh = sv.GioiTinh;
                sinhVien.DiaChi = sv.DiaChi;
                sinhVien.SoDT = sv.SoDT;
                _libraryDbContext.Entry(sinhVien).State = System.Data.Entity.EntityState.Modified;
                _libraryDbContext.SaveChanges();
                return true;
            }
            catch(Exception e)
            {
                return false;
            }
        }

        public bool CheckMSV(string msv)
        {
            return _libraryDbContext.SinhViens.Any(sv => sv.MaSV.Equals(msv));
        }

        public bool Remove(string msv, bool delForeignKey)
        {
            try
            {
                SinhVien sinhVien = _libraryDbContext.SinhViens.SingleOrDefault(sv => sv.MaSV.Equals(msv));
                _libraryDbContext.SinhViens.Remove(sinhVien);
                if (delForeignKey)
                {
                    IQueryable<DocGia> docGias = _libraryDbContext.DocGias.Where(dg => dg.MaSV.Equals(msv));
                    _libraryDbContext.DocGias.RemoveRange(docGias);
                }
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
