using System.Linq;
using System.Collections.Generic;
using ExportProductsToExcelFiles.BiggBrands;

namespace ExportProductsToExcelFiles.Utils
{
    public static class ProductCategoryMappingUtil
    {

        public static List<ProductCategoryMapping> GenerateProductCategoryMappings(
            List<Category> categories,
            string fileName,
            Product product, 
            List<ProductCategoryMapping> productCategoryMappings)
        {
            List<ProductCategoryMapping> productCategoryMappingList = new List<ProductCategoryMapping>();

            Category category = categories.Where(c => fileName.IndexOf(c.Name) != -1).FirstOrDefault();
            category = category ?? categories.Where(c => c.Name == "Other").FirstOrDefault();

            ProductCategoryMapping productCategoryMapping1 = productCategoryMappings
                .Where(pcm => pcm.ProductId == product.Id )
                .FirstOrDefault();

            if(productCategoryMapping1 != null) { 
                productCategoryMappingList.Add(productCategoryMapping1);
            }

            ProductCategoryMapping productCategoryMapping2 = productCategoryMappings
                .Where(pcm => pcm.ProductId == product.Id && pcm.CategoryId == category.Id )
                .FirstOrDefault();
            
            
            if (productCategoryMapping2 == null)
            {
                productCategoryMapping2 = new ProductCategoryMapping()
                {
                    ProductId = product.Id,
                    CategoryId = category.Id,
                    IsFeaturedProduct = false,
                    DisplayOrder = 0,
                };
            }
            
            productCategoryMappingList.Add(productCategoryMapping2);
            return productCategoryMappingList;
        }
    }
}
