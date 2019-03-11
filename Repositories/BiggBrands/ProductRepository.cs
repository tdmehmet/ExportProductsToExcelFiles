using ExportProductsToExcelFiles.Config;
using ExportProductsToExcelFiles.BiggBrands;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using ExportProductsToExcelFiles.AppModels;

namespace ExportProductsToExcelFiles.Repositories.BiggBrands
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {

        public ProductRepository(BiggBrandsContext biggBrandsContext) : base(biggBrandsContext)
        {
        }

        public void SetProductsAsUpdatedFalse()
        {
            IQueryable<Product> products = from product in this._entities.Product
                        select product;
            this._entities.SaveChanges();
        }

        public bool ProductExistsOnDB(AppProduct appProduct) {
            return this._entities.Product.Where(item => item.Sku == appProduct.LogoKodu).FirstOrDefault() != null;

        }

        public List<Product> FindAllProducts()
        {
            return _entities.Product
                .Include(p => p.ProductPictureMapping)
                .ThenInclude(p => p.Picture)
                //.Include(p => p.ProductPictureMapping.Select(ppm => ppm.Picture))
                .Include(p => p.ProductManufacturerMapping)
                .ThenInclude(p => p.Manufacturer)
                //.Include(p => p.ProductManufacturerMapping.Select(pmm => pmm.Manufacturer))
                .Include(p => p.ProductCategoryMapping)
                .ThenInclude(p => p.Category)
                //.Include(p => p.ProductCategoryMapping.Select(pcm => pcm.Category))
                .Include(p=> p.ProductSpecificationAttributeMapping)
                .ToList();
        }

        public Product FindProductByLogoCode(string logoCode) {
            return this._entities.Product.Where(item => item.Sku == logoCode).FirstOrDefault();
        }


    }
}
