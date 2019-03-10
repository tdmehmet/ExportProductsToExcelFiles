using System.Linq;
using ExportProductsToExcelFiles.Config;
using ExportProductsToExcelFiles.BiggBrands;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace ExportProductsToExcelFiles.Repositories.BiggBrands
{
    public class ProductCategoryMappingRepository : GenericRepository<ProductCategoryMapping>, IProductCategoryMappingRepository
    {
        public ProductCategoryMappingRepository(BiggBrandsContext biggBrandsContext) : base(biggBrandsContext)
        {
        }

        public ProductCategoryMapping FindByProductIdCategoryId(int productId, int categoryId) {
            return this._entities.ProductCategoryMapping.Where(productCategoryMapping =>
                                                               productCategoryMapping.ProductId == productId &&
                                                               productCategoryMapping.CategoryId == categoryId).FirstOrDefault();
        }
        public ProductCategoryMapping FindByProductIdNoXmlUpdateIsUpdated(int productId, bool noXmlUpdate, bool isUpdated) {
           return (from pcm in _entities.ProductCategoryMapping
                    join c in _entities.Category on pcm.CategoryId equals c.Id
                    where pcm.ProductId == productId
                    select pcm).FirstOrDefault();
        }

        public List<ProductCategoryMapping> FindAllProductCategoryMappings()
        {
            return this._entities.ProductCategoryMapping.Include(p => p.Category).Include(p => p.Product).ToList();
        }
    }
}
