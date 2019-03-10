using ExportProductsToExcelFiles.Config;
using ExportProductsToExcelFiles.BiggBrands;

namespace ExportProductsToExcelFiles.Repositories.BiggBrands
{
    public class SpecificationAttributeRepository : GenericRepository<SpecificationAttribute>, ISpecificationAttributeRepository
    {
        public SpecificationAttributeRepository(BiggBrandsContext biggBrandsContext) : base(biggBrandsContext)
        {
        }
    }
}
