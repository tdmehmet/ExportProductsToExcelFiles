using System;
using System.Collections.Generic;
using ExportProductsToExcelFiles.Repositories.BiggBrands;
using ExportProductsToExcelFiles.BiggBrands;
using ExportProductsToExcelFiles.Utils;

namespace ExportProductsToExcelFiles.Services.BiggBrands
{
	public class ProductManufacturerMappingService : IProductManufacturerMappingService
    {
        private readonly IProductManufacturerMappingRepository _thyMenaProductManufacturerMappingRepository;
        
        public ProductManufacturerMappingService(
            IProductManufacturerMappingRepository thyMenaProductManufacturerMappingRepository
            )
        {
            _thyMenaProductManufacturerMappingRepository = thyMenaProductManufacturerMappingRepository;
        }

        public List<ProductManufacturerMapping> FindAllProductManufacturerMappings()
        {
            return _thyMenaProductManufacturerMappingRepository.FindAllItems();
        }

        public void AddProductManufacturerMapping(ProductManufacturerMapping productManufacturerMapping)
        {
            _thyMenaProductManufacturerMappingRepository.Add(productManufacturerMapping);
            _thyMenaProductManufacturerMappingRepository.Save();
        }
    }
}
