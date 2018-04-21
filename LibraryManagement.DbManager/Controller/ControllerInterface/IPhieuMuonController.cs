using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.DbManager.Controller.ControllerInterface
{
    interface IPhieuMuonController
    {
        bool AddNew(string IdNql, string IdDocGia,DateTime HanTra);
    }
}
