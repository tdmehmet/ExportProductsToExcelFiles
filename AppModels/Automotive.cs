using System;
using System.Collections.Generic;
using System.Text;

namespace ExportProductsToExcelFiles.AppModels
{
    public class Automotive: ExcelProduct
    {
        public string ColourName { get; set; }
        public string ColourFamily { get; set; }
        public string Material { get; set; }
        public string ProductLength { get; set; }
        public string LengthUnit { get; set; }
        public string ProductHeight { get; set; }
        public string HeightUnit { get; set; }
        public string ProductWidthDepth { get; set; }
        public string WidthDepthUnit { get; set; }
        public string ProductWeight { get; set; }
        public string WeightUnit { get; set; }
        public string Capacity { get; set; }
        public string CapacityUnit { get; set; }
        public string NumberofPieces { get; set; }
    }
}
