namespace PhongMachTu.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChiTietThongKeThuoc")]
    public partial class ChiTietThongKeThuoc
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [StringLength(5)]
        public string MaTKThuoc { get; set; }

        [Required]
        [StringLength(5)]
        public string MaThuoc { get; set; }

        public int? SoLuong { get; set; }

        public int? SoLanBan { get; set; }

        public virtual Thuoc Thuoc { get; set; }
    }
}
