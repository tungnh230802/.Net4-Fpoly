using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace bai2.Models
//bai2.Models.User
{
    public class User
    {
        [Key]
        public int id { get; set; }
        [MaxLength(255)]
        [Required]
        public string Email { get; set; }
        [MaxLength(255)]
        [Required]
        public string Passwork { get; set; }
    }
}
