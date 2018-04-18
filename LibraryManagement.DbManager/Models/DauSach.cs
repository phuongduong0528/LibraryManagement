namespace LibraryManagement.DbManager.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DauSach")]
    public partial class DauSach
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DauSach()
        {
            QuyenSaches = new HashSet<QuyenSach>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        public int? IDTacGia { get; set; }

        public int? IDTheLoai { get; set; }

        public int? IDNhaXuatBan { get; set; }

        [Required]
        [StringLength(100)]
        public string TenSach { get; set; }

        public int SoLuong { get; set; }

        public int? NamXuatBan { get; set; }

        public int GiaThanh { get; set; }

        [Required]
        [StringLength(7)]
        public string KeSach { get; set; }

        [Required]
        [StringLength(50)]
        public string TrangThai { get; set; }

        public virtual TacGia TacGia { get; set; }

        public virtual TheLoai TheLoai { get; set; }

        public virtual NhaXuatBan NhaXuatBan { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QuyenSach> QuyenSaches { get; set; }
    }
}
