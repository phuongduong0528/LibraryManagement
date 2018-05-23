using LibraryManagement.DbManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.DbManager.Controller
{
    interface ITacGiaController
    {
        void Add(string name);
        void Add(string name, string description);
        bool CheckExists(string name);
        bool Edit(int id, string description);
        bool Remove(int id);
        int FindIdByName(string name);
        int GetIdByName(string name);
        TacGia GetById(int id);
        List<TacGia> GetAll();
        List<string> SearchByName(string name);
        List<object> GetListNumberOfBooks();
    }
}
