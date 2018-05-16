using LibraryManagement.DbManager.Controller.ControllerInterface;
using LibraryManagement.DbManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.DbManager.Controller
{
    public class NhaXuatBanController : INhaXuatBanController
    {
        private LibraryDbContext _libraryDbContext;

        public NhaXuatBanController()
        {
            _libraryDbContext = new LibraryDbContext();
        }

        public bool Add(string name)
        {
            try
            {
                NhaXuatBan nhaXuatBan = new NhaXuatBan();
                nhaXuatBan.ID = _libraryDbContext.NhaXuatBans.Max(nxb => nxb.ID) + 1;
                if (_libraryDbContext.NhaXuatBans.Any(nxb => nxb.TenNhaXuatBan.Equals(name)))
                {
                    int count = _libraryDbContext.NhaXuatBans.Where(nxb => nxb.TenNhaXuatBan.Equals(name)).Count();
                    nhaXuatBan.TenNhaXuatBan = name + $"({count})";
                }
                else
                {
                    nhaXuatBan.TenNhaXuatBan = name;
                }
                _libraryDbContext.NhaXuatBans.Add(nhaXuatBan);
                _libraryDbContext.SaveChanges();
                return true;
            }
            catch(Exception e)
            {
                return false;
            }
        }

        public bool Edit(int id, string name)
        {
            try
            {
                NhaXuatBan nhaXuatBan = _libraryDbContext.NhaXuatBans.SingleOrDefault(nxb=>nxb.ID == id);
                if (_libraryDbContext.NhaXuatBans.Any(nxb => nxb.TenNhaXuatBan.Equals(name)))
                {
                    int count = _libraryDbContext.NhaXuatBans.Where(nxb => nxb.TenNhaXuatBan.Equals(name)).Count();
                    nhaXuatBan.TenNhaXuatBan = name + $"({count})";
                }
                else
                {
                    nhaXuatBan.TenNhaXuatBan = name;
                }
                _libraryDbContext.Entry(nhaXuatBan).State = System.Data.Entity.EntityState.Modified;
                _libraryDbContext.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public List<NhaXuatBan> GetAll()
        {
            return _libraryDbContext.NhaXuatBans.ToList();
        }

        public List<string> GetAllByName()
        {
            return _libraryDbContext.NhaXuatBans.Select(nxb=>nxb.TenNhaXuatBan).ToList();
        }

        public int FindIdByName(string name)
        {
            try
            {
                return _libraryDbContext.NhaXuatBans.SingleOrDefault(nxb => nxb.TenNhaXuatBan.Equals(name)).ID;
            }
            catch(Exception e)
            {
                return -1;
            }
        }

        public NhaXuatBan GetById(int id)
        {
            return _libraryDbContext.NhaXuatBans.SingleOrDefault(nxb => nxb.ID == id);
        }

        public bool Remove(int id)
        {
            try
            {
                NhaXuatBan nhaXuatBan = GetById(id);
                _libraryDbContext.NhaXuatBans.Remove(nhaXuatBan);
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
