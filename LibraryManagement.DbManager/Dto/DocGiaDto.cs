using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.DbManager.Dto
{
    public class DocGiaDto
    {
        [DisplayName("Ma DG")]
        public string Id { get; set; }

        [DisplayName("Ma DG")]
        public string MaSV { get; set; }

        [DisplayName("Ma DG")]
        public string NgayDangKi { get; set; }

        [DisplayName("Ma DG")]
        public string HanThe { get; set; }

        [DisplayName("Ma DG")]
        public string TrangThai { get; set; }
    }
}
