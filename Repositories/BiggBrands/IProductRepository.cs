using ExportProductsToExcelFiles.AppModels;
using ExportProductsToExcelFiles.BiggBrands;
using System.Collections.Generic;

namespace ExportProductsToExcelFiles.Repositories.BiggBrands
{
    public interface IProductRepository: IGenericRepository<Product>
    {
        void SetProductsAsUpdatedFalse();
        bool ProductExistsOnDB(AppProduct appProduct);
        Product FindProductByLogoCode(string logoCode);
        List<Product> FindAllProducts();
    }
}
