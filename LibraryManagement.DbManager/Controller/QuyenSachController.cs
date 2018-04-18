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
            string id = $"{idDauSach} - ";
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
    }
}
