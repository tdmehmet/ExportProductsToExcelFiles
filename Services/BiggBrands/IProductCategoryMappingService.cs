using System;
using System.Collections.Generic;
using ExportProductsToExcelFiles.BiggBrands;

namespace ExportProductsToExcelFiles.Services.BiggBrands
{
    public interface IProductCategoryMappingService
    {
        List<ProductCategoryMapping> FindAllProductCategoryMappings();
        ProductCategoryMapping SaveProductCategoryMapping(ProductCategoryMapping productCategoryMapping);
    }
}
