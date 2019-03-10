using ExportProductsToExcelFiles.AppModels;
using System.IO;

namespace ExportProductsToExcelFiles.Services.SpecificationServices
{
    public interface IAllExcelProductService
    {
        void ExportProductsToExcelFilesByBrands(string brand);
    }
}
