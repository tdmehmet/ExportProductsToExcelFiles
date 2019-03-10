using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using ExportProductsToExcelFiles.BiggBrands;
using System.Linq;
using System.Collections.Generic;
using System.IO;
using System;

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
            bool sheetExists = false;
            if(spreadsheetDocument.WorkbookPart.Workbook.Sheets != null) { 
                foreach(Sheet sheet in spreadsheetDocument.WorkbookPart.Workbook.Sheets)
                {
                    if(sheet.Name == brand)
                    {
                        sheetExists = true;
                        break;
                    }
                }
            }
            if (!sheetExists)
            {
                Sheets sheets = spreadsheetDocument.WorkbookPart.Workbook.
                   AppendChild<Sheets>(new Sheets());

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

                // Close the document.
                spreadsheetDocument.Close();
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
