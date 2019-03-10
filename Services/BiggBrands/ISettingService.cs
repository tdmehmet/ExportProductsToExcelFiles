using ExportProductsToExcelFiles.BiggBrands;

namespace ExportProductsToExcelFiles.Services.BiggBrands
{
    public interface ISettingService
    {
        Setting FindSettingByName(string settingName);
        decimal FindTaxCategoryFactorBySettingName(string settingName);
    }
}
