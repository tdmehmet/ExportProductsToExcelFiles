using ExportProductsToExcelFiles.BiggBrands;

namespace ExportProductsToExcelFiles.Repositories.BiggBrands
{
    public interface ITaxCategoryRepository : IGenericRepository<TaxCategory>
    {
        TaxCategory FindTaxCategoryByName(string name);
    }
}
