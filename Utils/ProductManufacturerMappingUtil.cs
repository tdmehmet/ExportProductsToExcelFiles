using ExportProductsToExcelFiles.BiggBrands;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExportProductsToExcelFiles.Utils
{
    public static class ProductManufacturerMappingUtil
    {
        public static ProductManufacturerMapping CreateProductManufacturerMapping(int productId, int manufacturerId)
        {
            return new ProductManufacturerMapping()
            {
                ProductId = productId,
                ManufacturerId = manufacturerId,
                IsFeaturedProduct = false,
                DisplayOrder = 0
            };
        }

        public static List<ProductManufacturerMapping> CreateProductManufacturerMappingList(
            Product product,
            Manufacturer manufacturer,
            List<ProductManufacturerMapping> productManufacturerMappings)
        {
            List<ProductManufacturerMapping> productManufacturerMappingReturnList = new List<ProductManufacturerMapping>();
            if (productManufacturerMappings == null || productManufacturerMappings.Count <= 0)
            {
                productManufacturerMappingReturnList.Add(
                    new ProductManufacturerMapping()
                    {
                        ProductId = product.Id,
                        ManufacturerId = manufacturer.Id,
                        IsFeaturedProduct = false,
                        Manufacturer = manufacturer,
                        Product = product
                    }
                );
            }
            else
            {
                foreach (ProductManufacturerMapping productManufacturerMapping in productManufacturerMappings)
                {
                    productManufacturerMapping.ManufacturerId = manufacturer.Id;
                    productManufacturerMapping.ProductId = product.Id;
                    productManufacturerMapping.IsFeaturedProduct = false;
                    productManufacturerMappingReturnList.Add(productManufacturerMapping);
                }
            }

            return productManufacturerMappingReturnList;
        }
    }
}
