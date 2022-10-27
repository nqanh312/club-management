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
    public class Task
    {
        [Key]
        public int TaskId { get; set; }
        public int? activityId { get; set; }
        [ForeignKey("activityId")]
        public ClubActivity ClubActivity { get; set; }

        public string UserId { get; set; }
        [ForeignKey("UserId")]
        public User User { get; set; }
        public int Sumpoint { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string Semester { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(100)]
        public string TaskName { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(500)]
        public string Description { get; set; }

        public Boolean IsCompleted { get; set; }

        public int TaskPoint { get; set; }

    }
}
