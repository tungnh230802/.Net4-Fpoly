
using System;
using System.ComponentModel.DataAnnotations;

namespace lab7.Models
{
    public class ProductModel
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(255)]
        public string Name { get; set; }
        [MaxLength(50)]
        public string Color {get;set;} 
        [MaxLength(50)]
        public string UnitPrice {get;set;} 
        public int? AvaiableQuantity {get;set;}
        [DataType(DataType.Date)]
        public DateTime? CreatedData {get;set;}
    }
}
