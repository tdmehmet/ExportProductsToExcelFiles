using System.Linq;
using System.Collections.Generic;
using ExportProductsToExcelFiles.BiggBrands;

namespace ExportProductsToExcelFiles.Utils
{
    public static class ProductWarehouseInventoryUtil
    {
        public static ProductWarehouseInventory GenerateProductWarehouseInventoryForUpdate(int productId, 
            int warehouseId, int? stok, List<ProductWarehouseInventory> productWarehouseInventories)
        {
            ProductWarehouseInventory productWarehouseInventory = productWarehouseInventories.Where(
                pwi => pwi.ProductId == productId && pwi.WarehouseId == warehouseId).FirstOrDefault();
            if(productWarehouseInventory == null)
            {
                return null;
            }else
            {
                productWarehouseInventory.StockQuantity = stok ?? 0;
            }
            return productWarehouseInventory;
        }

        public static ProductWarehouseInventory GenerateProductWarehouseInventoryForInsert(int productId,
           int warehouseId, int? stok)
        {
            return new ProductWarehouseInventory()
            {
                ProductId = productId,
                StockQuantity = stok ?? 0,
                WarehouseId = warehouseId,
                ReservedQuantity = 0
            };
        }

    }
}
