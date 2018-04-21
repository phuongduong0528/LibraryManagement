using System;
using LibraryManagement.DbManager.Adaptor;
using LibraryManagement.DbManager.Controller;
using LibraryManagement.DbManager.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibManTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //TacGiaController tacGiaController = new TacGiaController();
            DauSachController dauSachController = new DauSachController();
            //DauSach dauSach = new DauSach();
            //dauSach.ID = 0;
            //dauSach.IDTacGia = 2;
            //dauSach.IDTheLoai = 2;
            //dauSach.IDNhaXuatBan = 1;
            //dauSach.TenSach = "Giã từ vũ khí - A Farewell to Arms";
            //dauSach.SoLuong = 50;
            //dauSach.NamXuatBan = 1929;
            //dauSach.GiaThanh = 99000;
            //dauSach.KeSach = "VHNN-02";
            //dauSach.TrangThai = "OK";
            //bool result = dauSachController.AddNew(dauSach);
            var x = DauSachAdaptor.GetListDauSachDto(dauSachController.GetAll()); 
        }
    }
}
