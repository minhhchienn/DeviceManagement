using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System;

namespace DeviceManagement.Model
{
    [Table("phieunhap")]
    public class Import
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [InverseProperty("import")]
        public List<Device>? devices { get; set; }

        [Required]
        public int IDnguoinhap { get; set; }

        [ForeignKey("IDnguoinhap")]
        public Account? importer { get; set; }

        [Required]
        [StringLength(50)]
        public string? nguoiban { get; set; }

        [Required]
        [StringLength(100)]
        public string? congty { get; set; }

        [Required]
        public DateTime ngaynhap { get; set; }
    }
}
