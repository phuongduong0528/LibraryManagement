namespace LibraryManagement.DbManager.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PhieuMuon")]
    public partial class PhieuMuon
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PhieuMuon()
        {
            DongPhieuMuons = new HashSet<DongPhieuMuon>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [StringLength(7)]
        public string IDNguoiQL { get; set; }

        [StringLength(7)]
        public string IDDocGia { get; set; }

        [Column(TypeName = "date")]
        public DateTime NgayMuonSach { get; set; }

        [Column(TypeName = "date")]
        public DateTime HanTraSach { get; set; }

        public virtual DocGia DocGia { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DongPhieuMuon> DongPhieuMuons { get; set; }

        public virtual NguoiQL NguoiQL { get; set; }
    }
}
