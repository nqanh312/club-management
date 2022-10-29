using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
    public class StateActivity
    {
        [Key]
        public int StateActivyId { get; set; }

        [Column(TypeName= "nvarchar")]
        [StringLength(50)]
        public string StateActivityName { get; set; }


    }
}
