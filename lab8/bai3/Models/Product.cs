using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace bai3.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(255)]
        [Required]
        public string Name { get; set; }
        public float Price { get; set; }
        public int Quantity { get; set; }
        [Column(TypeName ="bool")]
        public bool Status { get; set; }
    }
}
