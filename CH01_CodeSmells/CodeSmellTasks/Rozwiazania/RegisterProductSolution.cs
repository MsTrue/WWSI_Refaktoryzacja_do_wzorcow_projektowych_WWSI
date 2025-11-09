using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class RegisterProductSolution {


    public void RegisterProduct(ProductInfo product)
    {
        // Rejestracja produktu
        Console.WriteLine($"Product: {product.ProductName}, Category: {product.Category}, Price: {product.Price:C}, Stock: {product.Stock}, Supplier: {product.SupplierName}, Contact: {product.SupplierContact}");
    }

}

public class ProductInfo
{
    public string ProductName { get; set; }
    public string Category { get; set; }
    public decimal Price { get; set; }
    public int Stock { get; set; }
    public string SupplierName { get; set; }
    public string SupplierContact { get; set; }
}
