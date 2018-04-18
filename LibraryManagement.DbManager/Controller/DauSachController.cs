using LibraryManagement.DbManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.DbManager.Controller
{
    public class DauSachController : IDauSachController
    {
        private LibraryDbContext _libraryDbContext;

        public DauSachController()
        {
            _libraryDbContext = new LibraryDbContext();
        }

        public bool AddNew(DauSach dauSach)
        {
            try
            {
                dauSach.ID = _libraryDbContext.DauSaches.Count() + 1;
                _libraryDbContext.DauSaches.Add(dauSach);
                _libraryDbContext.SaveChanges();
                QuyenSachController quyenSachController = new QuyenSachController();
                quyenSachController.AddBook(dauSach.SoLuong, dauSach.ID);
                return true;
            }
            catch(Exception e)
            {
                return false;
            }
        }

        public bool Edit(DauSach dauSach)
        {
            throw new NotImplementedException();
        }
    }
}
