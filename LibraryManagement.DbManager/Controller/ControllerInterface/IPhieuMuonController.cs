using LibraryManagement.DbManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.DbManager.Controller.ControllerInterface
{
    interface IPhieuMuonController
    {
        int Add(string IdNql, string IdDocGia,DateTime HanTra);
        bool Edit(int idPhieuMuon, DateTime ngayTra);
        PhieuMuon GetById(int id);
        List<int> GetId(string searchStr);
    }
}
