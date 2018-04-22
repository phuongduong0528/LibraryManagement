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
        bool NewLine(int idPhieuMuon,List<string> idQuyenSachs);
        bool EditLine(int idPhieuMuon, string idQuyenSach, 
            DateTime ngayTra,string tinhTrang,string NoiDung,int tienPhat);
        bool Check(string idPhieuMuon, string idQuyenSach);
        List<DongPhieuMuon> GetByDocGia(string idDocGia);
        List<DongPhieuMuon> GetByMaSinhVien(string msv);
    }
}
