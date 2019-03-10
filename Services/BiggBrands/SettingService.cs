using ExportProductsToExcelFiles.Repositories.BiggBrands;
using ExportProductsToExcelFiles.BiggBrands;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExportProductsToExcelFiles.Services.BiggBrands
{
    public class SettingService : ISettingService
    {
        private readonly ISettingRepository _settingRepository;

        public SettingService(ISettingRepository settingRepository)
        {
            _settingRepository = settingRepository;
        }
        public Setting FindSettingByName(string settingName)
        {
            return _settingRepository.FindSettingByName(settingName);
        }

        public decimal FindTaxCategoryFactorBySettingName(string settingName)
        {
            decimal settingValue = decimal.Parse(_settingRepository.FindSettingByName(settingName).Value, System.Globalization.CultureInfo.InvariantCulture);

            return 1 + (settingValue / 100);
        }
    }
}
