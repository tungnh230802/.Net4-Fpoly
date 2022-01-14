using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Bai2.Models
{
    //Bai2.Models.ProductBai2
    [Table("productBai2")]
    public partial class ProductBai2
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string ProductName { get; set; }
        [Column("price")]
        public double Price { get; set; }
        [Column("category")]
        [StringLength(255)]
        public string Category { get; set; }
        [Column("availibility")]
        [StringLength(255)]
        public string Availibility { get; set; }
        [Column("descriptions")]
        [StringLength(1000)]
        public string Descriptions { get; set; }
        [Column("imageProduct")]
        [StringLength(200)]
        public string ImageProduct { get; set; }
    }
}
