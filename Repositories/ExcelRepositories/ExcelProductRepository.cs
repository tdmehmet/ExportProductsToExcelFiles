using DocumentFormat.OpenXml.Packaging;
using ExportProductsToExcelFiles.AppModels;
using ExportProductsToExcelFiles.Utils;
using log4net;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text;

namespace ExportProductsToExcelFiles.Repositories.ExternalRepositories
{
    public class ExcelProductRepository : IExcelProductRepository
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(ExcelProductRepository));

        public ExcelProductRepository()
        {
        }

        public List<ExcelProduct> FindAllExcelProducts(FileInfo fileInfo)
        {
            List<ExcelProduct> excelProducts = new List<ExcelProduct>();
            try
            {
                string path = @"MyTest.txt";

                if (!File.Exists(path))
                {

                    File.CreateText(path);

                }
                using (ExcelPackage package = new ExcelPackage(fileInfo))
                {
                    ExcelWorksheet worksheet = package.Workbook.Worksheets[1];
                    
                    int rowCount = worksheet.Dimension.Rows;
                    int colCount = worksheet.Dimension.Columns;

                    DataTable dataTable = new DataTable();

                    for(int column = 1; column <= colCount; column++)
                    {
                        dataTable.Columns.Add(worksheet.Cells[1, column]?.Value?.ToString());
                    }

                    for (int row = 2; row <= rowCount; row++)
                    {
                        DataRow newRow = dataTable.NewRow();
                        for(int column = 1; column <= colCount; column++) {
                            try { 
                                newRow[dataTable.Columns[column - 1]] = worksheet.Cells[row, column]?.Value?.ToString();
                                
                            }catch(Exception)
                            {

                            }
                        }
                        dataTable.Rows.Add(newRow);
                    }
                    
                    foreach(DataRow dataRow in dataTable.Rows)
                    {
                        
                        ExcelProduct excelProduct = new ExcelProduct();
                        excelProduct.GTIN = dataRow.Table.Columns.Contains("GTIN") ? dataRow["GTIN"]?.ToString() : null;
                        excelProduct.SeasonCode = dataRow.Table.Columns.Contains("Season Code") ? dataRow["Season Code"]?.ToString() : null;
                        excelProduct.Year = dataRow.Table.Columns.Contains("Year") ? dataRow["Year"]?.ToString() : null;
                        excelProduct.StyleorPartNumber = dataRow.Table.Columns.Contains("Style or Part Number") ? dataRow["Style or Part Number"]?.ToString() : null;
                        excelProduct.PartnerSKUUnique = dataRow.Table.Columns.Contains("Partner SKU Unique") ? dataRow["Partner SKU Unique"]?.ToString() : null;
                        using (StreamWriter sw = File.AppendText(path))
                        {
                            sw.WriteLine(excelProduct.PartnerSKUUnique);
                            sw.Flush();
                        }
                        excelProduct.ParentSKU = dataRow.Table.Columns.Contains("Parent SKU") ? dataRow["Parent SKU"]?.ToString() : null;
                        excelProduct.BrandName = dataRow.Table.Columns.Contains("Brand Name") ? dataRow["Brand Name"]?.ToString() : null;
                        excelProduct.ProductTitle = dataRow.Table.Columns.Contains("Product Title") ? dataRow["Product Title"]?.ToString() : null;
                        excelProduct.Department = dataRow.Table.Columns.Contains("Department") ? dataRow["Department"]?.ToString() : null;
                        excelProduct.ProductType = dataRow.Table.Columns.Contains("Product Type") ? dataRow["Product Type"]?.ToString() : null;
                        excelProduct.ProductSubtype = dataRow.Table.Columns.Contains("Product Subtype") ? dataRow["Product Subtype"]?.ToString() : null;
                        excelProduct.SportType = dataRow.Table.Columns.Contains("Sport Type") ? dataRow["Sport Type"]?.ToString() : null;
                        excelProduct.CountryofOrigin = dataRow.Table.Columns.Contains("Country of Origin") ? dataRow["Country of Origin"]?.ToString() : null;
                        excelProduct.StyleorPartName = dataRow.Table.Columns.Contains("Style or Part Name") ? dataRow["Style or Part Name"]?.ToString() : null;
                        excelProduct.ColourName = dataRow.Table.Columns.Contains("Colour Name") ? dataRow["Colour Name"]?.ToString() : null;
                        excelProduct.ColourFamily = dataRow.Table.Columns.Contains("Colour Family") ? dataRow["Colour Family"]?.ToString() : null;
                        excelProduct.Size = dataRow.Table.Columns.Contains("Size") ? dataRow["Size"]?.ToString() : null;
                        excelProduct.SizingStandard = dataRow.Table.Columns.Contains("Sizing Standard") ? dataRow["Sizing Standard"]?.ToString() : null;
                        excelProduct.TargetAgeRange = dataRow.Table.Columns.Contains("Target Age Range") ? dataRow["Target Age Range"]?.ToString() : null;
                        excelProduct.SpecialSizeType = dataRow.Table.Columns.Contains("Special Size Type") ? dataRow["Special Size Type"]?.ToString() : null;
                        excelProduct.Material = dataRow.Table.Columns.Contains("Material") ? dataRow["Material"]?.ToString() : null;
                        excelProduct.LiningMaterial = dataRow.Table.Columns.Contains("Lining Material") ? dataRow["Lining Material"]?.ToString() : null;
                        excelProduct.Neckline = dataRow.Table.Columns.Contains("Neckline") ? dataRow["Neckline"]?.ToString() : null;
                        excelProduct.SleeveType = dataRow.Table.Columns.Contains("Sleeve Type") ? dataRow["Sleeve Type"]?.ToString() : null;
                        excelProduct.Fit = dataRow.Table.Columns.Contains("Fit") ? dataRow["Fit"]?.ToString() : null;
                        excelProduct.Occasion = dataRow.Table.Columns.Contains("Occasion") ? dataRow["Occasion"]?.ToString() : null;
                        excelProduct.SkirtDressLength = dataRow.Table.Columns.Contains("Skirt/Dress Length") ? dataRow["Skirt/Dress Length"]?.ToString() : null;
                        excelProduct.WaistType = dataRow.Table.Columns.Contains("Waist Type") ? dataRow["Waist Type"]?.ToString() : null;
                        excelProduct.BraSupport = dataRow.Table.Columns.Contains("Bra Support") ? dataRow["Bra Support"]?.ToString() : null;
                        excelProduct.CareInstructions = dataRow.Table.Columns.Contains("Care Instructions") ? dataRow["Care Instructions"]?.ToString() : null;
                        excelProduct.AttributeKey1 = dataRow.Table.Columns.Contains("Attribute Key 1") ? dataRow["Attribute Key 1"]?.ToString() : null;
                        excelProduct.AttributeValue1 = dataRow.Table.Columns.Contains("Attribute Value 1") ? dataRow["Attribute Value 1"]?.ToString() : null;
                        excelProduct.AttributeKey2 = dataRow.Table.Columns.Contains("Attribute Key 2") ? dataRow["Attribute Key 2"]?.ToString() : null;
                        excelProduct.AttributeValue2 = dataRow.Table.Columns.Contains("Attribute Value 2") ? dataRow["Attribute Value 2"]?.ToString() : null;
                        excelProduct.AttributeKey3 = dataRow.Table.Columns.Contains("Attribute Key 3") ? dataRow["Attribute Key 3"]?.ToString() : null;
                        excelProduct.AttributeValue3 = dataRow.Table.Columns.Contains("Attribute Value 3") ? dataRow["Attribute Value 3"]?.ToString() : null;
                        excelProduct.AttributeKey4 = dataRow.Table.Columns.Contains("Attribute Key 4") ? dataRow["Attribute Key 4"]?.ToString() : null;
                        excelProduct.AttributeValue4 = dataRow.Table.Columns.Contains("Attribute Value 4") ? dataRow["Attribute Value 4"]?.ToString() : null;
                        excelProduct.AttributeKey5 = dataRow.Table.Columns.Contains("Attribute Key 5") ? dataRow["Attribute Key 5"]?.ToString() : null;
                        excelProduct.AttributeValue5 = dataRow.Table.Columns.Contains("Attribute Value 5") ? dataRow["Attribute Value 5"]?.ToString() : null;
                        excelProduct.LongDescription = dataRow.Table.Columns.Contains("Long Description") ? dataRow["Long Description"]?.ToString() : null;
                        excelProduct.FeatureBullet1 = dataRow.Table.Columns.Contains("Feature/Bullet 1") ? dataRow["Feature/Bullet 1"]?.ToString() : null;
                        excelProduct.FeatureBullet2 = dataRow.Table.Columns.Contains("Feature/Bullet 2") ? dataRow["Feature/Bullet 2"]?.ToString() : null;
                        excelProduct.FeatureBullet3 = dataRow.Table.Columns.Contains("Feature/Bullet 3") ? dataRow["Feature/Bullet 3"]?.ToString() : null;
                        excelProduct.FeatureBullet4 = dataRow.Table.Columns.Contains("Feature/Bullet 4") ? dataRow["Feature/Bullet 4"]?.ToString() : null;
                        excelProduct.FeatureBullet5 = dataRow.Table.Columns.Contains("Feature/Bullet 5") ? dataRow["Feature/Bullet 5"]?.ToString() : null;
                        excelProduct.ImageURL1 = dataRow.Table.Columns.Contains("Image URL 1") ? dataRow["Image URL 1"]?.ToString() : null;
                        excelProduct.ImageURL2 = dataRow.Table.Columns.Contains("Image URL 2") ? dataRow["Image URL 2"]?.ToString() : null;
                        excelProduct.ImageURL3 = dataRow.Table.Columns.Contains("Image URL 3") ? dataRow["Image URL 3"]?.ToString() : null;
                        excelProduct.ImageURL4 = dataRow.Table.Columns.Contains("Image URL 4") ? dataRow["Image URL 4"]?.ToString() : null;
                        excelProduct.ImageURL5 = dataRow.Table.Columns.Contains("Image URL 5") ? dataRow["Image URL 5"]?.ToString() : null;
                        excelProduct.ImageURL6 = dataRow.Table.Columns.Contains("Image URL 6") ? dataRow["Image URL 6"]?.ToString() : null;
                        excelProduct.ImageURL7 = dataRow.Table.Columns.Contains("Image URL 7") ? dataRow["Image URL 7"]?.ToString() : null;
                        excelProduct.ShippingLengthcm = dataRow.Table.Columns.Contains("Shipping Length (cm)") ? dataRow["Shipping Length (cm)"]?.ToString() : null;
                        excelProduct.ShippingHeightcm = dataRow.Table.Columns.Contains("Shipping Height (cm)") ? dataRow["Shipping Height (cm)"]?.ToString() : null;
                        excelProduct.ShippingWidthDepthcm = dataRow.Table.Columns.Contains("Shipping Width/Depth (cm)") ? dataRow["Shipping Width/Depth (cm)"]?.ToString() : null;
                        excelProduct.ShippingWeightKG = dataRow.Table.Columns.Contains("Shipping Weight (KG)") ? dataRow["Shipping Weight (KG)"]?.ToString() : null;
                        excelProduct.ShippingDestination = dataRow.Table.Columns.Contains("Shipping Destination") ? dataRow["Shipping Destination"]?.ToString() : null;
                        excelProduct.QuantityStock = dataRow.Table.Columns.Contains("Quantity/Stock") ? dataRow["Quantity/Stock"]?.ToString() : null;
                        excelProduct.FulfilmentMethod = dataRow.Table.Columns.Contains("Fulfilment Method") ? dataRow["Fulfilment Method"]?.ToString() : null;
                        excelProduct.ProcessingTime = dataRow.Table.Columns.Contains("Processing Time") ? dataRow["Processing Time"]?.ToString() : null;
                        excelProduct.MSRPAE = dataRow.Table.Columns.Contains("MSRP AE") ? dataRow["MSRP AE"]?.ToString() : null;
                        excelProduct.MSRPSA = dataRow.Table.Columns.Contains("MSRP SA") ? dataRow["MSRP SA"]?.ToString() : null;
                        excelProduct.MSRPEG = dataRow.Table.Columns.Contains("MSRP EG") ? dataRow["MSRP EG"]?.ToString() : null;
                        excelProduct.CostAED = dataRow.Table.Columns.Contains("Cost (AED)") ? dataRow["Cost (AED)"]?.ToString() : null;
                        excelProduct.SellingPriceAED = dataRow.Table.Columns.Contains("Selling Price (AED)") ? dataRow["Selling Price (AED)"]?.ToString() : null;
                        excelProduct.SellingPriceSAR = dataRow.Table.Columns.Contains("Selling Price (SAR)") ? dataRow["Selling Price (SAR)"]?.ToString() : null;
                        excelProduct.SellingPriceEGP = dataRow.Table.Columns.Contains("Selling Price (EGP)") ? dataRow["Selling Price (EGP)"]?.ToString() : null;
                        excelProduct.PromotionalPriceAED = dataRow.Table.Columns.Contains("Promotional Price (AED)") ? dataRow["Promotional Price (AED)"]?.ToString() : null;
                        excelProduct.PromotionalPriceSAR = dataRow.Table.Columns.Contains("Promotional Price (SAR)") ? dataRow["Promotional Price (SAR)"]?.ToString() : null;
                        excelProduct.PromotionalPriceEGP = dataRow.Table.Columns.Contains("Promotional Price (EGP)") ? dataRow["Promotional Price (EGP)"]?.ToString() : null;
                        excelProduct.HSCode = dataRow.Table.Columns.Contains("HS Code") ? dataRow["HS Code"]?.ToString() : null;
                        excelProduct.ModelNumber = dataRow.Table.Columns.Contains("Model Number") ? dataRow["Model Number"]?.ToString() : null;
                        excelProduct.ModelName = dataRow.Table.Columns.Contains("Model Name") ? dataRow["Model Name"]?.ToString() : null;
                        excelProduct.ProductLength = dataRow.Table.Columns.Contains("Product Length") ? dataRow["Product Length"]?.ToString() : null;
                        excelProduct.LengthUnit = dataRow.Table.Columns.Contains("Length Unit") ? dataRow["Length Unit"]?.ToString() : null;
                        excelProduct.ProductHeight = dataRow.Table.Columns.Contains("Product Height") ? dataRow["Product Height"]?.ToString() : null;
                        excelProduct.HeightUnit = dataRow.Table.Columns.Contains("Height Unit") ? dataRow["Height Unit"]?.ToString() : null;
                        excelProduct.ProductWidthDepth = dataRow.Table.Columns.Contains("Product Width/Depth") ? dataRow["Product Width/Depth"]?.ToString() : null;
                        excelProduct.WidthDepthUnit = dataRow.Table.Columns.Contains("Width/Depth Unit") ? dataRow["Width/Depth Unit"]?.ToString() : null;
                        excelProduct.ProductWeight = dataRow.Table.Columns.Contains("Product Weight") ? dataRow["Product Weight"]?.ToString() : null;
                        excelProduct.WeightUnit = dataRow.Table.Columns.Contains("Weight Unit") ? dataRow["Weight Unit"]?.ToString() : null;
                        excelProduct.Capacity = dataRow.Table.Columns.Contains("Capacity") ? dataRow["Capacity"]?.ToString() : null;
                        excelProduct.CapacityUnit = dataRow.Table.Columns.Contains("Capacity Unit") ? dataRow["Capacity Unit"]?.ToString() : null;
                        excelProduct.NumberofPieces = dataRow.Table.Columns.Contains("Number of Pieces") ? dataRow["Number of Pieces"]?.ToString() : null;
                        excelProduct.SizeUnit = dataRow.Table.Columns.Contains("Size Unit") ? dataRow["Size Unit"]?.ToString() : null;
                        excelProduct.ExteriorMaterial = dataRow.Table.Columns.Contains("Exterior Material") ? dataRow["Exterior Material"]?.ToString() : null;
                        excelProduct.InteriorMaterial = dataRow.Table.Columns.Contains("Interior Material") ? dataRow["Interior Material"]?.ToString() : null;
                        excelProduct.StrapMaterial = dataRow.Table.Columns.Contains("Strap Material") ? dataRow["Strap Material"]?.ToString() : null;
                        excelProduct.CompatibleWith = dataRow.Table.Columns.Contains("Compatible With") ? dataRow["Compatible With"]?.ToString() : null;
                        excelProduct.BaseMaterial = dataRow.Table.Columns.Contains("Base Material") ? dataRow["Base Material"]?.ToString() : null;
                        excelProduct.SecondaryMaterial = dataRow.Table.Columns.Contains("Secondary Material") ? dataRow["Secondary Material"]?.ToString() : null;
                        excelProduct.MaterialFinish = dataRow.Table.Columns.Contains("Material Finish") ? dataRow["Material Finish"]?.ToString() : null;
                        excelProduct.TypesofShowerHead = dataRow.Table.Columns.Contains("Types of Shower Head") ? dataRow["Types of Shower Head"]?.ToString() : null;
                        excelProduct.TypesofDispenser = dataRow.Table.Columns.Contains("Types of Dispenser") ? dataRow["Types of Dispenser"]?.ToString() : null;
                        excelProduct.NumberofSpraySettings = dataRow.Table.Columns.Contains("Number of Spray Settings") ? dataRow["Number of Spray Settings"]?.ToString() : null;
                        excelProduct.AssemblyRequired = dataRow.Table.Columns.Contains("Assembly Required") ? dataRow["Assembly Required"]?.ToString() : null;
                        excelProduct.SetIncludes = dataRow.Table.Columns.Contains("Set Includes") ? dataRow["Set Includes"]?.ToString() : null;
                        excelProduct.FillingMaterial = dataRow.Table.Columns.Contains("Filling Material") ? dataRow["Filling Material"]?.ToString() : null;
                        excelProduct.ComfortLevel = dataRow.Table.Columns.Contains("Comfort Level") ? dataRow["Comfort Level"]?.ToString() : null;
                        excelProduct.SheetType = dataRow.Table.Columns.Contains("Sheet Type") ? dataRow["Sheet Type"]?.ToString() : null;
                        excelProduct.PackSize = dataRow.Table.Columns.Contains("Pack Size") ? dataRow["Pack Size"]?.ToString() : null;
                        excelProduct.Formation = dataRow.Table.Columns.Contains("Formation") ? dataRow["Formation"]?.ToString() : null;
                        excelProduct.TargetUseApplication = dataRow.Table.Columns.Contains("Target Use/Application") ? dataRow["Target Use/Application"]?.ToString() : null;
                        excelProduct.TargetSkinType = dataRow.Table.Columns.Contains("Target Skin Type") ? dataRow["Target Skin Type"]?.ToString() : null;
                        excelProduct.UVProtection = dataRow.Table.Columns.Contains("UV Protection") ? dataRow["UV Protection"]?.ToString() : null;
                        excelProduct.BatterySize = dataRow.Table.Columns.Contains("Battery Size") ? dataRow["Battery Size"]?.ToString() : null;
                        excelProduct.BatterySizeUnit = dataRow.Table.Columns.Contains("Battery Size Unit") ? dataRow["Battery Size Unit"]?.ToString() : null;
                        excelProduct.BrandCompatibility = dataRow.Table.Columns.Contains("Brand Compatibility") ? dataRow["Brand Compatibility"]?.ToString() : null;
                        excelProduct.ConnectionType = dataRow.Table.Columns.Contains("Connection Type") ? dataRow["Connection Type"]?.ToString() : null;
                        excelProduct.CaseType = dataRow.Table.Columns.Contains("Case Type") ? dataRow["Case Type"]?.ToString() : null;
                        excelProduct.ChargingType = dataRow.Table.Columns.Contains("Charging Type") ? dataRow["Charging Type"]?.ToString() : null;
                        excelProduct.PhoneCaseMaterial = dataRow.Table.Columns.Contains("Phone Case Material") ? dataRow["Phone Case Material"]?.ToString() : null;
                        excelProduct.AudioHeadphoneType = dataRow.Table.Columns.Contains("Audio Headphone Type") ? dataRow["Audio Headphone Type"]?.ToString() : null;
                        excelProduct.WarrantyYears = dataRow.Table.Columns.Contains("Warranty Years") ? dataRow["Warranty Years"]?.ToString() : null;
                        excelProduct.FrameColour = dataRow.Table.Columns.Contains("Frame Colour") ? dataRow["Frame Colour"]?.ToString() : null;
                        excelProduct.FrameColourFamily = dataRow.Table.Columns.Contains("Frame Colour Family") ? dataRow["Frame Colour Family"]?.ToString() : null;
                        excelProduct.LensColour = dataRow.Table.Columns.Contains("Lens Colour") ? dataRow["Lens Colour"]?.ToString() : null;
                        excelProduct.LensColourFamily = dataRow.Table.Columns.Contains("Lens Colour Family") ? dataRow["Lens Colour Family"]?.ToString() : null;
                        excelProduct.FrameShapeStyle = dataRow.Table.Columns.Contains("Frame Shape/Style") ? dataRow["Frame Shape/Style"]?.ToString() : null;
                        excelProduct.LensFocalType = dataRow.Table.Columns.Contains("Lens Focal Type") ? dataRow["Lens Focal Type"]?.ToString() : null;
                        excelProduct.LensMagnification = dataRow.Table.Columns.Contains("Lens Magnification") ? dataRow["Lens Magnification"]?.ToString() : null;
                        excelProduct.LensType = dataRow.Table.Columns.Contains("Lens Type") ? dataRow["Lens Type"]?.ToString() : null;
                        excelProduct.WidthProfile = dataRow.Table.Columns.Contains("Width Profile") ? dataRow["Width Profile"]?.ToString() : null;
                        excelProduct.UpperMaterial = dataRow.Table.Columns.Contains("Upper Material") ? dataRow["Upper Material"]?.ToString() : null;
                        excelProduct.SoleMaterial = dataRow.Table.Columns.Contains("Sole Material") ? dataRow["Sole Material"]?.ToString() : null;
                        excelProduct.HeelType = dataRow.Table.Columns.Contains("Heel Type") ? dataRow["Heel Type"]?.ToString() : null;
                        excelProduct.HeelProfile = dataRow.Table.Columns.Contains("Heel Profile") ? dataRow["Heel Profile"]?.ToString() : null;
                        excelProduct.HeelHeight = dataRow.Table.Columns.Contains("Heel Height") ? dataRow["Heel Height"]?.ToString() : null;
                        excelProduct.HeelHeightUnit = dataRow.Table.Columns.Contains("Heel Height Unit") ? dataRow["Heel Height Unit"]?.ToString() : null;
                        excelProduct.BootShaftHeight = dataRow.Table.Columns.Contains("Boot Shaft Height") ? dataRow["Boot Shaft Height"]?.ToString() : null;
                        excelProduct.BootShaftHeightUnit = dataRow.Table.Columns.Contains("Boot Shaft Height Unit") ? dataRow["Boot Shaft Height Unit"]?.ToString() : null;
                        excelProduct.BootCircumference = dataRow.Table.Columns.Contains("Boot Circumference") ? dataRow["Boot Circumference"]?.ToString() : null;
                        excelProduct.BootCircumferenceUnit = dataRow.Table.Columns.Contains("Boot Circumference Unit") ? dataRow["Boot Circumference Unit"]?.ToString() : null;
                        excelProduct.ClosureFastener = dataRow.Table.Columns.Contains("Closure/Fastener") ? dataRow["Closure/Fastener"]?.ToString(): null;
                        excelProduct.WardrobeDesign = dataRow.Table.Columns.Contains("Wardrobe Design") ? dataRow["Wardrobe Design"]?.ToString() : null;
                        excelProduct.UpholsteryType = dataRow.Table.Columns.Contains("Upholstery Type") ? dataRow["Upholstery Type"]?.ToString() : null;
                        excelProduct.SeatFilling = dataRow.Table.Columns.Contains("Seat Filling") ? dataRow["Seat Filling"]?.ToString() : null;
                        excelProduct.SeatCushion = dataRow.Table.Columns.Contains("Seat Cushion") ? dataRow["Seat Cushion"]?.ToString() : null;
                        excelProduct.WoodType = dataRow.Table.Columns.Contains("Wood Type") ? dataRow["Wood Type"]?.ToString() : null;
                        excelProduct.WoodTone = dataRow.Table.Columns.Contains("Wood Tone") ? dataRow["Wood Tone"]?.ToString() : null;
                        excelProduct.Shape = dataRow.Table.Columns.Contains("Shape") ? dataRow["Shape"]?.ToString() : null;
                        excelProduct.NumberofDrawers = dataRow.Table.Columns.Contains("Number of Drawers") ? dataRow["Number of Drawers"]?.ToString() : null;
                        excelProduct.NumberofDoors = dataRow.Table.Columns.Contains("Number of Doors") ? dataRow["Number of Doors"]?.ToString() : null;
                        excelProduct.NumberofShelves = dataRow.Table.Columns.Contains("Number of Shelves") ? dataRow["Number of Shelves"]?.ToString() : null;
                        excelProduct.NumberofSeats = dataRow.Table.Columns.Contains("Number of Seats") ? dataRow["Number of Seats"]?.ToString() : null;
                        excelProduct.NumberofPanels = dataRow.Table.Columns.Contains("Number of Panels") ? dataRow["Number of Panels"]?.ToString() : null;
                        excelProduct.Installation = dataRow.Table.Columns.Contains("Installation") ? dataRow["Installation"]?.ToString() : null;
                        excelProduct.EnergyUsed = dataRow.Table.Columns.Contains("Energy Used") ? dataRow["Energy Used"]?.ToString() : null;
                        excelProduct.AdditionalFeature1 = dataRow.Table.Columns.Contains("Additional Feature 1") ? dataRow["Additional Feature 1"]?.ToString() : null;
                        excelProduct.AdditionalFeature2 = dataRow.Table.Columns.Contains("Additional Feature 2") ? dataRow["Additional Feature 2"]?.ToString() : null;
                        excelProduct.AdditionalFeature3 = dataRow.Table.Columns.Contains("Additional Feature 3") ? dataRow["Additional Feature 3"]?.ToString() : null;
                        excelProduct.Pattern = dataRow.Table.Columns.Contains("Pattern") ? dataRow["Pattern"]?.ToString() : null;
                        excelProduct.MatsRugsCarpetDesign = dataRow.Table.Columns.Contains("Mats, Rugs & Carpet Design") ? dataRow["Mats, Rugs & Carpet Design"]?.ToString() : null;
                        excelProduct.Technique = dataRow.Table.Columns.Contains("Technique") ? dataRow["Technique"]?.ToString() : null;
                        excelProduct.StyleofCurtainLining = dataRow.Table.Columns.Contains("Style of Curtain Lining") ? dataRow["Style of Curtain Lining"]?.ToString() : null;
                        excelProduct.DispenserType = dataRow.Table.Columns.Contains("Dispenser Type") ? dataRow["Dispenser Type"]?.ToString() : null;
                        excelProduct.ScentsNotes = dataRow.Table.Columns.Contains("Scents/Notes") ? dataRow["Scents/Notes"]?.ToString() : null;
                        excelProduct.AromatherapyType = dataRow.Table.Columns.Contains("Aromatherapy Type") ? dataRow["Aromatherapy Type"]?.ToString() : null;
                        excelProduct.FineLuxuryMaterial = dataRow.Table.Columns.Contains("Fine/Luxury Material") ? dataRow["Fine/Luxury Material"]?.ToString() : null;
                        excelProduct.BaseMaterialType = dataRow.Table.Columns.Contains("Base Material Type") ? dataRow["Base Material Type"]?.ToString() : null;
                        excelProduct.StoneGem = dataRow.Table.Columns.Contains("Stone/Gem") ? dataRow["Stone/Gem"]?.ToString() : null;
                        excelProduct.CaratWeight = dataRow.Table.Columns.Contains("Carat Weight") ? dataRow["Carat Weight"]?.ToString() : null;
                        excelProduct.ClosureFastening = dataRow.Table.Columns.Contains("Closure/Fastening") ? dataRow["Closure/Fastening"]?.ToString() : null;
                        excelProduct.ProductFeatures1 = dataRow.Table.Columns.Contains("Product Features 1") ? dataRow["Product Features 1"]?.ToString() : null;
                        excelProduct.ProductFeatures2 = dataRow.Table.Columns.Contains("Product Features 2") ? dataRow["Product Features 2"]?.ToString() : null;
                        excelProduct.ProductFeatures3 = dataRow.Table.Columns.Contains("Product Features 3") ? dataRow["Product Features 3"]?.ToString() : null;
                        excelProduct.ProductFeatures4 = dataRow.Table.Columns.Contains("Product Features 4") ? dataRow["Product Features 4"]?.ToString() : null;
                        excelProduct.ProductFeatures5 = dataRow.Table.Columns.Contains("Product Features 5") ? dataRow["Product Features 5"]?.ToString() : null;
                        excelProduct.InkColourFamily = dataRow.Table.Columns.Contains("Ink Colour Family") ? dataRow["Ink Colour Family"]?.ToString() : null;
                        excelProduct.PenMaterial = dataRow.Table.Columns.Contains("Pen Material") ? dataRow["Pen Material"]?.ToString() : null;
                        excelProduct.PointorNibType = dataRow.Table.Columns.Contains("Point or Nib Type") ? dataRow["Point or Nib Type"]?.ToString() : null;
                        excelProduct.PointSize = dataRow.Table.Columns.Contains("Point Size") ? dataRow["Point Size"]?.ToString() : null;
                        excelProduct.PointSizeUnit = dataRow.Table.Columns.Contains("Point Size Unit") ? dataRow["Point Size Unit"]?.ToString() : null;
                        excelProduct.Refillable = dataRow.Table.Columns.Contains("Refillable") ? dataRow["Refillable"]?.ToString() : null;
                        excelProduct.WatchBandColour = dataRow.Table.Columns.Contains("Watch Band Colour") ? dataRow["Watch Band Colour"]?.ToString() : null;
                        excelProduct.WatchBandColourFamily = dataRow.Table.Columns.Contains("Watch Band Colour Family") ? dataRow["Watch Band Colour Family"]?.ToString() : null;
                        excelProduct.BandLength = dataRow.Table.Columns.Contains("Band Length") ? dataRow["Band Length"]?.ToString() : null;
                        excelProduct.BandLengthUnit = dataRow.Table.Columns.Contains("Band Length Unit") ? dataRow["Band Length Unit"]?.ToString() : null;
                        excelProduct.WatchBandMaterial = dataRow.Table.Columns.Contains("Watch Band Material") ? dataRow["Watch Band Material"]?.ToString() : null;
                        excelProduct.WatchDialFaceType = dataRow.Table.Columns.Contains("Watch Dial/Face Type") ? dataRow["Watch Dial/Face Type"]?.ToString() : null;
                        excelProduct.DialFaceDiameter = dataRow.Table.Columns.Contains("Dial/Face Diameter") ? dataRow["Dial/Face Diameter"]?.ToString() : null;
                        excelProduct.DialFaceDiameterUnit = dataRow.Table.Columns.Contains("Dial/Face Diameter Unit") ? dataRow["Dial/Face Diameter Unit"]?.ToString() : null;
                        excelProduct.WatchDialFaceColour = dataRow.Table.Columns.Contains("Watch Dial/Face Colour") ? dataRow["Watch Dial/Face Colour"]?.ToString() : null;
                        excelProduct.WatchDialFaceColourFamily = dataRow.Table.Columns.Contains("Watch Dial/Face Colour Family") ? dataRow["Watch Dial/Face Colour Family"]?.ToString() : null;
                        excelProduct.WatchMovement = dataRow.Table.Columns.Contains("Watch Movement") ? dataRow["Watch Movement"]?.ToString() : null;
                        excelProduct.WatchCaseShape = dataRow.Table.Columns.Contains("Watch Case Shape") ? dataRow["Watch Case Shape"]?.ToString() : null;
                        excelProduct.WatchBandClosure = dataRow.Table.Columns.Contains("Watch Band Closure") ? dataRow["Watch Band Closure"]?.ToString() : null;
                        excelProduct.InterchangeableDialFace = dataRow.Table.Columns.Contains("Interchangeable Dial/Face") ? dataRow["Interchangeable Dial/Face"]?.ToString() : null;
                        excelProduct.InterchangeableStrap = dataRow.Table.Columns.Contains("Interchangeable Strap") ? dataRow["Interchangeable Strap"]?.ToString() : null;
                        excelProducts.Add(excelProduct);
                    }
                }
            }
            catch (Exception ex)
            {
                log.Error("Errror Occured While Reading Watches Excel Document : " + ex.StackTrace);
            }
            return excelProducts;
        }

        public void GenerateExcelSheetfromExcelProductsByBrand(List<ExcelProduct> excelProducts, string brand)
        {



            ExcelFileUtil.CreateSheetIfNotExists(brand);


            foreach (ExcelProduct excelProduct in excelProducts)
            {

            }
           

        }
    }
}
