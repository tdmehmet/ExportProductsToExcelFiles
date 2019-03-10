using System;
using System.Collections.Generic;
using System.Text;

namespace ExportProductsToExcelFiles.AppModels
{
    public class Apparel: ExcelProduct
    {
        public string SeasonCode { get; set; }
        public string Year { get; set; }
        public string StyleorPartNumber { get; set; }
        public string SportType { get; set; }
        public string StyleorPartName { get; set; }
        public string ColourName { get; set; }
        public string ColourFamily { get; set; }
        public string Size { get; set; }
        public string SizingStandard { get; set; }
        public string TargetAgeRange { get; set; }
        public string SpecialSizeType { get; set; }
        public string Material { get; set; }
        public string LiningMaterial { get; set; }
        public string Neckline { get; set; }
        public string SleeveType { get; set; }
        public string Fit { get; set; }
        public string Occasion { get; set; }
        public string SkirtDressLength { get; set; }
        public string WaistType { get; set; }
        public string BraSupport { get; set; }
        public string CareInstructions { get; set; }
        public string LongDescription { get; set; }
    }
}
