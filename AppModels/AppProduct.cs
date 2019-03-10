using System;
using Newtonsoft.Json.Linq;

namespace ExportProductsToExcelFiles.AppModels
{
    public class AppProduct
    {
        public string Name { get; set; }
        public string LogoKodu { get; set; }
        public string KatalogKodu { get; set; }
        public int CategoryID { get; set; }
        public string Marka { get; set; }
        public int Stok { get; set; }
        public string GTIN { get; set; }
        public string BulletPoint1 { get; set; }
        public string BulletPoint2 { get; set; }
        public string BulletPoint3 { get; set; }
        public string BulletPoint4 { get; set; }
        public string BulletPoint5 { get; set; }
    }
}
