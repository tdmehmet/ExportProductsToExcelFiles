using System;
using System.Collections.Generic;
using ExportProductsToExcelFiles.Repositories.BiggBrands;
using ExportProductsToExcelFiles.BiggBrands;

namespace ExportProductsToExcelFiles.Services.BiggBrands
{
    public class ProductCategoryMappingService : IProductCategoryMappingService
    {
        private readonly IProductCategoryMappingRepository _thyMenaProductCategoryMappingRepository;

        public ProductCategoryMappingService(
                                      IProductCategoryMappingRepository thyMenaProductCategoryMappingRepository
                                     )
        {
            _thyMenaProductCategoryMappingRepository = thyMenaProductCategoryMappingRepository;
        }

        public List<ProductCategoryMapping> FindAllProductCategoryMappings()
        {
            return _thyMenaProductCategoryMappingRepository.FindAllProductCategoryMappings();
        }

        public ProductCategoryMapping SaveProductCategoryMapping(ProductCategoryMapping productCategoryMapping)
        {
            ProductCategoryMapping savedProductCategoryMapping = _thyMenaProductCategoryMappingRepository.Add(productCategoryMapping);
            _thyMenaProductCategoryMappingRepository.Save();
            return savedProductCategoryMapping;
        }
    }
}
