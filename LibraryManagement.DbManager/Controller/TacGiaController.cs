using LibraryManagement.DbManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.DbManager.Controller
{
    class TacGiaController : ITacGiaController
    {
        private LibraryDbContext _libraryDbContext;
        public TacGiaController()
        {
            _libraryDbContext = new LibraryDbContext();
        }

        public void AddNew(string name)
        {
            TacGia tacGia = new TacGia();
            if(_libraryDbContext.TacGias.Count() == 0)
            {
                tacGia.ID = 1;
            }
            else
            {
                tacGia.ID = _libraryDbContext.TacGias.Max(tg => tg.ID) + 1;
            }
            tacGia.TenTacGia = name;
            tacGia.ThongTin = "";
            _libraryDbContext.TacGias.Add(tacGia);
            _libraryDbContext.SaveChanges();
        }

        public bool CheckExists(string name)
        {
            return _libraryDbContext.TacGias.Any(tg => tg.TenTacGia.Equals(name));
        }
    }
}
