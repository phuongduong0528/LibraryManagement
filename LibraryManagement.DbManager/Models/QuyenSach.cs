namespace LibraryManagement.DbManager.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("QuyenSach")]
    public partial class QuyenSach
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public QuyenSach()
        {
            DongPhieuMuons = new HashSet<DongPhieuMuon>();
        }

        [StringLength(11)]
        public string ID { get; set; }

        public int? IDDauSach { get; set; }

        [Required]
        [StringLength(10)]
        public string TinhTrang { get; set; }

        [StringLength(100)]
        public string MoTa { get; set; }

        public virtual DauSach DauSach { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DongPhieuMuon> DongPhieuMuons { get; set; }
    }
}
