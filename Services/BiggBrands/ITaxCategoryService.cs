using System;
using System.Collections.Generic;
using ExportProductsToExcelFiles.BiggBrands;

namespace ExportProductsToExcelFiles.Services.BiggBrands
{
    public interface ITaxCategoryService
    {
        List<TaxCategory> FindAllTaxCategories();        
    }
}
