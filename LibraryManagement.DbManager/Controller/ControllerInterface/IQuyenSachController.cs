using LibraryManagement.DbManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.DbManager.Controller
{
    interface IQuyenSachController
    {
        void Add(int count, int idDauSach);
        bool Edit(string id, string status, string description);
        bool Remove(string id);
        bool RemoveRange(List<QuyenSach> quyenSaches);
        bool IsBorrowed(string id);
        QuyenSach GetById(string id);
        List<QuyenSach> GetAll();
        List<QuyenSach> GetByStatus(string status);
        List<QuyenSach> GetBorrowedBooks();
        List<QuyenSach> GetAvailable(int idDauSach, int soLuong);
        List<QuyenSach> GetAvailable(int idDauSach);
        int GetAvailableBooksCount(int idDauSach);
    }
}
