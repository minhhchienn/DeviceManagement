using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Windows.Documents;
using System.Collections.Generic;

namespace DeviceManagement.Model
{
    [Table("taikhoan")]
    public class Account
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string? tendangnhap { get; set; }

        [Required]
        [StringLength(50)]
        public string? matkhau { get; set; }

        [Required]
        [StringLength(10)]
        public string? quyen { get; set; }

        [Required]
        [StringLength(50)]
        public string? hoten { get; set; }

        [Required]
        [StringLength(20)]
        public string? sdt { get; set; }

        [Required]
        [StringLength(50)]
        public string? email { get; set; }

        [Required]
        [StringLength(50)]
        public string? chucvu { get; set; }

        [InverseProperty("importer")]
        public List<Import>? imports { get; set; }
    }
}
