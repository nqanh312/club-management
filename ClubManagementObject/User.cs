
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
    public class User
    {
        [Key]
        public string UserId { get; set; }

        public int? RoleId { get; set; }
        [ForeignKey("RoleId")]
        public Role Role { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(500)]
        public string UserName { get; set; }

        public string Phone { get; set; }

        public string Password { get; set; }


        public int? StateUserId { get; set; }
        [ForeignKey("StateUserId")]
        public StateUser StateUser { get; set; }
        [Column(TypeName = "nvarchar")]
        [StringLength(100)]
        public string FullName { get; set; }

        // [Required]       
        [DataType(DataType.Date)]
        public DateTime? BirthDate { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(50)]
        public string Major { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(10)]
        public string K { get; set; }


        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string StudentId { get; set; }
    }
}
