namespace LibraryManagement.DbManager.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DongPhieuMuon")]
    public partial class DongPhieuMuon
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [StringLength(11)]
        public string IDQuyenSach { get; set; }

        public int? IDPhieuMuon { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayTraSach { get; set; }

        [StringLength(10)]
        public string TinhTrangSachTra { get; set; }

        [StringLength(50)]
        public string NoiDungPhat { get; set; }

        public int? TienPhat { get; set; }

        public virtual QuyenSach QuyenSach { get; set; }

        public virtual PhieuMuon PhieuMuon { get; set; }
    }
}
