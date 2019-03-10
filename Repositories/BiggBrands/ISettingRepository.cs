using ExportProductsToExcelFiles.BiggBrands;

namespace ExportProductsToExcelFiles.Repositories.BiggBrands
{
    public interface ISettingRepository : IGenericRepository<Setting>
    {
        Setting FindSettingByName(string settingName);
    }

    
}
