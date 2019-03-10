using ExportProductsToExcelFiles.Config;
using ExportProductsToExcelFiles.BiggBrands;

namespace ExportProductsToExcelFiles.Repositories.BiggBrands
{
    public class SpecificationAttributeOptionRepository : GenericRepository<SpecificationAttributeOption>, ISpecificationAttributeOptionRepository
    {
        public SpecificationAttributeOptionRepository(BiggBrandsContext biggBrandsContext) : base(biggBrandsContext)
        {
        }
    }
}
