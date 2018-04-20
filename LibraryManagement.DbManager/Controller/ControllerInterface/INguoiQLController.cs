using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.DbManager.Controller
{
    interface INguoiQLController
    {
        bool ChangeRole(string id, bool role);
        bool ChangePassword(string id, string newpassword);
    }
}
