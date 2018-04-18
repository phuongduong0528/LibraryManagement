using LibraryManagement.DbManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.DbManager.Controller
{
    public class LoginController : ILoginController
    {
        private LibraryDbContext _libraryDbContext;

        public LoginController()
        {
            _libraryDbContext = new LibraryDbContext();
        }

        public Task<int> AuthDocGia(string id, string passwordHash)
        {
            DocGia docGia = _libraryDbContext.DocGias.SingleOrDefault(dg => dg.ID.Equals(id) && dg.MatKhau.Equals(passwordHash));
            if (docGia == null)
                return Task.FromResult(0);
            return Task.FromResult(1);
        }

        public Task<int> AuthNguoiQL(string id, string passwordHash)
        {
            NguoiQL nguoiQL = _libraryDbContext.NguoiQLs.SingleOrDefault(nql => nql.ID.Equals(id) 
                                                                        && nql.MatKhau.Equals(passwordHash)
                                                                        && nql.QuyenHan.Equals("Admin"));
            if (nguoiQL == null)
                return Task.FromResult(0);
            return Task.FromResult(1);
        }

        public Task<int> AuthThuThu(string id, string passwordHash)
        {
            NguoiQL nguoiQL = _libraryDbContext.NguoiQLs.SingleOrDefault(nql => nql.ID.Equals(id)
                                                                        && nql.MatKhau.Equals(passwordHash)
                                                                        && nql.QuyenHan.Equals("ThuThu"));
            if (nguoiQL == null)
                return Task.FromResult(0);
            return Task.FromResult(1);
        }
    }
}
