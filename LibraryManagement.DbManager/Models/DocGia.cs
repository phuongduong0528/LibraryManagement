namespace LibraryManagement.DbManager.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DocGia")]
    public partial class DocGia
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DocGia()
        {
            PhieuMuons = new HashSet<PhieuMuon>();
        }

        [StringLength(7)]
        public string ID { get; set; }

        [StringLength(11)]
        public string MaSV { get; set; }

        [Column(TypeName = "date")]
        public DateTime NgayDangKi { get; set; }

        [Column(TypeName = "date")]
        public DateTime HanTheThuVien { get; set; }

        [Required]
        [StringLength(7)]
        public string TrangThai { get; set; }

        [Required]
        [StringLength(64)]
        public string MatKhau { get; set; }

        public virtual SinhVien SinhVien { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhieuMuon> PhieuMuons { get; set; }
    }
}
