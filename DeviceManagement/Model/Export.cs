using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeviceManagement.Model
{
    public class Export
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        public int IDnguoixuat { get; set; }

        [Required]
        public int IDnguoinhan { get; set; }

        [ForeignKey("IDnguoixuat")]
        public Account? Importer { get; set; }

        [ForeignKey("IDnguoinhan")]
        public Account? Exporter { get; set; }

        [Required]
        public int IDTB { get; set; }

    }
}
