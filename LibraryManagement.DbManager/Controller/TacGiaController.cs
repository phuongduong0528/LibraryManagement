using LibraryManagement.DbManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.DbManager.Controller
{
    public class TacGiaController : ITacGiaController
    {
        private LibraryDbContext _libraryDbContext;
        public TacGiaController()
        {
            _libraryDbContext = new LibraryDbContext();
        }

        public bool Edit(int id, string description)
        {
            TacGia tacGia = _libraryDbContext.TacGias.SingleOrDefault(tg => tg.ID.Equals(id));
            if(tacGia != null)
            {
                tacGia.ThongTin = description;
                _libraryDbContext.Entry(tacGia).State = System.Data.Entity.EntityState.Modified;
                _libraryDbContext.SaveChanges();
                return true;
            }
            return false;
        }

        public void Add(string name)
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
            if (_libraryDbContext.TacGias.Any(tg => tg.TenTacGia.Equals(name)))
            {
                int i = _libraryDbContext.TacGias.Where(tg => tg.TenTacGia.Equals(name)).Count();
                tacGia.TenTacGia = name + $"({i+1})";
            }
            else
            {
                tacGia.TenTacGia = name;
            }
            tacGia.ThongTin = "";
            _libraryDbContext.TacGias.Add(tacGia);
            _libraryDbContext.SaveChanges();
        }

        public void Add(string name, string description)
        {
            TacGia tacGia = new TacGia();
            if (_libraryDbContext.TacGias.Count() == 0)
            {
                tacGia.ID = 1;
            }
            else
            {
                tacGia.ID = _libraryDbContext.TacGias.Max(tg => tg.ID) + 1;
            }
            if (_libraryDbContext.TacGias.Any(tg => tg.TenTacGia.Equals(name)))
            {
                int i = _libraryDbContext.TacGias.Where(tg => tg.TenTacGia.Equals(name)).Count();
                tacGia.TenTacGia = name + $"({i + 1})";
            }
            else
            {
                tacGia.TenTacGia = name;
            }
            tacGia.ThongTin = description;
            _libraryDbContext.TacGias.Add(tacGia);
            _libraryDbContext.SaveChanges();
        }

        public bool CheckExists(string name)
        {
            return _libraryDbContext.TacGias.Any(tg => tg.TenTacGia.Equals(name));
        }

        public List<string> SearchByName(string name)
        {
            List<string> tgs = new List<string>();
            IQueryable<TacGia> tacGias = _libraryDbContext.TacGias
                .Where(tg => tg.TenTacGia.ToLower()
                .Contains(name.ToLower()))
                .Take(4);
            foreach (TacGia tg in tacGias)
            {
                tgs.Add(tg.TenTacGia);
            }
            return tgs;
        }

        public List<object> GetListNumberOfBooks()
        {
            List<object> result = new List<object>();
            foreach (TacGia tg in _libraryDbContext.TacGias.OrderByDescending(tg=>tg.DauSaches.Count))
            {
                result.Add(new{tg.ID,tg.TenTacGia,tg.DauSaches.Count});
            }

            return result;
        }

        public int FindIdByName(string name)
        {
            TacGia tacGia = _libraryDbContext.TacGias.SingleOrDefault(tg => tg.TenTacGia.Equals(name));
            return tacGia == null ? -1 : tacGia.ID;
        }

        public List<TacGia> GetAll()
        {
            return _libraryDbContext.TacGias.ToList();
        }

        public TacGia GetById(int id)
        {
            return _libraryDbContext.TacGias.SingleOrDefault(tg => tg.ID == id);
        }

        public int GetIdByName(string name)
        {
            throw new NotImplementedException();
        }

        public bool Remove(int id)
        {
            try
            {
                TacGia tacGia = GetById(id);
                _libraryDbContext.TacGias.Remove(tacGia);
                _libraryDbContext.SaveChanges();
                return true;
            }
            catch(Exception e)
            {
                return false;
            }
        }
    }
}
