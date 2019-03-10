using Microsoft.Extensions.Configuration;
using ExportProductsToExcelFiles.AppModels;
using ExportProductsToExcelFiles.Services;
using System.Net;
using log4net;
using ExportProductsToExcelFiles.Services.BiggBrands;
using ExportProductsToExcelFiles.BiggBrands;
using System.Collections.Generic;

namespace ExportProductsToExcelFiles
{
    public class StartUp
    {
        private readonly ICommonService _commonService;
        private readonly ISMPictureService _smPictureService;
        private static readonly ILog log = LogManager.GetLogger(typeof(CommonService));
        public StartUp(ICommonService commonService,
            ISMPictureService smPictureService)
        {
            _commonService = commonService;
            _smPictureService = smPictureService;
        }

        public void Run(IConfiguration configuration) 
        {
            AppConfiguration appConfiguration = new AppConfiguration
            {
                Brands = configuration.GetValue<string>("AppConfiguration:Brands"),
            };
            
            _commonService.ExportProductsToExcelFilesByBrands(appConfiguration);
        }
    }
}
