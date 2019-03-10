using System.Collections.Generic;
using ExportProductsToExcelFiles.Repositories.BiggBrands;
using ExportProductsToExcelFiles.BiggBrands;

namespace ExportProductsToExcelFiles.Services.BiggBrands
{
	public class ProductPictureMappingService : IProductPictureMappingService
    {
        private readonly IProductPictureMappingRepository _thyMenaProductPictureMappingRepository;
        
        public ProductPictureMappingService(
            IProductPictureMappingRepository thyMenaProductPictureMappingRepository
            )
        {
            _thyMenaProductPictureMappingRepository = thyMenaProductPictureMappingRepository;
        }

        public List<ProductPictureMapping> FindAllProductPictureMappings()
        {
            return _thyMenaProductPictureMappingRepository.FindAllItems();
        }

        public void AddProductPictureMappingRange(List<ProductPictureMapping> productPictureMappings)
        {
            _thyMenaProductPictureMappingRepository.AddRange(productPictureMappings);
            _thyMenaProductPictureMappingRepository.Save();
        }
    }
}
