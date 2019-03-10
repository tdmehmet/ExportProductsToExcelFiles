using System;
using System.Collections.Generic;
using ExportProductsToExcelFiles.BiggBrands;

namespace ExportProductsToExcelFiles.Services.BiggBrands
{
    public interface IProductPictureMappingService
    {
        List<ProductPictureMapping> FindAllProductPictureMappings();
        void AddProductPictureMappingRange(List<ProductPictureMapping> productPictureMappings);
    }
}
