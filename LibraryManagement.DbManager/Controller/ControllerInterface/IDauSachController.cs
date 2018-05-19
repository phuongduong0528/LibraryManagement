using LibraryManagement.DbManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.DbManager.Controller
{
    interface IDauSachController
    {
        bool Add(DauSach dauSach);
        bool Edit(DauSach dauSach);
        bool Remove(int id, bool delForeignKey);
        DauSach GetById(int id);
        List<DauSach> GetAllDauSach();
        List<DauSach> GetByFilter(string ten,string theLoai, string tacGia);
        List<DauSach> SearchByName(string searchStr);
        List<string> GetTheLoai();
    }
}
