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
            catch(Exception ex)
            {
                return false;
            }
        }

        public bool Edit(DauSach dauSach)
        {
            throw new NotImplementedException();
        }

        public List<DauSach> GetAll()
        {
            return _libraryDbContext.DauSaches.ToList();
        }

        public List<DauSach> GetByFilter(string ten, string theLoai, string tacGia)
        {
            List<DauSach> dauSaches = GetAll();
            if (!string.IsNullOrEmpty(ten))
            {
                dauSaches = _libraryDbContext.DauSaches.Where(ds => ds.TenSach.Contains(ten)).ToList();
            }
            if (!string.IsNullOrEmpty(ten))
            {
                dauSaches = _libraryDbContext.DauSaches.Where(ds => ds.TheLoai.TenTheLoai.Contains(theLoai)).ToList();
            }
            if (!string.IsNullOrEmpty(ten))
            {
                dauSaches = _libraryDbContext.DauSaches.Where(ds => ds.TacGia.TenTacGia.Contains(tacGia)).ToList();
            }
            return dauSaches;
        }

        public List<string> GetTheLoai()
        {
            List<string> theLoais = new List<string>();
            foreach(TheLoai tl in _libraryDbContext.TheLoais)
            {
                theLoais.Add(tl.TenTheLoai);
            }
            return theLoais;
        }
    }
}
