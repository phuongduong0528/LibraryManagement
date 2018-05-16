using LibraryManagement.DbManager.Controller.ControllerInterface;
using LibraryManagement.DbManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.DbManager.Controller
{
    public class TheLoaiController : ITheLoaiController
    {
        private LibraryDbContext _libraryDbContext;
        public TheLoaiController()
        {
            _libraryDbContext = new LibraryDbContext();
        }
        public bool Add(string name)
        {
            try
            {
                TheLoai theLoai = new TheLoai();
                theLoai.ID = _libraryDbContext.TheLoais.Max(tl => tl.ID) + 1;
                theLoai.TenTheLoai = name;
                _libraryDbContext.TheLoais.Add(theLoai);
                _libraryDbContext.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool CheckName(string tentheoai)
        {
            return _libraryDbContext.TheLoais.Any(tl => tl.TenTheLoai.Equals(tentheoai));
        }

        public bool Edit(int id, string name)
        {
            try
            {
                TheLoai theLoai = _libraryDbContext.TheLoais.SingleOrDefault(tl => tl.ID == id);
                theLoai.TenTheLoai = name;
                _libraryDbContext.Entry(theLoai).State = System.Data.Entity.EntityState.Modified;
                _libraryDbContext.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public int FindIdByName(string name)
        {
            return _libraryDbContext.TheLoais.SingleOrDefault(tl => tl.TenTheLoai.Equals(name)).ID;
        }

        public List<TheLoai> GetAll()
        {
            return _libraryDbContext.TheLoais.ToList();
        }

        public List<string> GetAllByName()
        {
            return _libraryDbContext.TheLoais.Select(tl=>tl.TenTheLoai).ToList();
        }

        public TheLoai GetById(int id)
        {
            return _libraryDbContext.TheLoais.SingleOrDefault(tl => tl.ID == id);
        }

        public bool Remove(int id)
        {
            try
            {
                TheLoai theLoai = GetById(id);
                _libraryDbContext.TheLoais.Remove(theLoai);
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
