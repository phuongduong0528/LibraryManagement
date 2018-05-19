using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.DbManager.Dto
{
    public class QuyenSachDto
    {
        [DisplayName("ID")]
        public string Id { get; set; }

        [DisplayName("Ten sach")]
        public string TenSach { get; set; }

        [DisplayName("Ngay muon")]
        public string NgayMuon { get; set; }

        [DisplayName("Doc gia muon")]
        public string DocGiaMuon { get; set; } 

        [DisplayName("ID doc gia muon")]
        public string IdDocGiaMuon { get; set; }
    }
}
