using System;
using System.Collections.Generic;
using ExportProductsToExcelFiles.BiggBrands;
using ExportProductsToExcelFiles.Repositories.BiggBrands;

namespace ExportProductsToExcelFiles.Services.BiggBrands
{
    public class CategoryService : ICategoryService
    {
        private readonly CategoryRepository _categoryRepository;
        private readonly IProductCategoryMappingRepository _productCategoryMappingRepository;

        public CategoryService( CategoryRepository categoryRepository,
                                IProductCategoryMappingRepository productCategoryMappingRepository)
        {
            _categoryRepository = categoryRepository;
            _productCategoryMappingRepository = productCategoryMappingRepository;
        }

        public List<Category> FindAllCategories()
        {
            return _categoryRepository.FindAllItems();
        }

        public void InsertOrUpdateCategoryProductMapping(Product product, int? categoryId) {
            Category category = _categoryRepository.FindCategoryById(categoryId ?? 0);
            category = category ?? _categoryRepository.FindCategoryByName("Other");
            ProductCategoryMapping productCategoryMapping =
                _productCategoryMappingRepository.FindByProductIdNoXmlUpdateIsUpdated(
                    product.Id, false, false
                );
            if (productCategoryMapping != null)
            {
                productCategoryMapping.CategoryId = category.Id;
                _productCategoryMappingRepository.Update(productCategoryMapping);
                _productCategoryMappingRepository.Save();
            }
            else
            {
                productCategoryMapping = _productCategoryMappingRepository.FindByProductIdCategoryId(
                    product.Id, category.Id);
                if (productCategoryMapping == null)
                {
                    _productCategoryMappingRepository.Add(new ProductCategoryMapping()
                    {
                        ProductId = product.Id,
                        CategoryId = category.Id,
                        IsFeaturedProduct = false,
                        DisplayOrder = 0
                    });
                    _productCategoryMappingRepository.Save();
                }
            }
        }
    }
}
