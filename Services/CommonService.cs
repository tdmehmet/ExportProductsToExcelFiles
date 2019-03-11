using System;
using System.Linq;
using System.Collections.Generic;
using log4net;
using ExportProductsToExcelFiles.Services.ExternalServices;
using ExportProductsToExcelFiles.Services.BiggBrands;
using ExportProductsToExcelFiles.Utils;
using ExportProductsToExcelFiles.BiggBrands;
using ExportProductsToExcelFiles.AppModels;
using ExportProductsToExcelFiles.Services.SpecificationServices;
using ExportProductsToExcelFiles.Repositories.ExternalRepositories;
using System.IO;

namespace ExportProductsToExcelFiles.Services
{
    public class CommonService : ICommonService
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(CommonService));

        private readonly IAllExcelProductService _allExcelProductService;
        private readonly IProductService _productService;
        private readonly IUrlRecordService _urlRecordService;
        private readonly IPictureService _pictureService;
        private readonly IProductPictureMappingService _productPictureMappingService;
        private readonly ICategoryService _categoryService;
        private readonly IProductCategoryMappingService _productCategoryMappingService;
        private readonly ITaxCategoryService _taxCategoryService;
        private readonly IManufacturerService _manufacturerService;
        private readonly IProductManufacturerMappingService _productManufacturerMappingService;
        private readonly ISettingService _settingService;
        private readonly IProductWarehouseInventoryService _biggBrandsProductWarehouseInventoryService;
        private readonly IProductSpecificationAttributeMappingService _productSpecificationAttributeMappingService;
        private readonly ISpecificationAttributeOptionService _specificationAttributeOptionService;
        private readonly ISpecificationAttributeService _specificationAttributeService;
        private readonly IExcelProductRepository _excelProductRepository;

        public CommonService(
            IProductService productService,
            IUrlRecordService urlRecordService,
            IPictureService pictureService,
            ICategoryService categoryService,
            ITaxCategoryService taxCategoryService,
            IManufacturerService manufacturerService,
            IProductManufacturerMappingService productManufacturerMappingService,
            IProductPictureMappingService productPictureMappingService,
            IProductCategoryMappingService productCategoryMappingService,
            ISettingService settingService,
            IProductWarehouseInventoryService biggBrandsProductWarehouseInventoryService,
            IProductSpecificationAttributeMappingService productSpecificationAttributeMappingService,
            ISpecificationAttributeOptionService specificationAttributeOptionService,
            ISpecificationAttributeService specificationAttributeService,            
            IAllExcelProductService allExcelProductService,
            IExcelProductRepository excelProductRepository
            )
        {
            _productService = productService;
            _urlRecordService = urlRecordService;
            _pictureService = pictureService;
            _productPictureMappingService = productPictureMappingService;
            _categoryService = categoryService;
            _productCategoryMappingService = productCategoryMappingService;
            _taxCategoryService = taxCategoryService;
            _manufacturerService = manufacturerService;
            _productManufacturerMappingService = productManufacturerMappingService;
            _settingService = settingService;
            _biggBrandsProductWarehouseInventoryService = biggBrandsProductWarehouseInventoryService;
            _productSpecificationAttributeMappingService = productSpecificationAttributeMappingService;
            _specificationAttributeOptionService = specificationAttributeOptionService;
            _specificationAttributeService = specificationAttributeService;
            _allExcelProductService = allExcelProductService;
            _excelProductRepository = excelProductRepository;

        }

        public void ExportProductsToExcelFilesByBrands(AppConfiguration appConfiguration)
        {
            string[] brands = appConfiguration.Brands.Split(";");
            log.Info("Getting List of Products for Brand  from Nop DB");
            GenericService.products = _productService.FindAllProducts();
            log.Info("List of Products from Nop DB are Gathered");
            log.Info("Getting List of Specification Attribute Values from Nop DB");
            SpecificationAttributeOptionUtil.specificationAttributes = _specificationAttributeService.FindAllSpecificationAttributes();
            log.Info("List of Specification Attributes from Nop DB are Gathered");

            log.Info("Getting List of Specification Attribute Option Values from Nop DB");
            SpecificationAttributeOptionUtil.specificationAttributeOptions = _specificationAttributeOptionService.FindAllSpecificationAttributeOptions();
            log.Info("List of Specification Attribute Options from Nop DB are Gathered");


            foreach (string brand in brands) {

                

                _allExcelProductService.ExportProductsToExcelFilesByBrands(brand);
            }
        }

    }
}
