using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.DbManager.Dto
{
    public class DauSachDto
    {
        [DisplayName("Mã sách")]
        public int Id { get; set; }

        [DisplayName("Tên sách")]
        public string TenSach { get; set; }

        [DisplayName("Tác giả")]
        public string TacGia { get; set; }

        [DisplayName("Nhà XB")]
        public string NhaXuatBan { get; set; }

        [DisplayName("Năm XB")]
        public int? NamXuatBan { get; set; }

        [DisplayName("Thể loại")]
        public string TheLoai { get; set; }

        [DisplayName("Mã kệ sách")]
        public string KeSach { get; set; }
    }
}
