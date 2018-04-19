using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagement.DbManager.Models;

namespace LibraryManagement.DbManager.Controller
{
    public class SinhVienController : ISinhVienController
    {
        LibraryDbContext _libraryDbContext;
        public SinhVienController()
        {
            _libraryDbContext = new LibraryDbContext();
        }

        public bool AddNew(SinhVien sv)
        {
            try
            {
                _libraryDbContext.SinhViens.Add(sv);
                _libraryDbContext.SaveChanges();
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }

        }

        public bool Edit(SinhVien sv)
        {
            throw new NotImplementedException();
        }

        public bool Validate(string msv)
        {
            return _libraryDbContext.SinhViens.Any(sv => sv.MaSV.Equals(msv));
        }
    }
}
