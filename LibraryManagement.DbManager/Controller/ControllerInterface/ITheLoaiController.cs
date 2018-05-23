using LibraryManagement.DbManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.DbManager.Controller.ControllerInterface
{
    interface ITheLoaiController
    {
        bool Add(string name);
        bool Edit(int id, string name);
        bool Remove(int id);
        bool CheckName(string tentheoai);
        int FindIdByName(string name);
        TheLoai GetById(int id);
        List<TheLoai> GetAll();
        List<string> GetAllByName();
        List<object> GetListNumberOfBooks();
    }
}
