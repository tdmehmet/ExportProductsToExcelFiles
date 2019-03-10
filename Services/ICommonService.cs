using ExportProductsToExcelFiles.AppModels;

namespace ExportProductsToExcelFiles.Services
{
    public interface ICommonService
    {
        void ExportProductsToExcelFilesByBrands(AppConfiguration appConfiguration);
    }
}
