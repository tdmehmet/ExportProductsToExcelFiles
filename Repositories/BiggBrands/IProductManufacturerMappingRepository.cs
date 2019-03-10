using ExportProductsToExcelFiles.BiggBrands;

namespace ExportProductsToExcelFiles.Repositories.BiggBrands
{
    public interface IProductManufacturerMappingRepository : IGenericRepository<ProductManufacturerMapping>
    {
        ProductManufacturerMapping FindByProductId(int productId);
    }
}
