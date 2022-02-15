

using System.ComponentModel.DataAnnotations;

public class ProductModel
{
    [Display(Name = "Tên sản phẩm")]
    public string Name { get; set; }
    [Display(Name = "Giá")]
    public float Price { get; set; }
    [Display(Name = "Số lượng")]
    public int Quantity { get; set; }
}