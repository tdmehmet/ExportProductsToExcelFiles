using System;
using System.Linq;
using System.Collections.Generic;
using log4net;
using ExportProductsToExcelFiles.Services.ExternalServices;
using ExportProductsToExcelFiles.Services.BiggBrands;
using ExportProductsToExcelFiles.Utils;
using ExportProductsToExcelFiles.BiggBrands;
using ExportProductsToExcelFiles.AppModels;
using System.IO;

namespace ExportProductsToExcelFiles.Services.SpecificationServices
{
    public class AllExcelProductService : GenericService, IAllExcelProductService
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(CommonService));

        private readonly IExcelProductService _excelProductService;
        private readonly IProductService _productService;
        private readonly IManufacturerService _manufacturerService;
        private readonly IProductPictureMappingService _productPictureMappingService;

        public AllExcelProductService(IExcelProductService excelProductService,
            IManufacturerService manufacturerService,
            IProductService productService,
            IProductPictureMappingService productPictureMappingService)
        {
            _excelProductService = excelProductService;
            _productService = productService;
            _manufacturerService = manufacturerService;
            _productPictureMappingService = productPictureMappingService;
        }

        public void ExportProductsToExcelFilesByBrands(string brand)
        {
            List<ExcelProduct> excelProducts = new List<ExcelProduct>();
            foreach (Product product in products)
            {
                log.Info("Product " + product.Sku + "is being processed ");
                ExcelProduct excelProduct = ExcelProductUtil.GenerateExcelProductFromProduct(product);
                excelProducts.Add(excelProduct);
            }

        }

    }
}
