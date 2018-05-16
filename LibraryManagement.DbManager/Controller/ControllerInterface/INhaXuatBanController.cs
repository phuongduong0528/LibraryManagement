using LibraryManagement.DbManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.DbManager.Controller.ControllerInterface
{
    interface INhaXuatBanController
    {
        bool Add(string name);
        bool Edit(int id, string name);
        bool Remove(int id);
        NhaXuatBan GetById(int id);
        List<NhaXuatBan> GetAll();
        List<string> GetAllByName();
        int FindIdByName(string name);
    }
}
