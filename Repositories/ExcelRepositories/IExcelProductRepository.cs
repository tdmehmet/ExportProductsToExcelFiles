using ExportProductsToExcelFiles.AppModels;
using System.Collections.Generic;
using System.IO;

namespace ExportProductsToExcelFiles.Repositories.ExternalRepositories
{
    public interface IExcelProductRepository
    {
        List<ExcelProduct> FindAllExcelProducts(FileInfo fileInfo);
        void GenerateExcelSheetfromExcelProductsByBrand(List<ExcelProduct> excelProducts, string brand);
    }
}
