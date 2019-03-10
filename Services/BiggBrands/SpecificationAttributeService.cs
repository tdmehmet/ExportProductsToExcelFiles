using System;
using System.Collections.Generic;
using ExportProductsToExcelFiles.Repositories.BiggBrands;
using ExportProductsToExcelFiles.BiggBrands;

namespace ExportProductsToExcelFiles.Services.BiggBrands
{
    public class SpecificationAttributeService : ISpecificationAttributeService
    {
        private readonly ISpecificationAttributeRepository _specificationAttributeRepository;

        public SpecificationAttributeService(
                                      ISpecificationAttributeRepository specificationAttributeRepository
                                     )
        {
            _specificationAttributeRepository = specificationAttributeRepository;
        }

        public List<SpecificationAttribute> FindAllSpecificationAttributes()
        {
            return _specificationAttributeRepository.FindAllItems();
        }
    }
}
