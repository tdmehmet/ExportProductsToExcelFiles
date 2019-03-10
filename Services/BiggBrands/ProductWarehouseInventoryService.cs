using ExportProductsToExcelFiles.BiggBrands;
using ExportProductsToExcelFiles.Repositories.BiggBrands;
using System.Collections.Generic;

namespace ExportProductsToExcelFiles.Services.BiggBrands
{
    public class ProductWarehouseInventoryService : IProductWarehouseInventoryService
    {
        IProductWarehouseInventoryRepository _biggBrandsProductWarehouseInventoryRepository;
        public ProductWarehouseInventoryService(
            IProductWarehouseInventoryRepository biggBrandsProductWarehouseInventoryRepository)
        {
            _biggBrandsProductWarehouseInventoryRepository = biggBrandsProductWarehouseInventoryRepository;
        }

        public List<ProductWarehouseInventory> FindAllProductWarehouseInventories()
        {
            return _biggBrandsProductWarehouseInventoryRepository.FindAllItems();
        }

        public ProductWarehouseInventory FindProductWarehouseInventoryByProductIdWarehouseId(int productId, int warehouseId)
        {
            return _biggBrandsProductWarehouseInventoryRepository.FindProductWarehouseInventoryByProductIdWarehouseId(productId, warehouseId);
        }

        public void InsertProductWarehouseInventories(List<ProductWarehouseInventory> productWarehouseInventories)
        {
            _biggBrandsProductWarehouseInventoryRepository.AddRange(productWarehouseInventories);
            _biggBrandsProductWarehouseInventoryRepository.Save();
        }

        public void UpdateProductWarehouseInventories(List<ProductWarehouseInventory> productWarehouseInventories)
        {
            _biggBrandsProductWarehouseInventoryRepository.UpdateRange(productWarehouseInventories);
            _biggBrandsProductWarehouseInventoryRepository.Save();
        }
    }
}
