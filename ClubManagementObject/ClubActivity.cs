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
    public class ClubActivity
    {
        [Key]
        public int ActivityId { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(200)]
        public string ActivityName { get; set; }

        [DataType(DataType.Date)]
        public DateTime StartDay { get; set; }

        [DataType(DataType.Date)]
        public DateTime EndDay { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(1000)]
        public string Image { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(500)]
        public string Description { get; set; }

        public int? activityStateId { get; set; }
        [ForeignKey("activitySateId")]
        public StateActivity StateActivity { get; set; } // khóa ngoại ActivitySate
    }
}
