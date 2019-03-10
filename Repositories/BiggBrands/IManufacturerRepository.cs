using ExportProductsToExcelFiles.BiggBrands;

namespace ExportProductsToExcelFiles.Repositories.BiggBrands
{
    public interface IManufacturerRepository : IGenericRepository<Manufacturer>
    {
        Manufacturer FindManufacturerByName(string manufacturerName);
    }
}
