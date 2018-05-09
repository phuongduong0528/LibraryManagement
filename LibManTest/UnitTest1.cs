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
            //dauSach.IDTacGia = 4;
            //dauSach.IDTheLoai = 1;
            //dauSach.IDNhaXuatBan = 1;
            //dauSach.TenSach = "l";
            //dauSach.SoLuong = 5;
            //dauSach.NamXuatBan = 2013;
            //dauSach.GiaThanh = 500000;
            //dauSach.KeSach = "CNTT-01";
            //dauSach.TrangThai = "OK";
            //bool result = dauSachController.AddNew(dauSach);
            //var x = DauSachAdaptor.GetListDauSachDto(dauSachController.GetAll());

            //DongPhieuMuonController dongPhieuMuonController = new DongPhieuMuonController();
            //PhieuMuonController phieuMuonController = new PhieuMuonController();

            //phieuMuonController.AddNew("NQL-002", "DG00000", new DateTime(2018, 5, 1));
            //List<string> sachs = new List<string> { "1-0002", "2-0003", "3-0004" };
            //dongPhieuMuonController.NewLine(2, sachs);

            //QuyenSachController quyenSachController = new QuyenSachController();
            //var x = quyenSachController.GetBorrowedBooks();

            //var y = dongPhieuMuonController.GetByDocGia("DG00001");

            //var x1 = quyenSachController.GetBorrowedBooks();

            //dongPhieuMuonController.EditLine(1, "1-0001", new DateTime(2017, 4, 30), "OK", "", 0);

            //var x2 = quyenSachController.GetBorrowedBooks();

            //for (int i = 0; i < 3; i++)
            //{
            //    DauSach dauSach = new DauSach();
            //    dauSach.ID = 0;
            //    dauSach.IDTacGia = 4;
            //    dauSach.IDTheLoai = 1;
            //    dauSach.IDNhaXuatBan = 1;
            //    dauSach.TenSach = $"Lập trình ASP.NET - tập {i+1}";
            //    dauSach.SoLuong = 10;
            //    dauSach.NamXuatBan = 2015;
            //    dauSach.GiaThanh = 50000;
            //    dauSach.KeSach = "CNTT-04";
            //    dauSach.TrangThai = "OK";
            //    bool result = dauSachController.AddNew(dauSach);
            //}
        }
    }
}
