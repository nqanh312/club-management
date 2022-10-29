using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessObject
{
    public class StateUser
    {
        [Key]
        public int StateUserId { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(50)]
        public string StateUserName { get; set; }
    }
}
