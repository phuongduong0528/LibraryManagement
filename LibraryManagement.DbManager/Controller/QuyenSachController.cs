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

        public void Add(int numberOfBooks, int idDauSach)
        {
            QuyenSach quyenSach;
            int count = 0;
            string id = $"{idDauSach}-";
            for(int i = 0; i < numberOfBooks; i++)
            {
                count++;
                quyenSach = new QuyenSach
                {
                    ID = id + count.ToString("D4"),
                    IDDauSach = idDauSach,
                    TinhTrang = "OK",
                    MoTa = "none"
                };
                _libraryDbContext.QuyenSaches.Add(quyenSach);
                _libraryDbContext.SaveChanges();
            }
        }

        public bool Edit(string id, string status, string description)
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
            List<QuyenSach> availablebooks = new List<QuyenSach>();
            foreach(QuyenSach quyensach in _libraryDbContext.QuyenSaches.Where(qs=>qs.IDDauSach == idDauSach))
            {
                if (!IsBorrowed(quyensach.ID))
                {
                    availablebooks.Add(quyensach);
                }
            }
            return availablebooks.Take(soLuong).ToList();
        }

        public List<QuyenSach> GetAvailable(int idDauSach)
        {
            List<QuyenSach> availablebooks = new List<QuyenSach>();
            foreach (QuyenSach quyensach in _libraryDbContext.QuyenSaches.Where(qs => qs.IDDauSach == idDauSach))
            {
                if (!IsBorrowed(quyensach.ID))
                {
                    availablebooks.Add(quyensach);
                }
            }
            return availablebooks;
        }

        public int GetAvailableBooksCount(int idDauSach)
        {
            return GetAvailable(idDauSach).Count;
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

        public bool IsBorrowed(string id)
        {
            return GetBorrowedBooks().Any(b => b.ID.Equals(id));
        }

        public bool Remove(string id)
        {
            try
            {
                QuyenSach qs = GetById(id);
                _libraryDbContext.QuyenSaches.Remove(qs);
                _libraryDbContext.SaveChanges();
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        public bool RemoveRange(List<QuyenSach> quyenSaches)
        {
            try
            {
                _libraryDbContext.QuyenSaches.RemoveRange(quyenSaches);
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
