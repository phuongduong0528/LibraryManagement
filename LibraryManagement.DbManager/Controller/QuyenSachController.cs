using LibraryManagement.DbManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.DbManager.Controller
{
    public class QuyenSachController : IQuyenSachController
    {
        LibraryDbContext _libraryDbContext;
        public QuyenSachController()
        {
            _libraryDbContext = new LibraryDbContext();
        }

        public void AddBook(int numberOfBooks, int idDauSach)
        {
            QuyenSach quyenSach;
            int count = 0;
            string id = $"{idDauSach}-";
            for(int i = 0; i < numberOfBooks; i++)
            {
                quyenSach = new QuyenSach();
                count++;
                quyenSach = new QuyenSach();
                quyenSach.ID = id + count.ToString("D4");
                quyenSach.IDDauSach = idDauSach;
                quyenSach.TinhTrang = "OK";
                quyenSach.MoTa = "none";
                _libraryDbContext.QuyenSaches.Add(quyenSach);
                _libraryDbContext.SaveChanges();
            }
        }

        public bool EditStatus(string id, string status, string description)
        {
            QuyenSach quyenSach = _libraryDbContext.QuyenSaches.SingleOrDefault(qs => qs.ID.Equals(id));
            if(quyenSach != null)
            {
                quyenSach.TinhTrang = status;
                quyenSach.MoTa = description;
                _libraryDbContext.Entry(quyenSach).State = System.Data.Entity.EntityState.Modified;
                _libraryDbContext.SaveChanges();
                return true;
            }
            return false;
        }

        public List<QuyenSach> GetAll()
        {
            return _libraryDbContext.QuyenSaches.ToList();
        }

        public List<QuyenSach> GetAvailable(int idDauSach, int soLuong)
        {
            return _libraryDbContext.QuyenSaches.Where(qs => qs.IDDauSach.Equals(idDauSach) 
            && !GetBorrowedBooks().Contains(qs)).ToList();
        }

        public List<QuyenSach> GetBorrowedBooks()
        {
            return _libraryDbContext.DongPhieuMuons
                .Where(dpm => dpm.NgayTraSach.Value == null)
                .Select(dpm => dpm.QuyenSach)
                .ToList();
        }

        public QuyenSach GetById(string id)
        {
            return _libraryDbContext.QuyenSaches.SingleOrDefault(qs => qs.ID.Equals(id));
        }

        public List<QuyenSach> GetByStatus(string status)
        {
            return _libraryDbContext.QuyenSaches.Where(qs => qs.TinhTrang.Equals(status)).ToList();
        }
    }
}
