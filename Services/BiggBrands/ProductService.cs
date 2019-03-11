using System.Linq;
using System.Collections.Generic;
using log4net;
using ExportProductsToExcelFiles.AppModels;
using ExportProductsToExcelFiles.Repositories.BiggBrands;
using ExportProductsToExcelFiles.BiggBrands;

namespace ExportProductsToExcelFiles.Services.BiggBrands
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly ITaxCategoryRepository _taxCategoryRepository;
        private readonly ISettingRepository _settingRepository;
        private static readonly ILog log = LogManager.GetLogger(typeof(CommonService));

        public ProductService(
            IProductRepository productRepository,
            ITaxCategoryRepository taxCategoryRepository,
            ISettingRepository settingRepository
            )
        {
            _productRepository = productRepository;
            _taxCategoryRepository = taxCategoryRepository;
            _settingRepository = settingRepository;
        }

        public void SetProductsAsUpdatedFalse()
        {
            ///TODO
        }

        public void UpdateProductRange(List<Product> products)
        {
            _productRepository.UpdateRange(products);
            _productRepository.Save();
        }

        public bool ProductExistsOnDB(AppProduct appProduct) {
            return _productRepository.ProductExistsOnDB(appProduct);
        }

        public Product AddProduct(Product product) {
            Product insertedProduct = _productRepository.Add(product);
            _productRepository.Save();
            return insertedProduct;
        }

        public void AddProductRange(List<Product> products)
        {
            _productRepository.AddRange(products);
            _productRepository.Save();
        }

        public Product FindProductByLogoCode(string logoCode) {
            return _productRepository.FindProductByLogoCode(logoCode);
        }

        public void UpdateProduct(Product product)
        {
            _productRepository.Update(product);
            _productRepository.Save();
        }

        public List<Product> FindAllProducts()
        {
            return _productRepository.FindAllProducts();
        }

        public List<Product> FindProductsByBrand(string brand)
        {
            return _productRepository.FindAllProducts().Where(p => p.ProductManufacturerMapping?.FirstOrDefault()?.Manufacturer.Name.ToUpper() == brand.ToUpper()).ToList();
        }
    }
}
