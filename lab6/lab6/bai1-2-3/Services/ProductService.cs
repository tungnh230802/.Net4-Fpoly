

using System.Collections.Generic;

public class ProductService : List<ProductModel>
{
    public ProductService()
    {
        Add(new ProductModel()
        {
            Name = "Men Shoes",
            Price = 99,
            Quantity = 100
        });
        Add(new ProductModel()
        {
            Name = "Women Shoes",
            Price = 199,
            Quantity = 99
        }); 
        Add(new ProductModel()
        {
            Name = "Children Shoes",
            Price = 49,
            Quantity = 300
        });
    }
}