using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.DbManager.Dto
{
    public class SachMuonNhieuDto
    {
        [DisplayName("ID")]
        public int IdDauSach { get; set; }

        [DisplayName("Tên sách")]
        public string TenSach { get; set; }

        [DisplayName("Tác giả")]
        public string TacGia { get; set; }

        [DisplayName("Nhà xuất bản")]
        public string Nxb { get; set; }

        [DisplayName("Thể loại")]
        public string TheLoai { get; set; }

        [DisplayName("Số lượt mượn")]
        public int SoLuotMuon { get; set; }
    }
}