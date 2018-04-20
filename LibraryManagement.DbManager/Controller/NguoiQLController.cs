using LibraryManagement.DbManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.DbManager.Controller
{
    class NguoiQLController : INguoiQLController
    {
        private LibraryDbContext _libraryDbContext;
        public NguoiQLController()
        {
            _libraryDbContext = new LibraryDbContext();
        }

        public bool ChangePassword(string id, string newpassword)
        {
            NguoiQL nguoiQL = _libraryDbContext.NguoiQLs.SingleOrDefault(nql => nql.ID.Equals(id));
            if(nguoiQL != null)
            {
                nguoiQL.MatKhau = Utilities.CalculateHash(newpassword+nguoiQL.ID);
                _libraryDbContext.Entry(nguoiQL).State = System.Data.Entity.EntityState.Modified;
                _libraryDbContext.SaveChanges();
                return true;
            }
            return false;
        }

        public bool ChangeRole(string id, bool role)
        {
            NguoiQL nguoiQL = _libraryDbContext.NguoiQLs.SingleOrDefault(nql => nql.ID.Equals(id));
            if (nguoiQL != null)
            {
                switch (role)
                {
                    case true:
                        nguoiQL.QuyenHan = "Admin";
                        break;
                    default:
                        nguoiQL.QuyenHan = "ThuThu";
                        break;
                }
                _libraryDbContext.Entry(nguoiQL).State = System.Data.Entity.EntityState.Modified;
                _libraryDbContext.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
