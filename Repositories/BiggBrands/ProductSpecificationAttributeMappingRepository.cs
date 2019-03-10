using ExportProductsToExcelFiles.Config;
using ExportProductsToExcelFiles.BiggBrands;

namespace ExportProductsToExcelFiles.Repositories.BiggBrands
{
    public class ProductSpecificationAttributeMappingRepository : GenericRepository<ProductSpecificationAttributeMapping>, IProductSpecificationAttributeMappingRepository
    {
        public ProductSpecificationAttributeMappingRepository(BiggBrandsContext biggBrandsContext) : base(biggBrandsContext)
        {
        }
    }
}
