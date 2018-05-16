using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.DbManager.Dto
{
    public class DongPhieuMuonDto
    {
        public int ID { get; set; }

        [DisplayName("Phiếu mượn")]
        public string IdPhieuMuon { get; set; }
                
        [DisplayName("Mã sách")]
        public string IdSach { get; set; }

        [DisplayName("Tên sách")]
        public string TenSach { get; set; }

        [DisplayName("Ngày Mượn")]
        public string NgayMuon { get; set; }

        [DisplayName("Ngày Hẹn trả")]
        public string NgayHenTra { get; set; }

        [DisplayName("Ngày Trả")]
        public string NgayTra { get; set; }

        [DisplayName("Tình Trạng")]
        public string TinhTrang { get; set; }

        [DisplayName("Nội dung phạt")]
        public string NoiDungPhat { get; set; }

        [DisplayName("Tiền phạt")]
        public int TienPhat { get; set; }
    }
}
