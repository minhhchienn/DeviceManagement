using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DeviceManagement.Model
{
    [Table("thietbi")]
    public class Device
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        [StringLength(100)]
        public string? tentb { get; set; }

        [Required]
        [StringLength(100)]
        public string? serial { get; set; }

        [Required]
        public decimal gia { get; set; }

        public DateTime tgbaohanh { get; set; }

        [Required]
        public int idpn { get; set; }

        [ForeignKey("idpn")]
        public Import? import { get; set; }
    }
}
