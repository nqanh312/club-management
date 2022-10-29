using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;

namespace BusinessObject
{
    public class AppUser : IdentityUser
    {

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
