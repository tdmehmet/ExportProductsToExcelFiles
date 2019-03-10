
using ExportProductsToExcelFiles.BiggBrands;

namespace ExportProductsToExcelFiles.Repositories.BiggBrands
{
    public interface IProductWarehouseInventoryRepository : IGenericRepository<ProductWarehouseInventory>
    {
        ProductWarehouseInventory FindProductWarehouseInventoryByProductIdWarehouseId(int productId, int warehouseId);
    }
}
