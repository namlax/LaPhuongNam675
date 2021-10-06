using System.Dynamic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaPhuongNam675.Models
{
    public class PersonLPN675
    {
        [Key]
        [Column(TypeName = "varchar(20)")]
        public string PersonId { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string PersonName { get; set; }
    }
}