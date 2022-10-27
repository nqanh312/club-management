using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubManagementObject
{
    public class Blog
    {
        [Key]
        public int BlogId { get; set; }

        public string UserId { get; set; }
        [ForeignKey("UserId")]
        public User User { get; set; }

        [DataType(DataType.Date)]
        public DateTime? PublicDays { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(3000)]
        public string Content { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(100)]
        public string Image { get; set; }

    }
}
