using LibraryManagement.DbManager.Dto;
using LibraryManagement.DbManager.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.DbManager.Adaptor
{
    public class DocGiaController
    {
        public static DocGiaDto GetDocGiaDto(DocGia docGia)
        {
            DocGiaDto docGiaDto = new DocGiaDto();
            docGiaDto.Id = docGia.ID;
            docGiaDto.MaSV = docGia.SinhVien.MaSV;
            docGiaDto.NgayDangKi = docGia.NgayDangKi.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);
            docGiaDto.HanThe = docGia.HanTheThuVien.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);
            docGiaDto.TrangThai = docGia.TrangThai;
            return docGiaDto;
        }

        public static List<DocGiaDto> GetListDocGiaDto(List<DocGia> docGias)
        {
            List<DocGiaDto> docGiaDtos = new List<DocGiaDto>();
            foreach(DocGia dg in docGias)
            {
                docGiaDtos.Add(GetDocGiaDto(dg));
            }
            return docGiaDtos;
        }
    }
}
