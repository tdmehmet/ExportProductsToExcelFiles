using System;
using System.Collections.Generic;
using ExportProductsToExcelFiles.Repositories.BiggBrands;
using ExportProductsToExcelFiles.BiggBrands;

namespace ExportProductsToExcelFiles.Services.BiggBrands
{
    public class ProductSpecificationAttributeMappingService : IProductSpecificationAttributeMappingService
    {
        private readonly IProductSpecificationAttributeMappingRepository _productSpecificationAttributeMappingRepository;

        public ProductSpecificationAttributeMappingService(
                                      IProductSpecificationAttributeMappingRepository productSpecificationAttributeMappingRepository
                                     )
        {
            _productSpecificationAttributeMappingRepository = productSpecificationAttributeMappingRepository;
        }

        public List<ProductSpecificationAttributeMapping> FindAllProductSpecificationAttributeMappings()
        {
            return _productSpecificationAttributeMappingRepository.FindAllItems();
        }
    }
}
