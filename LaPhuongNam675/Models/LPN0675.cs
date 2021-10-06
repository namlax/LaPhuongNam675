using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaPhuongNam675.Models
{
    public class LPN0675
    {
        [Key]
        [Column(TypeName = "varchar(20)")]
        public string LPNId { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string LPNName { get; set; }
        [Column(TypeName = "boolean")]
        public string LPNGender { get; set; }
    }
}