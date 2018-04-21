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
        void AddBook(int count, int idDauSach);
        bool EditStatus(string id, string status, string description);
        QuyenSach GetById(string id);
        List<QuyenSach> GetAll();
        List<QuyenSach> GetByStatus(string status);
        List<QuyenSach> GetBorrowedBooks();
    }
}
