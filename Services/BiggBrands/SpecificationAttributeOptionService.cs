using ExportProductsToExcelFiles.BiggBrands;
using ExportProductsToExcelFiles.Repositories.BiggBrands;
using System.Collections.Generic;

namespace ExportProductsToExcelFiles.Services.BiggBrands
{
    public class SpecificationAttributeOptionService : ISpecificationAttributeOptionService
    {
        private readonly ISpecificationAttributeOptionRepository _specificationAttributeOptionRepository;

        public SpecificationAttributeOptionService(
                                      ISpecificationAttributeOptionRepository specificationAttributeOptionRepository
                                     )
        {
            _specificationAttributeOptionRepository = specificationAttributeOptionRepository;
        }

        public List<SpecificationAttributeOption> FindAllSpecificationAttributeOptions()
        {
            return _specificationAttributeOptionRepository.FindAllItems();
        }
    }
}
