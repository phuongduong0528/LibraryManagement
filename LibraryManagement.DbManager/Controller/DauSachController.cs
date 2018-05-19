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

        public bool Add(DauSach dauSach)
        {
            try
            {
                dauSach.ID = _libraryDbContext.DauSaches.Count() + 1;
                _libraryDbContext.DauSaches.Add(dauSach);
                _libraryDbContext.SaveChanges();
                QuyenSachController quyenSachController = new QuyenSachController();
                quyenSachController.Add(dauSach.SoLuong, dauSach.ID);
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        public bool Edit(DauSach dauSach)
        {
            try
            {
                DauSach ds = _libraryDbContext.DauSaches.SingleOrDefault(ds1 => ds1.ID == dauSach.ID);
                ds.IDTacGia = dauSach.IDTacGia;
                ds.IDTheLoai = dauSach.IDTheLoai;
                ds.IDNhaXuatBan = dauSach.IDNhaXuatBan;
                ds.TenSach = dauSach.TenSach;
                ds.SoLuong = dauSach.SoLuong;
                ds.NamXuatBan = dauSach.NamXuatBan;
                ds.GiaThanh = dauSach.GiaThanh;
                ds.KeSach = dauSach.KeSach;
                ds.TrangThai = dauSach.TrangThai;
                _libraryDbContext.Entry(ds).State = System.Data.Entity.EntityState.Modified;
                _libraryDbContext.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public List<DauSach> GetAllDauSach()
        {
            return _libraryDbContext.DauSaches.ToList();
        }

        public List<DauSach> GetByFilter(string ten, string theLoai, string tacGia)
        {
            List<DauSach> dauSaches = new List<DauSach>();
            if (!string.IsNullOrEmpty(ten))
            {
                dauSaches = _libraryDbContext.DauSaches.Where(ds => ds.TenSach.Contains(ten)).Take(100).ToList();
            }
            if (!string.IsNullOrEmpty(theLoai))
            {
                dauSaches = _libraryDbContext.DauSaches.Where(ds => ds.TheLoai.TenTheLoai.Contains(theLoai)).Take(100).ToList();
            }
            if (!string.IsNullOrEmpty(tacGia))
            {
                dauSaches = _libraryDbContext.DauSaches.Where(ds => ds.TacGia.TenTacGia.Contains(tacGia)).Take(100).ToList();
            }
            return dauSaches;
        }

        public DauSach GetById(int id)
        {
            return _libraryDbContext.DauSaches.SingleOrDefault(ds => ds.ID == id);
        }

        public List<DauSach> SearchByName(string searchStr)
        {
            return _libraryDbContext.DauSaches
                .Where(ds => ds.TenSach.Contains(searchStr))
                .Take(100)
                .ToList();
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

        public bool Remove(int id, bool delForeignKey)
        {
            try
            {
                DauSach ds1 = GetById(id);
                _libraryDbContext.DauSaches.Remove(ds1);
                if (delForeignKey)
                {
                    IQueryable<QuyenSach> quyensachs = _libraryDbContext.QuyenSaches.Where(qs => qs.IDDauSach == id);
                    _libraryDbContext.QuyenSaches.RemoveRange(quyensachs);
                }
                _libraryDbContext.SaveChanges();
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }
    }
}
