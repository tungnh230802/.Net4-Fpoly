using System;
using System.ComponentModel.DataAnnotations;

namespace Bai1.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required,StringLength(255)]
        public string Name { get; set; }
        [Required,StringLength(255)]
        public string category { get; set; }
        [Required,StringLength(255)]
        public string Color { get; set; }
        [DataType(DataType.Currency)]
        public int? Price { get; set; }
        public int? AvailableQuantity { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime CreatedDate { get; set; }
    }
}
