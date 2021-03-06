﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.DbManager.Dto
{
    public class DocGiaDto
    {
        [DisplayName("Mã ĐG")]
        public string Id { get; set; }

        [DisplayName("Mã SV")]
        public string MaSV { get; set; }

        [DisplayName("Tên")]
        public string Ten { get; set; }

        [DisplayName("Ngày sinh")]
        public string NgaySinh { get; set; }
        
        [DisplayName("Giới tính")]
        public string GioiTinh { get; set; }

        [DisplayName("Địa chỉ")]
        public string DiaChi { get; set; }

        [DisplayName("SĐT")]
        public string SoDT { get; set; }

        [DisplayName("Ngày Đăng Kí")]
        public string NgayDangKi { get; set; }

        [DisplayName("Hạn thẻ")]
        public string HanThe { get; set; }

        [DisplayName("Má Trạng thái")]
        public string TrangThai { get; set; }
    }
}
