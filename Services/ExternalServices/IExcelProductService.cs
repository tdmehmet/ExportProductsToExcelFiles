using ExportProductsToExcelFiles.AppModels;
using ExportProductsToExcelFiles.BiggBrands;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ExportProductsToExcelFiles.Services.ExternalServices
{
    public interface IExcelProductService
    {
        List<ExcelProduct> FindAllProductsFromExcelFile(FileInfo fileInfo);
        void GenerateExcelSheetfromExcelProductsByBrand(List<ExcelProduct> excelProducts, string brand);
    }
}
