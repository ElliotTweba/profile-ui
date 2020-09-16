using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProfileUser.Models
{
    public class Profile
    {
        [Key]
        public int PID { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(25)")]
        public string Name { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(25)")]
        public string SurName { get; set; }

        [Required]
        [Column(TypeName = "varchar(16)")]
        public string Gender { get; set; }

        [Required]
        [Column(TypeName = "varchar(12)")]
        public int Contact { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string Email { get; set; }

        [Required]
        [Column(TypeName = "varchar(500)")]
        public string Website { get; set; }

        [Required]
        [Column(TypeName = "varchar(500)")]
        public string About { get; set; }

        [Required]
        [Column(TypeName = "varchar(100)")]
        public string CV { get; set; }

                [Required]
        [Column(TypeName = "varchar(100)")]
        public string ProfilePic { get; set; }
    }
}