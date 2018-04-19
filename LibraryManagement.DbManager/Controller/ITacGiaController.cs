using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.DbManager.Controller
{
    interface ITacGiaController
    {
        void AddNew(string name);
        bool CheckExists(string name);
    }
}
