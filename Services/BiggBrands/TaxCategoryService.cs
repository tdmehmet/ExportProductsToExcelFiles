using System;
using System.Collections.Generic;
using ExportProductsToExcelFiles.Repositories.BiggBrands;
using ExportProductsToExcelFiles.BiggBrands;

namespace ExportProductsToExcelFiles.Services.BiggBrands
{
    public class TaxCategoryService : ITaxCategoryService
    {
        private readonly ITaxCategoryRepository _thyMenaTaxCategoryRepository;
        
        public TaxCategoryService(ITaxCategoryRepository thyMenaTaxCategoryRepository
                                     )
        {
            _thyMenaTaxCategoryRepository = thyMenaTaxCategoryRepository;
        }

        public List<TaxCategory> FindAllTaxCategories()
        {
            return _thyMenaTaxCategoryRepository.FindAllItems();
        }

    }
}
