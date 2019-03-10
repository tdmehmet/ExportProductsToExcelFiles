using System.Linq;
using ExportProductsToExcelFiles.Config;
using ExportProductsToExcelFiles.BiggBrands;

namespace ExportProductsToExcelFiles.Repositories.BiggBrands
{
    public class SMPictureRepository : GenericRepository<Picture_SMProductDb>, ISMPictureRepository
    {
        public SMPictureRepository(BiggBrandsContext biggBrandsContext) : base(biggBrandsContext)
        {
        }
    }
}
