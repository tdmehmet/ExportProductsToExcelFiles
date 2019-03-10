using System.Collections.Generic;

namespace ExportProductsToExcelFiles.AppModels
{
    public class Watch: ExcelProduct
    {
        public string WatchBandColour { get; set; }
        public string WatchBandColourFamily { get; set; }
        public string BandLength { get; set; }
        public string BandLengthUnit { get; set; }
        public string WatchBandMaterial { get; set; }
        public string WatchDial_FaceType { get; set; }
        public string Dial_FaceDiameter { get; set; }
        public string Dial_FaceDiameterUnit { get; set; }
        public string WatchDial_FaceColour { get; set; }
        public string WatchDial_FaceColourFamily { get; set; }
        public string WatchMovement { get; set; }
        public string WatchCaseShape { get; set; }
        public string WatchBandClosure { get; set; }
        public string InterchangeableDial_Face { get; set; }
        public string InterchangeableStrap { get; set; }
        public string WarrantyYears { get; set; }
    }
}
