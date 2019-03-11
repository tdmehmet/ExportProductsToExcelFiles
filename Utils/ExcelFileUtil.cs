using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using ExportProductsToExcelFiles.BiggBrands;
using System.Linq;
using System.Collections.Generic;
using System.IO;
using System;
using System.Data;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using ExportProductsToExcelFiles.AppModels;

namespace ExportProductsToExcelFiles.Utils
{
    public static class ExcelFileUtil
    {
        private static string GenerateExcelFileName()
        {
            return @"C:\WinServices\exportProducts\ExcelFiles\Excel_" +
                DateTime.Today.Year + "-" + DateTime.Today.Month + "-" +
                DateTime.Today.Day +".xlsx";
        }

        public static void CreateSpreadSheetDocument(string brand)
        {
            string excelFileName = GenerateExcelFileName();
            if (!File.Exists(excelFileName))
            {
                // Create a spreadsheet document by supplying the filepath.
                // By default, AutoSave = true, Editable = true, and Type = xlsx.
                SpreadsheetDocument spreadsheetDocument = SpreadsheetDocument.
                    Create(GenerateExcelFileName(), SpreadsheetDocumentType.Workbook);

                // Add a WorkbookPart to the document.
                WorkbookPart workbookpart = spreadsheetDocument.AddWorkbookPart();
                workbookpart.Workbook = new Workbook();

                // Add a WorksheetPart to the WorkbookPart.
                WorksheetPart worksheetPart = workbookpart.AddNewPart<WorksheetPart>();
                worksheetPart.Worksheet = new Worksheet(new SheetData());

                

                workbookpart.Workbook.Save();

                // Close the document.
                spreadsheetDocument.Close();
            }

        }

        public static void CreateSheetIfNotExists(string brand)
        {
            SpreadsheetDocument spreadsheetDocument = SpreadsheetDocument.Open(GenerateExcelFileName(), true);
            if(spreadsheetDocument.WorkbookPart.Workbook.Sheets == null ) {
                 Sheets sheets = spreadsheetDocument.WorkbookPart.Workbook.
                        AppendChild<Sheets>(new Sheets());
                if(spreadsheetDocument.WorkbookPart.Workbook.Descendants<Sheet>().Where(s => s.Name == brand).FirstOrDefault() == null)
                {
                   

                    // Append a new worksheet and associate it with the workbook.
                    Sheet sheet = new Sheet()
                    {
                        Id = spreadsheetDocument.WorkbookPart.
                        GetIdOfPart(spreadsheetDocument.WorkbookPart.WorksheetParts.FirstOrDefault()),
                        SheetId = 1,
                        Name = brand
                    };
                    sheets.Append(sheet);

                    spreadsheetDocument.WorkbookPart.Workbook.Save();

                }
            }
            spreadsheetDocument.Close();
        }

        public static void CreateSheetColumns(string brand)
        {
            SpreadsheetDocument spreadsheetDocument = SpreadsheetDocument.Open(GenerateExcelFileName(), true);
            Sheet brandSheet = spreadsheetDocument.WorkbookPart.Workbook.Descendants<Sheet>().Single(s => s.Name == brand);
            
            if (brandSheet != null)
            {
                Worksheet brandWorkSheet = ((WorksheetPart)spreadsheetDocument.WorkbookPart.GetPartById(brandSheet.Id)).Worksheet;

                Columns brandSheetColumns = brandWorkSheet.Elements<Columns>().FirstOrDefault();

                if ((brandSheetColumns == null))
                {
                    // If Columns appended to worksheet after sheetdata Excel will throw an error.
                    SheetData sd = brandWorkSheet.Elements<SheetData>().FirstOrDefault();
                    
                }


            }
            spreadsheetDocument.Close();
        }

        public static void CreateExcelSheet(string brand, List<ExcelProduct> excelProducts)
        {
            

            DataTable dtCodes = new DataTable();
            dtCodes.Clear();

            foreach (SpecificationAttribute specificationAttribute in SpecificationAttributeOptionUtil.specificationAttributes)
            {
                
                dtCodes.Columns.Add(specificationAttribute.Name);
            }

            foreach(ExcelProduct excelProduct in excelProducts)
            {
                DataRow dr = dtCodes.NewRow();
                foreach(SpecificationAttribute specificationAttribute in SpecificationAttributeOptionUtil.specificationAttributes)
                {
                    dr[specificationAttribute.Name] = ExcelProductUtil.FindSpecificationAttributeValue(specificationAttribute.Name, excelProduct);
                }
                dtCodes.Rows.Add(dr);
            }

            FileInfo file = new FileInfo(GenerateExcelFileName());
            if(file.Exists) { 
                ExcelPackage pck = new ExcelPackage(file);
                ExcelWorksheet ws = null;
                ws = pck.Workbook.Worksheets.Add(brand);
                ws.Cells["A1"].LoadFromDataTable(dtCodes, true);
                ws.Row(1).Style.Font.Bold = true;
                ws.Row(1).Style.Fill.PatternType = ExcelFillStyle.Solid;
                ws.Row(1).Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.Yellow);                
                pck.Save();
            }else
            {
                ExcelPackage pck = new ExcelPackage();
                ExcelWorksheet ws = null;
                ws = pck.Workbook.Worksheets.Add(brand);
                ws.Cells["A1"].LoadFromDataTable(dtCodes, true);
                ws.Row(1).Style.Font.Bold = true;
                ws.Row(1).Style.Fill.PatternType = ExcelFillStyle.Solid;
                ws.Row(1).Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.Yellow);
                File.WriteAllBytes(GenerateExcelFileName(), pck.GetAsByteArray());
            }


        }

        private static Cell ConstructCell(string value, CellValues dataType)
        {
            return new Cell()
            {
                CellValue = new CellValue(value),
                DataType = new EnumValue<CellValues>(dataType)
            };
        }
    }
}
