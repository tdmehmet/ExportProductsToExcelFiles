using ExportProductsToExcelFiles.BiggBrands;
using ExportProductsToExcelFiles.Config;
using ExportProductsToExcelFiles.Repositories.BiggBrands;
using System.Linq;

namespace ExportProductsToExcelFiles.Repositories.BiggBrands
{
    public class ProductWarehouseInventoryRepository : GenericRepository<ProductWarehouseInventory>, IProductWarehouseInventoryRepository
    {
        public ProductWarehouseInventoryRepository(BiggBrandsContext biggBrandsProductDBContext) : base(biggBrandsProductDBContext)
        {
        }

        public ProductWarehouseInventory FindProductWarehouseInventoryByProductIdWarehouseId(int productId, int warehouseId)
        {
            return _entities.ProductWarehouseInventory.Where(pwi => pwi.ProductId == productId && 
                        pwi.WarehouseId == warehouseId).FirstOrDefault();
        }
    }
}
