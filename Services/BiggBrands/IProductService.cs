using System;
using System.Collections.Generic;
using ExportProductsToExcelFiles.AppModels;
using ExportProductsToExcelFiles.BiggBrands;

namespace ExportProductsToExcelFiles.Services.BiggBrands
{
    public interface IProductService
    {
        void SetProductsAsUpdatedFalse();
        bool ProductExistsOnDB(AppProduct appProduct);
        Product AddProduct(Product product);
        Product FindProductByLogoCode(string logoCode);
        List<Product> FindAllProducts();
        void UpdateProduct(Product product);
        void UpdateProductRange(List<Product> products);
        void AddProductRange(List<Product> products);
        List<Product> FindProductsByBrand(string brand);
    }
}
