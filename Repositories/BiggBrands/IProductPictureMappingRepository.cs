using ExportProductsToExcelFiles.BiggBrands;
using System.Collections.Generic;

namespace ExportProductsToExcelFiles.Repositories.BiggBrands
{
    public interface IProductPictureMappingRepository : IGenericRepository<ProductPictureMapping>
    {
        List<ProductPictureMapping> FindAllProductPictureMappingsByProductId(int productId);
    }
}
