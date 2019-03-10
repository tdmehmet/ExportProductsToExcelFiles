using System.Collections.Generic;
using ExportProductsToExcelFiles.BiggBrands;

namespace ExportProductsToExcelFiles.Services.BiggBrands
{
    public interface IManufacturerService
    {
        Manufacturer AddManuFacturer(Manufacturer manufacturer);
        void InsertOrUpdateProductManufacturerMapping(Product product, string marka);
        List<Manufacturer> FindAllManufacturers();
    }
}
