using LibraryManagement.DbManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.DbManager.Controller.ControllerInterface
{
    interface IDongPhieuMuonController
    {
        bool Add(int idPhieuMuon,List<string> idQuyenSachs);
        bool Edit(int idPhieuMuon, int iddongphieu, 
            DateTime ngayTra,string tinhTrang,string NoiDung,int tienPhat);
        bool CheckDuplicateBooks(string idPhieuMuon, string idQuyenSach); //NOT USE
        bool ResetMoney(int iddongphieu); //Đã nộp phạt
        List<DongPhieuMuon> GetListByPhieuMuon(int idPhieuMuon);
        List<DongPhieuMuon> GetListByDocGia(string idDocGia);
        List<DongPhieuMuon> GetListByMaSinhVien(string msv);
        List<DongPhieuMuon> GetListCurrentlyBookedBooks(string idDocGia);
    }
}
