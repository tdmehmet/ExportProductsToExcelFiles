using ExportProductsToExcelFiles.BiggBrands;
using System.Collections.Generic;

namespace ExportProductsToExcelFiles.Services.SpecificationServices
{
    
    public abstract class GenericService
    {
        public static List<Product> products;
        public static List<Manufacturer> manufacturers;
        public static List<ProductCategoryMapping> productCategoryMappings;
        public static List<ProductManufacturerMapping> productManufacturerMappings;
        public static List<ProductPictureMapping> productPictureMappings;
        public static List<Category> categories;
        public static List<Picture> pictures;
    }
}
