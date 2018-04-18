using LibraryManagement.DbManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.DbManager.Controller
{
    interface ISinhVienController
    {
        bool AddNew(SinhVien sv);
        bool Edit(SinhVien sv);
    }
}
