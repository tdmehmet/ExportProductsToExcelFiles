using System;
using System.Collections.Generic;
using ExportProductsToExcelFiles.BiggBrands;

namespace ExportProductsToExcelFiles.Services.BiggBrands
{
    public interface IProductManufacturerMappingService
    {
        List<ProductManufacturerMapping> FindAllProductManufacturerMappings();
        void AddProductManufacturerMapping(ProductManufacturerMapping productManufacturerMapping);
    }
}
