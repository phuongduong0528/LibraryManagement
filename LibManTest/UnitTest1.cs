using System;
using System.Collections.Generic;
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
            TacGiaController tacGiaController = new TacGiaController();
            DauSachController dauSachController = new DauSachController();

            //DauSach dauSach = new DauSach();
            //dauSach.ID = 0;
            //dauSach.IDTacGia = 7;
            //dauSach.IDTheLoai = 2;
            //dauSach.IDNhaXuatBan = 1;
            //dauSach.TenSach = "1984";
            //dauSach.SoLuong = 10;
            //dauSach.NamXuatBan = 1949;
            //dauSach.GiaThanh = 99000;
            //dauSach.KeSach = "VHNN-02";
            //dauSach.TrangThai = "OK";
            //bool result = dauSachController.AddNew(dauSach);
            //var x = DauSachAdaptor.GetListDauSachDto(dauSachController.GetAll());
            DongPhieuMuonController dongPhieuMuonController = new DongPhieuMuonController();
            PhieuMuonController phieuMuonController = new PhieuMuonController();
            phieuMuonController.AddNew("NQL-002", "DG00001", new DateTime(2018, 5, 1));
            List<string> sachs = new List<string> { "1-0001", "2-0002" }; 
            dongPhieuMuonController.NewLine(1,sachs);            
        }
    }
}
