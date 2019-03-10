using ExportProductsToExcelFiles.BiggBrands;
using System.Collections.Generic;

namespace ExportProductsToExcelFiles.Services.BiggBrands
{
    public interface ISpecificationAttributeOptionService
    {
        List<SpecificationAttributeOption> FindAllSpecificationAttributeOptions();
    }
}
