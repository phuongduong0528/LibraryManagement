using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.DbManager.Controller
{
    interface ILoginController
    {
        Task<int> AuthDocGia(string id, string passwordHash);
        Task<int> AuthNguoiQL(string id, string passwordHash);
        Task<int> AuthThuThu(string id, string passwordHash);
    }
}
