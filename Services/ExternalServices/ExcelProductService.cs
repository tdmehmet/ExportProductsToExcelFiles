using ExportProductsToExcelFiles.Repositories.ExternalRepositories;
using System.Collections.Generic;
using ExportProductsToExcelFiles.AppModels;
using System.IO;

namespace ExportProductsToExcelFiles.Services.ExternalServices
{
    public class ExcelProductService : IExcelProductService
    {
        private readonly IExcelProductRepository _excelProductRepository;
        

        public ExcelProductService(IExcelProductRepository excelProductRepository)
        {
            _excelProductRepository = excelProductRepository;
        }

        public List<ExcelProduct> FindAllProductsFromExcelFile(FileInfo fileInfo)
        {
            return _excelProductRepository.FindAllExcelProducts(fileInfo);
        }

        public void GenerateExcelSheetfromExcelProductsByBrand(List<ExcelProduct> excelProducts, string brand)
        {
            _excelProductRepository.GenerateExcelSheetfromExcelProductsByBrand(excelProducts, brand);
        }
    }
}
