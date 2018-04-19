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
        bool AddNew(string Msv, int expireYear,string password);
        bool ChangePassword(string id,string newpassword);
    }
}
