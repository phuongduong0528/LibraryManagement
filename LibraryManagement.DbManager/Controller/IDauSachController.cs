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
        bool AddNew(DauSach dauSach);
        bool Edit(DauSach dauSach);
    }
}
