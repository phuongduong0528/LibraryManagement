using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.DbManager.Dto
{
    public class PhieuMuonDto
    {
        [DisplayName("Mã phiếu")]
        public int Id { get; set; }

        [DisplayName("Người QL")]
        public string NguoiQl { get; set; }

        [DisplayName("Ngày mượn")]
        public string NgayMuonSach { get; set; }

        [DisplayName("Hạn trả")]
        public string HanTraSach { get; set; }

        public string IdDocGia { get; set; }

        public string DocGia { get; set; }
    }
}
