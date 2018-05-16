using LibraryManagement.DbManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.DbManager.Controller
{
    interface IDocGiaController
    {
        bool Add(string Msv, int expireYear,string password);
        bool Edit(string id,string newpassword);
        bool Remove(string id);
        DocGia GetByID(string id);
        DocGia GetByMsv(string Msv);
        List<DocGia> GetAll();
        List<DocGia> SearchByID(string searchStr);
        List<DocGia> SearchByMSV(string searchStr);
        List<DocGia> SearchByName(string name);
        List<string> SearchByID_string(string searchStr);
    }
}
