using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEasyFirstEF.Model
{
    [Table("Sysdata")]
    public class SysdataEntity
    {
        [Key, Required]
        [Column("AppName", TypeName = "nvarchar(50)")]
        public string AppName { get; set; }

        [Column("SectionName", TypeName = "nvarchar(50)")]
        public string? SectionName { get; set; }

        [Column("KeyName", TypeName = "nvarchar(50)")]
        public string? KeyName { get; set; }

        [Column("Setting", TypeName = "nvarchar(4000)")]
        public string? Setting { get; set; }
    }
}
