using System.Collections.Generic;
using ExportProductsToExcelFiles.BiggBrands;

namespace ExportProductsToExcelFiles.Services.BiggBrands
{
    public interface ICategoryService
    {
        List<Category> FindAllCategories();
        void InsertOrUpdateCategoryProductMapping(Product product, int? categoryId);
    }
}
