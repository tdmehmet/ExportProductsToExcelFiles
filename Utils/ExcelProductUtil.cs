using ExportProductsToExcelFiles.AppModels;
using ExportProductsToExcelFiles.BiggBrands;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace ExportProductsToExcelFiles.Utils
{
    public static class ExcelProductUtil
    {
        public static List<SpecificationAttributeOptionCustomValueMap> GenerateAllSpecificationAttributeOptionListForExcelProduct(ExcelProduct excelProduct)
        {
            List<SpecificationAttributeOptionCustomValueMap> specificationAttributeOptionCustomValueMapList = new List<SpecificationAttributeOptionCustomValueMap>
            {
                
                SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionWithCustomValue("Season Code"                         ,excelProduct.SeasonCode                         ),
                SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionWithCustomValue("Year"                                ,excelProduct.Year                               ),
                SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionWithCustomValue("Style or Part Number"                ,excelProduct.StyleorPartNumber                  ),
                SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionWithCustomValue("Brand Name"                          ,excelProduct.BrandName                          ),
                SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionWithCustomValue("Department"                          ,excelProduct.Department                         ),
                SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionWithCustomValue("Product Type"                        ,excelProduct.ProductType                        ),
                SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionWithCustomValue("Product Subtype"                     ,excelProduct.ProductSubtype                     ),
                SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionWithCustomValue("Sport Type"                          ,excelProduct.SportType                          ),
                SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionWithCustomValue("Country of Origin"                   ,excelProduct.CountryofOrigin                    ),
                SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionWithCustomValue("Style or Part Name"                  ,excelProduct.StyleorPartName                    ),
                SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionWithCustomValue("Colour Name"                         ,excelProduct.ColourName                         ),
                SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionWithCustomValue("Colour Family"                       ,excelProduct.ColourFamily                       ),
                SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionWithCustomValue("Size"                                ,excelProduct.Size                               ),
                SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionWithCustomValue("Sizing Standard"                     ,excelProduct.SizingStandard                     ),
                SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionWithCustomValue("Target Age Range"                    ,excelProduct.TargetAgeRange                     ),
                SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionWithCustomValue("Special Size Type"                   ,excelProduct.SpecialSizeType                    ),
                SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionWithCustomValue("Material"                            ,excelProduct.Material                           ),
                SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionWithCustomValue("Lining Material"                     ,excelProduct.LiningMaterial                     ),
                SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionWithCustomValue("Neckline"                            ,excelProduct.Neckline                           ),
                SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionWithCustomValue("Sleeve Type"                         ,excelProduct.SleeveType                         ),
                SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionWithCustomValue("Fit"                                 ,excelProduct.Fit                                ),
                SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionWithCustomValue("Occasion"                            ,excelProduct.Occasion                           ),
                SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionWithCustomValue("Skirt/Dress Length"                  ,excelProduct.SkirtDressLength                   ),
                SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionWithCustomValue("Waist Type"                          ,excelProduct.WaistType                          ),
                SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionWithCustomValue("Bra Support"                         ,excelProduct.BraSupport                         ),
                SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionWithCustomValue("Care Instructions"                   ,excelProduct.CareInstructions                   ),
                SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionWithCustomValue("Attribute Key 1"                     ,excelProduct.AttributeKey1                      ),
                SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionWithCustomValue("Attribute Value 1"                   ,excelProduct.AttributeValue1                    ),
                SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionWithCustomValue("Attribute Key 2"                     ,excelProduct.AttributeKey2                      ),
                SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionWithCustomValue("Attribute Value 2"                   ,excelProduct.AttributeValue2                    ),
                SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionWithCustomValue("Attribute Key 3"                     ,excelProduct.AttributeKey3                      ),
                SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionWithCustomValue("Attribute Value 3"                   ,excelProduct.AttributeValue3                    ),
                SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionWithCustomValue("Attribute Key 4"                     ,excelProduct.AttributeKey4                      ),
                SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionWithCustomValue("Attribute Value 4"                   ,excelProduct.AttributeValue4                    ),
                SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionWithCustomValue("Attribute Key 5"                     ,excelProduct.AttributeKey5                      ),
                SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionWithCustomValue("Attribute Value 5"                   ,excelProduct.AttributeValue5                    ),
                SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionWithCustomValue("Shipping Length (cm)"                ,excelProduct.ShippingLengthcm                   ),
                SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionWithCustomValue("Shipping Height (cm)"                ,excelProduct.ShippingHeightcm                   ),
                SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionWithCustomValue("Shipping Width/Depth (cm)"           ,excelProduct.ShippingWidthDepthcm               ),
                SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionWithCustomValue("Shipping Weight (KG)"                ,excelProduct.ShippingWeightKG                   ),
                SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionWithCustomValue("Shipping Destination"                ,excelProduct.ShippingDestination                ),
                SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionWithCustomValue("Quantity/Stock"                      ,excelProduct.QuantityStock                      ),
                SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionWithCustomValue("Fulfilment Method"                   ,excelProduct.FulfilmentMethod                   ),
                SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionWithCustomValue("Processing Time"                     ,excelProduct.ProcessingTime                     ),
                SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionWithCustomValue("MSRP AE"                             ,excelProduct.MSRPAE                             ),
                SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionWithCustomValue("MSRP SA"                             ,excelProduct.MSRPSA                             ),
                SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionWithCustomValue("MSRP EG"                             ,excelProduct.MSRPEG                             ),
                SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionWithCustomValue("Cost (AED)"                          ,excelProduct.CostAED                            ),
                SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionWithCustomValue("Selling Price (AED)"                 ,excelProduct.SellingPriceAED                    ),
                SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionWithCustomValue("Selling Price (SAR)"                 ,excelProduct.SellingPriceSAR                    ),
                SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionWithCustomValue("Selling Price (EGP)"                 ,excelProduct.SellingPriceEGP                    ),
                SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionWithCustomValue("Promotional Price (AED)"             ,excelProduct.PromotionalPriceAED                ),
                SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionWithCustomValue("Promotional Price (SAR)"             ,excelProduct.PromotionalPriceSAR                ),
                SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionWithCustomValue("Promotional Price (EGP)"             ,excelProduct.PromotionalPriceEGP                ),
                SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionWithCustomValue("HS Code"                             ,excelProduct.HSCode                             ),
                SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionWithCustomValue("Model Number"                        ,excelProduct.ModelNumber                        ),
                SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionWithCustomValue("Model Name"                          ,excelProduct.ModelName                          ),
                SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionWithCustomValue("Product Length"                      ,excelProduct.ProductLength                      ),
                SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionWithCustomValue("Length Unit"                         ,excelProduct.LengthUnit                         ),
                SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionWithCustomValue("Product Height"                      ,excelProduct.ProductHeight                      ),
                SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionWithCustomValue("Height Unit"                         ,excelProduct.HeightUnit                         ),
                SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionWithCustomValue("Product Width/Depth"                 ,excelProduct.ProductWidthDepth                  ),
                SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionWithCustomValue("Width/Depth Unit"                    ,excelProduct.WidthDepthUnit                     ),
                SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionWithCustomValue("Product Weight"                      ,excelProduct.ProductWeight                      ),
                SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionWithCustomValue("Weight Unit"                         ,excelProduct.WeightUnit                         ),
                SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionWithCustomValue("Capacity"                            ,excelProduct.Capacity                           ),
                SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionWithCustomValue("Capacity Unit"                       ,excelProduct.CapacityUnit                       ),
                SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionWithCustomValue("Number of Pieces"                    ,excelProduct.NumberofPieces                     ),
                SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionWithCustomValue("Size Unit"                           ,excelProduct.SizeUnit                           ),
                SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionWithCustomValue("Exterior Material"                   ,excelProduct.ExteriorMaterial                   ),
                SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionWithCustomValue("Interior Material"                   ,excelProduct.InteriorMaterial                   ),
                SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionWithCustomValue("Strap Material"                      ,excelProduct.StrapMaterial                      ),
                SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionWithCustomValue("Compatible With"                     ,excelProduct.CompatibleWith                     ),
                SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionWithCustomValue("Base Material"                       ,excelProduct.BaseMaterial                       ),
                SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionWithCustomValue("Secondary Material"                  ,excelProduct.SecondaryMaterial                  ),
                SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionWithCustomValue("Material Finish"                     ,excelProduct.MaterialFinish                     ),
                SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionWithCustomValue("Types of Shower Head"                ,excelProduct.TypesofShowerHead                  ),
                SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionWithCustomValue("Types of Dispenser"                  ,excelProduct.TypesofDispenser                   ),
                SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionWithCustomValue("Number of Spray Settings"            ,excelProduct.NumberofSpraySettings              ),
                SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionWithCustomValue("Assembly Required"                   ,excelProduct.AssemblyRequired                   ),
                SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionWithCustomValue("Set Includes"                        ,excelProduct.SetIncludes                        ),
                SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionWithCustomValue("Filling Material"                    ,excelProduct.FillingMaterial                    ),
                SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionWithCustomValue("Comfort Level"                       ,excelProduct.ComfortLevel                       ),
                SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionWithCustomValue("Sheet Type"                          ,excelProduct.SheetType                          ),
                SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionWithCustomValue("Pack Size"                           ,excelProduct.PackSize                           ),
                SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionWithCustomValue("Formation"                           ,excelProduct.Formation                          ),
                SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionWithCustomValue("Target Use/Application"              ,excelProduct.TargetUseApplication               ),
                SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionWithCustomValue("Target Skin Type"                    ,excelProduct.TargetSkinType                     ),
                SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionWithCustomValue("UV Protection"                       ,excelProduct.UVProtection                       ),
                SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionWithCustomValue("Battery Size"                        ,excelProduct.BatterySize                        ),
                SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionWithCustomValue("Battery Size Unit"                   ,excelProduct.BatterySizeUnit                    ),
                SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionWithCustomValue("Brand Compatibility"                 ,excelProduct.BrandCompatibility                 ),
                SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionWithCustomValue("Connection Type"                     ,excelProduct.ConnectionType                     ),
                SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionWithCustomValue("Case Type"                           ,excelProduct.CaseType                           ),
                SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionWithCustomValue("Charging Type"                       ,excelProduct.ChargingType                       ),
                SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionWithCustomValue("Phone Case Material"                 ,excelProduct.PhoneCaseMaterial                  ),
                SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionWithCustomValue("Audio Headphone Type"                ,excelProduct.AudioHeadphoneType                 ),
                SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionWithCustomValue("Warranty Years"                      ,excelProduct.WarrantyYears                      ),
                SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionWithCustomValue("Frame Colour"                        ,excelProduct.FrameColour                        ),
                SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionWithCustomValue("Frame Colour Family"                 ,excelProduct.FrameColourFamily                  ),
                SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionWithCustomValue("Lens Colour"                         ,excelProduct.LensColour                         ),
                SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionWithCustomValue("Lens Colour Family"                  ,excelProduct.LensColourFamily                   ),
                SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionWithCustomValue("Frame Shape/Style"                   ,excelProduct.FrameShapeStyle                    ),
                SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionWithCustomValue("Lens Focal Type"                     ,excelProduct.LensFocalType                      ),
                SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionWithCustomValue("Lens Magnification"                  ,excelProduct.LensMagnification                  ),
                SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionWithCustomValue("Lens Type"                           ,excelProduct.LensType                           ),
                SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionWithCustomValue("Width Profile"                       ,excelProduct.WidthProfile                       ),
                SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionWithCustomValue("Upper Material"                      ,excelProduct.UpperMaterial                      ),
                SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionWithCustomValue("Sole Material"                       ,excelProduct.SoleMaterial                       ),
                SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionWithCustomValue("Heel Type"                           ,excelProduct.HeelType                           ),
                SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionWithCustomValue("Heel Profile"                        ,excelProduct.HeelProfile                        ),
                SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionWithCustomValue("Heel Height"                         ,excelProduct.HeelHeight                         ),
                SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionWithCustomValue("Heel Height Unit"                    ,excelProduct.HeelHeightUnit                     ),
                SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionWithCustomValue("Boot Shaft Height"                   ,excelProduct.BootShaftHeight                    ),
                SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionWithCustomValue("Boot Shaft Height Unit"              ,excelProduct.BootShaftHeightUnit                ),
                SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionWithCustomValue("Boot Circumference"                  ,excelProduct.BootCircumference                  ),
                SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionWithCustomValue("Boot Circumference Unit"             ,excelProduct.BootCircumferenceUnit              ),
                SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionWithCustomValue("Closure/Fastener"                    ,excelProduct.ClosureFastener                    ),
                SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionWithCustomValue("Wardrobe Design"                     ,excelProduct.WardrobeDesign                     ),
                SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionWithCustomValue("Upholstery Type"                     ,excelProduct.UpholsteryType                     ),
                SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionWithCustomValue("Seat Filling"                        ,excelProduct.SeatFilling                        ),
                SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionWithCustomValue("Seat Cushion"                        ,excelProduct.SeatCushion                        ),
                SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionWithCustomValue("Wood Type"                           ,excelProduct.WoodType                           ),
                SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionWithCustomValue("Wood Tone"                           ,excelProduct.WoodTone                           ),
                SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionWithCustomValue("Shape"                               ,excelProduct.Shape                              ),
                SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionWithCustomValue("Number of Drawers"                   ,excelProduct.NumberofDrawers                    ),
                SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionWithCustomValue("Number of Doors"                     ,excelProduct.NumberofDoors                      ),
                SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionWithCustomValue("Number of Shelves"                   ,excelProduct.NumberofShelves                    ),
                SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionWithCustomValue("Number of Seats"                     ,excelProduct.NumberofSeats                      ),
                SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionWithCustomValue("Number of Panels"                    ,excelProduct.NumberofPanels                     ),
                SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionWithCustomValue("Installation"                        ,excelProduct.Installation                       ),
                SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionWithCustomValue("Energy Used"                         ,excelProduct.EnergyUsed                         ),
                SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionWithCustomValue("Additional Feature 1"                ,excelProduct.AdditionalFeature1                 ),
                SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionWithCustomValue("Additional Feature 2"                ,excelProduct.AdditionalFeature2                 ),
                SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionWithCustomValue("Additional Feature 3"                ,excelProduct.AdditionalFeature3                 ),
                SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionWithCustomValue("Pattern"                             ,excelProduct.Pattern                            ),
                SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionWithCustomValue("Mats, Rugs & Carpet Design"          ,excelProduct.MatsRugsCarpetDesign               ),
                SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionWithCustomValue("Technique"                           ,excelProduct.Technique                          ),
                SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionWithCustomValue("Style of Curtain Lining"             ,excelProduct.StyleofCurtainLining               ),
                SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionWithCustomValue("Dispenser Type"                      ,excelProduct.DispenserType                      ),
                SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionWithCustomValue("Scents/Notes"                        ,excelProduct.ScentsNotes                        ),
                SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionWithCustomValue("Aromatherapy Type"                   ,excelProduct.AromatherapyType                   ),
                SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionWithCustomValue("Fine/Luxury Material"                ,excelProduct.FineLuxuryMaterial                 ),
                SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionWithCustomValue("Base Material Type"                  ,excelProduct.BaseMaterialType                   ),
                SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionWithCustomValue("Stone/Gem"                           ,excelProduct.StoneGem                           ),
                SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionWithCustomValue("Carat Weight"                        ,excelProduct.CaratWeight                        ),
                SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionWithCustomValue("Closure/Fastening"                   ,excelProduct.ClosureFastening                   ),
                SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionWithCustomValue("Product Features 1"                  ,excelProduct.ProductFeatures1                   ),
                SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionWithCustomValue("Product Features 2"                  ,excelProduct.ProductFeatures2                   ),
                SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionWithCustomValue("Product Features 3"                  ,excelProduct.ProductFeatures3                   ),
                SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionWithCustomValue("Product Features 4"                  ,excelProduct.ProductFeatures4                   ),
                SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionWithCustomValue("Product Features 5"                  ,excelProduct.ProductFeatures5                   ),
                SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionWithCustomValue("Ink Colour Family"                   ,excelProduct.InkColourFamily                    ),
                SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionWithCustomValue("Pen Material"                        ,excelProduct.PenMaterial                        ),
                SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionWithCustomValue("Point or Nib Type"                   ,excelProduct.PointorNibType                     ),
                SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionWithCustomValue("Point Size"                          ,excelProduct.PointSize                          ),
                SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionWithCustomValue("Point Size Unit"                     ,excelProduct.PointSizeUnit                      ),
                SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionWithCustomValue("Refillable"                          ,excelProduct.Refillable                         ),
                SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionWithCustomValue("Watch Band Colour"                   ,excelProduct.WatchBandColour                    ),
                SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionWithCustomValue("Watch Band Colour Family"            ,excelProduct.WatchBandColourFamily              ),
                SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionWithCustomValue("Band Length"                         ,excelProduct.BandLength                         ),
                SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionWithCustomValue("Band Length Unit"                    ,excelProduct.BandLengthUnit                     ),
                SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionWithCustomValue("Watch Band Material"                 ,excelProduct.WatchBandMaterial                  ),
                SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionWithCustomValue("Watch Dial/Face Type"                ,excelProduct.WatchDialFaceType                  ),
                SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionWithCustomValue("Dial/Face Diameter"                  ,excelProduct.DialFaceDiameter                   ),
                SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionWithCustomValue("Dial/Face Diameter Unit"             ,excelProduct.DialFaceDiameterUnit               ),
                SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionWithCustomValue("Watch Dial/Face Colour"              ,excelProduct.WatchDialFaceColour                ),
                SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionWithCustomValue("Watch Dial/Face Colour Family"       ,excelProduct.WatchDialFaceColourFamily          ),
                SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionWithCustomValue("Watch Movement"                      ,excelProduct.WatchMovement                      ),
                SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionWithCustomValue("Watch Case Shape"                    ,excelProduct.WatchCaseShape                     ),
                SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionWithCustomValue("Watch Band Closure"                  ,excelProduct.WatchBandClosure                   ),
                SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionWithCustomValue("Interchangeable Dial/Face"           ,excelProduct.InterchangeableDialFace            ),
                SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionWithCustomValue("Interchangeable Strap"               ,excelProduct.InterchangeableStrap               ),
            };

            return specificationAttributeOptionCustomValueMapList;
        }

        public static ExcelProduct GenerateExcelProductFromProduct(Product product)
        {
            ExcelProduct excelProduct = new ExcelProduct();

            excelProduct.GTIN = product.Gtin;
            excelProduct.ProductTitle = product.Name;
            excelProduct.PartnerSKUUnique = product.Sku;
            excelProduct.FeatureBullet1 = product.BulletPoint1;
            excelProduct.FeatureBullet2 = product.BulletPoint2;
            excelProduct.FeatureBullet3 = product.BulletPoint3;
            excelProduct.FeatureBullet4 = product.BulletPoint4;
            excelProduct.FeatureBullet5 = product.BulletPoint5;
            excelProduct.BrandName = product.ProductManufacturerMapping.FirstOrDefault().Manufacturer.Name;
            excelProduct.SeasonCode = SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionOfProductBySpecificationAttribute("Season Code", product.ProductSpecificationAttributeMapping.ToList());
            excelProduct.Year = SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionOfProductBySpecificationAttribute("Year", product.ProductSpecificationAttributeMapping.ToList());
            excelProduct.StyleorPartNumber = SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionOfProductBySpecificationAttribute("Style or Part Number", product.ProductSpecificationAttributeMapping.ToList());
            excelProduct.BrandName = SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionOfProductBySpecificationAttribute("Brand Name", product.ProductSpecificationAttributeMapping.ToList());
            excelProduct.Department = SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionOfProductBySpecificationAttribute("Department", product.ProductSpecificationAttributeMapping.ToList());
            excelProduct.ProductType = SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionOfProductBySpecificationAttribute("Product Type", product.ProductSpecificationAttributeMapping.ToList());
            excelProduct.ProductSubtype = SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionOfProductBySpecificationAttribute("Product Subtype", product.ProductSpecificationAttributeMapping.ToList());
            excelProduct.SportType = SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionOfProductBySpecificationAttribute("Sport Type", product.ProductSpecificationAttributeMapping.ToList());
            excelProduct.CountryofOrigin = SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionOfProductBySpecificationAttribute("Country of Origin", product.ProductSpecificationAttributeMapping.ToList());
            excelProduct.StyleorPartName = SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionOfProductBySpecificationAttribute("Style or Part Name", product.ProductSpecificationAttributeMapping.ToList());
            excelProduct.ColourName = SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionOfProductBySpecificationAttribute("Colour Name", product.ProductSpecificationAttributeMapping.ToList());
            excelProduct.ColourFamily = SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionOfProductBySpecificationAttribute("Colour Family", product.ProductSpecificationAttributeMapping.ToList());
            excelProduct.Size = SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionOfProductBySpecificationAttribute("Size", product.ProductSpecificationAttributeMapping.ToList());
            excelProduct.SizingStandard = SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionOfProductBySpecificationAttribute("Sizing Standard", product.ProductSpecificationAttributeMapping.ToList());
            excelProduct.TargetAgeRange = SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionOfProductBySpecificationAttribute("Target Age Range", product.ProductSpecificationAttributeMapping.ToList());
            excelProduct.SpecialSizeType = SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionOfProductBySpecificationAttribute("Special Size Type", product.ProductSpecificationAttributeMapping.ToList());
            excelProduct.Material = SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionOfProductBySpecificationAttribute("Material", product.ProductSpecificationAttributeMapping.ToList());
            excelProduct.LiningMaterial = SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionOfProductBySpecificationAttribute("Lining Material", product.ProductSpecificationAttributeMapping.ToList());
            excelProduct.Neckline = SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionOfProductBySpecificationAttribute("Neckline", product.ProductSpecificationAttributeMapping.ToList());
            excelProduct.SleeveType = SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionOfProductBySpecificationAttribute("Sleeve Type", product.ProductSpecificationAttributeMapping.ToList());
            excelProduct.Fit = SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionOfProductBySpecificationAttribute("Fit", product.ProductSpecificationAttributeMapping.ToList());
            excelProduct.Occasion = SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionOfProductBySpecificationAttribute("Occasion", product.ProductSpecificationAttributeMapping.ToList());
            excelProduct.SkirtDressLength = SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionOfProductBySpecificationAttribute("Skirt/Dress Length", product.ProductSpecificationAttributeMapping.ToList());
            excelProduct.WaistType = SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionOfProductBySpecificationAttribute("Waist Type", product.ProductSpecificationAttributeMapping.ToList());
            excelProduct.BraSupport = SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionOfProductBySpecificationAttribute("Bra Support", product.ProductSpecificationAttributeMapping.ToList());
            excelProduct.CareInstructions = SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionOfProductBySpecificationAttribute("Care Instructions", product.ProductSpecificationAttributeMapping.ToList());
            excelProduct.AttributeKey1 = SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionOfProductBySpecificationAttribute("Attribute Key 1", product.ProductSpecificationAttributeMapping.ToList());
            excelProduct.AttributeValue1 = SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionOfProductBySpecificationAttribute("Attribute Value 1", product.ProductSpecificationAttributeMapping.ToList());
            excelProduct.AttributeKey2 = SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionOfProductBySpecificationAttribute("Attribute Key 2", product.ProductSpecificationAttributeMapping.ToList());
            excelProduct.AttributeValue2 = SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionOfProductBySpecificationAttribute("Attribute Value 2", product.ProductSpecificationAttributeMapping.ToList());
            excelProduct.AttributeKey3 = SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionOfProductBySpecificationAttribute("Attribute Key 3", product.ProductSpecificationAttributeMapping.ToList());
            excelProduct.AttributeValue3 = SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionOfProductBySpecificationAttribute("Attribute Value 3", product.ProductSpecificationAttributeMapping.ToList());
            excelProduct.AttributeKey4 = SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionOfProductBySpecificationAttribute("Attribute Key 4", product.ProductSpecificationAttributeMapping.ToList());
            excelProduct.AttributeValue4 = SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionOfProductBySpecificationAttribute("Attribute Value 4", product.ProductSpecificationAttributeMapping.ToList());
            excelProduct.AttributeKey5 = SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionOfProductBySpecificationAttribute("Attribute Key 5", product.ProductSpecificationAttributeMapping.ToList());
            excelProduct.AttributeValue5 = SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionOfProductBySpecificationAttribute("Attribute Value 5", product.ProductSpecificationAttributeMapping.ToList());
            excelProduct.ShippingLengthcm = SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionOfProductBySpecificationAttribute("Shipping Length (cm)", product.ProductSpecificationAttributeMapping.ToList());
            excelProduct.ShippingHeightcm = SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionOfProductBySpecificationAttribute("Shipping Height (cm)", product.ProductSpecificationAttributeMapping.ToList());
            excelProduct.ShippingWidthDepthcm = SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionOfProductBySpecificationAttribute("Shipping Width/Depth (cm)", product.ProductSpecificationAttributeMapping.ToList());
            excelProduct.ShippingWeightKG = SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionOfProductBySpecificationAttribute("Shipping Weight (KG)", product.ProductSpecificationAttributeMapping.ToList());
            excelProduct.ShippingDestination = SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionOfProductBySpecificationAttribute("Shipping Destination", product.ProductSpecificationAttributeMapping.ToList());
            excelProduct.QuantityStock = SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionOfProductBySpecificationAttribute("Quantity/Stock", product.ProductSpecificationAttributeMapping.ToList());
            excelProduct.FulfilmentMethod = SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionOfProductBySpecificationAttribute("Fulfilment Method", product.ProductSpecificationAttributeMapping.ToList());
            excelProduct.ProcessingTime = SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionOfProductBySpecificationAttribute("Processing Time", product.ProductSpecificationAttributeMapping.ToList());
            excelProduct.MSRPAE = SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionOfProductBySpecificationAttribute("MSRP AE", product.ProductSpecificationAttributeMapping.ToList());
            excelProduct.MSRPSA = SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionOfProductBySpecificationAttribute("MSRP SA", product.ProductSpecificationAttributeMapping.ToList());
            excelProduct.MSRPEG = SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionOfProductBySpecificationAttribute("MSRP EG", product.ProductSpecificationAttributeMapping.ToList());
            excelProduct.CostAED = SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionOfProductBySpecificationAttribute("Cost (AED)", product.ProductSpecificationAttributeMapping.ToList());
            excelProduct.SellingPriceAED = SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionOfProductBySpecificationAttribute("Selling Price (AED)", product.ProductSpecificationAttributeMapping.ToList());
            excelProduct.SellingPriceSAR = SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionOfProductBySpecificationAttribute("Selling Price (SAR)", product.ProductSpecificationAttributeMapping.ToList());
            excelProduct.SellingPriceEGP = SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionOfProductBySpecificationAttribute("Selling Price (EGP)", product.ProductSpecificationAttributeMapping.ToList());
            excelProduct.PromotionalPriceAED = SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionOfProductBySpecificationAttribute("Promotional Price (AED)", product.ProductSpecificationAttributeMapping.ToList());
            excelProduct.PromotionalPriceSAR = SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionOfProductBySpecificationAttribute("Promotional Price (SAR)", product.ProductSpecificationAttributeMapping.ToList());
            excelProduct.PromotionalPriceEGP = SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionOfProductBySpecificationAttribute("Promotional Price (EGP)", product.ProductSpecificationAttributeMapping.ToList());
            excelProduct.HSCode = SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionOfProductBySpecificationAttribute("HS Code", product.ProductSpecificationAttributeMapping.ToList());
            excelProduct.ModelNumber = SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionOfProductBySpecificationAttribute("Model Number", product.ProductSpecificationAttributeMapping.ToList());
            excelProduct.ModelName = SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionOfProductBySpecificationAttribute("Model Name", product.ProductSpecificationAttributeMapping.ToList());
            excelProduct.ProductLength = SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionOfProductBySpecificationAttribute("Product Length", product.ProductSpecificationAttributeMapping.ToList());
            excelProduct.LengthUnit = SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionOfProductBySpecificationAttribute("Length Unit", product.ProductSpecificationAttributeMapping.ToList());
            excelProduct.ProductHeight = SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionOfProductBySpecificationAttribute("Product Height", product.ProductSpecificationAttributeMapping.ToList());
            excelProduct.HeightUnit = SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionOfProductBySpecificationAttribute("Height Unit", product.ProductSpecificationAttributeMapping.ToList());
            excelProduct.ProductWidthDepth = SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionOfProductBySpecificationAttribute("Product Width/Depth", product.ProductSpecificationAttributeMapping.ToList());
            excelProduct.WidthDepthUnit = SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionOfProductBySpecificationAttribute("Width/Depth Unit", product.ProductSpecificationAttributeMapping.ToList());
            excelProduct.ProductWeight = SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionOfProductBySpecificationAttribute("Product Weight", product.ProductSpecificationAttributeMapping.ToList());
            excelProduct.WeightUnit = SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionOfProductBySpecificationAttribute("Weight Unit", product.ProductSpecificationAttributeMapping.ToList());
            excelProduct.Capacity = SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionOfProductBySpecificationAttribute("Capacity", product.ProductSpecificationAttributeMapping.ToList());
            excelProduct.CapacityUnit = SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionOfProductBySpecificationAttribute("Capacity Unit", product.ProductSpecificationAttributeMapping.ToList());
            excelProduct.NumberofPieces = SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionOfProductBySpecificationAttribute("Number of Pieces", product.ProductSpecificationAttributeMapping.ToList());
            excelProduct.SizeUnit = SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionOfProductBySpecificationAttribute("Size Unit", product.ProductSpecificationAttributeMapping.ToList());
            excelProduct.ExteriorMaterial = SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionOfProductBySpecificationAttribute("Exterior Material", product.ProductSpecificationAttributeMapping.ToList());
            excelProduct.InteriorMaterial = SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionOfProductBySpecificationAttribute("Interior Material", product.ProductSpecificationAttributeMapping.ToList());
            excelProduct.StrapMaterial = SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionOfProductBySpecificationAttribute("Strap Material", product.ProductSpecificationAttributeMapping.ToList());
            excelProduct.CompatibleWith = SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionOfProductBySpecificationAttribute("Compatible With", product.ProductSpecificationAttributeMapping.ToList());
            excelProduct.BaseMaterial = SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionOfProductBySpecificationAttribute("Base Material", product.ProductSpecificationAttributeMapping.ToList());
            excelProduct.SecondaryMaterial = SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionOfProductBySpecificationAttribute("Secondary Material", product.ProductSpecificationAttributeMapping.ToList());
            excelProduct.MaterialFinish = SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionOfProductBySpecificationAttribute("Material Finish", product.ProductSpecificationAttributeMapping.ToList());
            excelProduct.TypesofShowerHead = SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionOfProductBySpecificationAttribute("Types of Shower Head", product.ProductSpecificationAttributeMapping.ToList());
            excelProduct.TypesofDispenser = SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionOfProductBySpecificationAttribute("Types of Dispenser", product.ProductSpecificationAttributeMapping.ToList());
            excelProduct.NumberofSpraySettings = SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionOfProductBySpecificationAttribute("Number of Spray Settings", product.ProductSpecificationAttributeMapping.ToList());
            excelProduct.AssemblyRequired = SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionOfProductBySpecificationAttribute("Assembly Required", product.ProductSpecificationAttributeMapping.ToList());
            excelProduct.SetIncludes = SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionOfProductBySpecificationAttribute("Set Includes", product.ProductSpecificationAttributeMapping.ToList());
            excelProduct.FillingMaterial = SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionOfProductBySpecificationAttribute("Filling Material", product.ProductSpecificationAttributeMapping.ToList());
            excelProduct.ComfortLevel = SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionOfProductBySpecificationAttribute("Comfort Level", product.ProductSpecificationAttributeMapping.ToList());
            excelProduct.SheetType = SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionOfProductBySpecificationAttribute("Sheet Type", product.ProductSpecificationAttributeMapping.ToList());
            excelProduct.PackSize = SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionOfProductBySpecificationAttribute("Pack Size", product.ProductSpecificationAttributeMapping.ToList());
            excelProduct.Formation = SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionOfProductBySpecificationAttribute("Formation", product.ProductSpecificationAttributeMapping.ToList());
            excelProduct.TargetUseApplication = SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionOfProductBySpecificationAttribute("Target Use/Application", product.ProductSpecificationAttributeMapping.ToList());
            excelProduct.TargetSkinType = SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionOfProductBySpecificationAttribute("Target Skin Type", product.ProductSpecificationAttributeMapping.ToList());
            excelProduct.UVProtection = SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionOfProductBySpecificationAttribute("UV Protection", product.ProductSpecificationAttributeMapping.ToList());
            excelProduct.BatterySize = SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionOfProductBySpecificationAttribute("Battery Size", product.ProductSpecificationAttributeMapping.ToList());
            excelProduct.BatterySizeUnit = SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionOfProductBySpecificationAttribute("Battery Size Unit", product.ProductSpecificationAttributeMapping.ToList());
            excelProduct.BrandCompatibility = SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionOfProductBySpecificationAttribute("Brand Compatibility", product.ProductSpecificationAttributeMapping.ToList());
            excelProduct.ConnectionType = SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionOfProductBySpecificationAttribute("Connection Type", product.ProductSpecificationAttributeMapping.ToList());
            excelProduct.CaseType = SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionOfProductBySpecificationAttribute("Case Type", product.ProductSpecificationAttributeMapping.ToList());
            excelProduct.ChargingType = SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionOfProductBySpecificationAttribute("Charging Type", product.ProductSpecificationAttributeMapping.ToList());
            excelProduct.PhoneCaseMaterial = SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionOfProductBySpecificationAttribute("Phone Case Material", product.ProductSpecificationAttributeMapping.ToList());
            excelProduct.AudioHeadphoneType = SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionOfProductBySpecificationAttribute("Audio Headphone Type", product.ProductSpecificationAttributeMapping.ToList());
            excelProduct.WarrantyYears = SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionOfProductBySpecificationAttribute("Warranty Years", product.ProductSpecificationAttributeMapping.ToList());
            excelProduct.FrameColour = SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionOfProductBySpecificationAttribute("Frame Colour", product.ProductSpecificationAttributeMapping.ToList());
            excelProduct.FrameColourFamily = SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionOfProductBySpecificationAttribute("Frame Colour Family", product.ProductSpecificationAttributeMapping.ToList());
            excelProduct.LensColour = SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionOfProductBySpecificationAttribute("Lens Colour", product.ProductSpecificationAttributeMapping.ToList());
            excelProduct.LensColourFamily = SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionOfProductBySpecificationAttribute("Lens Colour Family", product.ProductSpecificationAttributeMapping.ToList());
            excelProduct.FrameShapeStyle = SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionOfProductBySpecificationAttribute("Frame Shape/Style", product.ProductSpecificationAttributeMapping.ToList());
            excelProduct.LensFocalType = SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionOfProductBySpecificationAttribute("Lens Focal Type", product.ProductSpecificationAttributeMapping.ToList());
            excelProduct.LensMagnification = SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionOfProductBySpecificationAttribute("Lens Magnification", product.ProductSpecificationAttributeMapping.ToList());
            excelProduct.LensType = SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionOfProductBySpecificationAttribute("Lens Type", product.ProductSpecificationAttributeMapping.ToList());
            excelProduct.WidthProfile = SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionOfProductBySpecificationAttribute("Width Profile", product.ProductSpecificationAttributeMapping.ToList());
            excelProduct.UpperMaterial = SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionOfProductBySpecificationAttribute("Upper Material", product.ProductSpecificationAttributeMapping.ToList());
            excelProduct.SoleMaterial = SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionOfProductBySpecificationAttribute("Sole Material", product.ProductSpecificationAttributeMapping.ToList());
            excelProduct.HeelType = SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionOfProductBySpecificationAttribute("Heel Type", product.ProductSpecificationAttributeMapping.ToList());
            excelProduct.HeelProfile = SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionOfProductBySpecificationAttribute("Heel Profile", product.ProductSpecificationAttributeMapping.ToList());
            excelProduct.HeelHeight = SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionOfProductBySpecificationAttribute("Heel Height", product.ProductSpecificationAttributeMapping.ToList());
            excelProduct.HeelHeightUnit = SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionOfProductBySpecificationAttribute("Heel Height Unit", product.ProductSpecificationAttributeMapping.ToList());
            excelProduct.BootShaftHeight = SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionOfProductBySpecificationAttribute("Boot Shaft Height", product.ProductSpecificationAttributeMapping.ToList());
            excelProduct.BootShaftHeightUnit = SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionOfProductBySpecificationAttribute("Boot Shaft Height Unit", product.ProductSpecificationAttributeMapping.ToList());
            excelProduct.BootCircumference = SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionOfProductBySpecificationAttribute("Boot Circumference", product.ProductSpecificationAttributeMapping.ToList());
            excelProduct.BootCircumferenceUnit = SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionOfProductBySpecificationAttribute("Boot Circumference Unit", product.ProductSpecificationAttributeMapping.ToList());
            excelProduct.ClosureFastener = SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionOfProductBySpecificationAttribute("Closure/Fastener", product.ProductSpecificationAttributeMapping.ToList());
            excelProduct.WardrobeDesign = SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionOfProductBySpecificationAttribute("Wardrobe Design", product.ProductSpecificationAttributeMapping.ToList());
            excelProduct.UpholsteryType = SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionOfProductBySpecificationAttribute("Upholstery Type", product.ProductSpecificationAttributeMapping.ToList());
            excelProduct.SeatFilling = SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionOfProductBySpecificationAttribute("Seat Filling", product.ProductSpecificationAttributeMapping.ToList());
            excelProduct.SeatCushion = SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionOfProductBySpecificationAttribute("Seat Cushion", product.ProductSpecificationAttributeMapping.ToList());
            excelProduct.WoodType = SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionOfProductBySpecificationAttribute("Wood Type", product.ProductSpecificationAttributeMapping.ToList());
            excelProduct.WoodTone = SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionOfProductBySpecificationAttribute("Wood Tone", product.ProductSpecificationAttributeMapping.ToList());
            excelProduct.Shape = SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionOfProductBySpecificationAttribute("Shape", product.ProductSpecificationAttributeMapping.ToList());
            excelProduct.NumberofDrawers = SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionOfProductBySpecificationAttribute("Number of Drawers", product.ProductSpecificationAttributeMapping.ToList());
            excelProduct.NumberofDoors = SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionOfProductBySpecificationAttribute("Number of Doors", product.ProductSpecificationAttributeMapping.ToList());
            excelProduct.NumberofShelves = SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionOfProductBySpecificationAttribute("Number of Shelves", product.ProductSpecificationAttributeMapping.ToList());
            excelProduct.NumberofSeats = SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionOfProductBySpecificationAttribute("Number of Seats", product.ProductSpecificationAttributeMapping.ToList());
            excelProduct.NumberofPanels = SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionOfProductBySpecificationAttribute("Number of Panels", product.ProductSpecificationAttributeMapping.ToList());
            excelProduct.Installation = SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionOfProductBySpecificationAttribute("Installation", product.ProductSpecificationAttributeMapping.ToList());
            excelProduct.EnergyUsed = SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionOfProductBySpecificationAttribute("Energy Used", product.ProductSpecificationAttributeMapping.ToList());
            excelProduct.AdditionalFeature1 = SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionOfProductBySpecificationAttribute("Additional Feature 1", product.ProductSpecificationAttributeMapping.ToList());
            excelProduct.AdditionalFeature2 = SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionOfProductBySpecificationAttribute("Additional Feature 2", product.ProductSpecificationAttributeMapping.ToList());
            excelProduct.AdditionalFeature3 = SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionOfProductBySpecificationAttribute("Additional Feature 3", product.ProductSpecificationAttributeMapping.ToList());
            excelProduct.Pattern = SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionOfProductBySpecificationAttribute("Pattern", product.ProductSpecificationAttributeMapping.ToList());
            excelProduct.MatsRugsCarpetDesign = SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionOfProductBySpecificationAttribute("Mats, Rugs & Carpet Design", product.ProductSpecificationAttributeMapping.ToList());
            excelProduct.Technique = SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionOfProductBySpecificationAttribute("Technique", product.ProductSpecificationAttributeMapping.ToList());
            excelProduct.StyleofCurtainLining = SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionOfProductBySpecificationAttribute("Style of Curtain Lining", product.ProductSpecificationAttributeMapping.ToList());
            excelProduct.DispenserType = SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionOfProductBySpecificationAttribute("Dispenser Type", product.ProductSpecificationAttributeMapping.ToList());
            excelProduct.ScentsNotes = SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionOfProductBySpecificationAttribute("Scents/Notes", product.ProductSpecificationAttributeMapping.ToList());
            excelProduct.AromatherapyType = SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionOfProductBySpecificationAttribute("Aromatherapy Type", product.ProductSpecificationAttributeMapping.ToList());
            excelProduct.FineLuxuryMaterial = SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionOfProductBySpecificationAttribute("Fine/Luxury Material", product.ProductSpecificationAttributeMapping.ToList());
            excelProduct.BaseMaterialType = SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionOfProductBySpecificationAttribute("Base Material Type", product.ProductSpecificationAttributeMapping.ToList());
            excelProduct.StoneGem = SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionOfProductBySpecificationAttribute("Stone/Gem", product.ProductSpecificationAttributeMapping.ToList());
            excelProduct.CaratWeight = SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionOfProductBySpecificationAttribute("Carat Weight", product.ProductSpecificationAttributeMapping.ToList());
            excelProduct.ClosureFastening = SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionOfProductBySpecificationAttribute("Closure/Fastening", product.ProductSpecificationAttributeMapping.ToList());
            excelProduct.ProductFeatures1 = SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionOfProductBySpecificationAttribute("Product Features 1", product.ProductSpecificationAttributeMapping.ToList());
            excelProduct.ProductFeatures2 = SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionOfProductBySpecificationAttribute("Product Features 2", product.ProductSpecificationAttributeMapping.ToList());
            excelProduct.ProductFeatures3 = SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionOfProductBySpecificationAttribute("Product Features 3", product.ProductSpecificationAttributeMapping.ToList());
            excelProduct.ProductFeatures4 = SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionOfProductBySpecificationAttribute("Product Features 4", product.ProductSpecificationAttributeMapping.ToList());
            excelProduct.ProductFeatures5 = SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionOfProductBySpecificationAttribute("Product Features 5", product.ProductSpecificationAttributeMapping.ToList());
            excelProduct.InkColourFamily = SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionOfProductBySpecificationAttribute("Ink Colour Family", product.ProductSpecificationAttributeMapping.ToList());
            excelProduct.PenMaterial = SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionOfProductBySpecificationAttribute("Pen Material", product.ProductSpecificationAttributeMapping.ToList());
            excelProduct.PointorNibType = SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionOfProductBySpecificationAttribute("Point or Nib Type", product.ProductSpecificationAttributeMapping.ToList());
            excelProduct.PointSize = SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionOfProductBySpecificationAttribute("Point Size", product.ProductSpecificationAttributeMapping.ToList());
            excelProduct.PointSizeUnit = SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionOfProductBySpecificationAttribute("Point Size Unit", product.ProductSpecificationAttributeMapping.ToList());
            excelProduct.Refillable = SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionOfProductBySpecificationAttribute("Refillable", product.ProductSpecificationAttributeMapping.ToList());
            excelProduct.WatchBandColour = SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionOfProductBySpecificationAttribute("Watch Band Colour", product.ProductSpecificationAttributeMapping.ToList());
            excelProduct.WatchBandColourFamily = SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionOfProductBySpecificationAttribute("Watch Band Colour Family", product.ProductSpecificationAttributeMapping.ToList());
            excelProduct.BandLength = SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionOfProductBySpecificationAttribute("Band Length", product.ProductSpecificationAttributeMapping.ToList());
            excelProduct.BandLengthUnit = SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionOfProductBySpecificationAttribute("Band Length Unit", product.ProductSpecificationAttributeMapping.ToList());
            excelProduct.WatchBandMaterial = SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionOfProductBySpecificationAttribute("Watch Band Material", product.ProductSpecificationAttributeMapping.ToList());
            excelProduct.WatchDialFaceType = SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionOfProductBySpecificationAttribute("Watch Dial/Face Type", product.ProductSpecificationAttributeMapping.ToList());
            excelProduct.DialFaceDiameter = SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionOfProductBySpecificationAttribute("Dial/Face Diameter", product.ProductSpecificationAttributeMapping.ToList());
            excelProduct.DialFaceDiameterUnit = SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionOfProductBySpecificationAttribute("Dial/Face Diameter Unit", product.ProductSpecificationAttributeMapping.ToList());
            excelProduct.WatchDialFaceColour = SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionOfProductBySpecificationAttribute("Watch Dial/Face Colour", product.ProductSpecificationAttributeMapping.ToList());
            excelProduct.WatchDialFaceColourFamily = SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionOfProductBySpecificationAttribute("Watch Dial/Face Colour Family", product.ProductSpecificationAttributeMapping.ToList());
            excelProduct.WatchMovement = SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionOfProductBySpecificationAttribute("Watch Movement", product.ProductSpecificationAttributeMapping.ToList());
            excelProduct.WatchCaseShape = SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionOfProductBySpecificationAttribute("Watch Case Shape", product.ProductSpecificationAttributeMapping.ToList());
            excelProduct.WatchBandClosure = SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionOfProductBySpecificationAttribute("Watch Band Closure", product.ProductSpecificationAttributeMapping.ToList());
            excelProduct.InterchangeableDialFace = SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionOfProductBySpecificationAttribute("Interchangeable Dial/Face", product.ProductSpecificationAttributeMapping.ToList());
            excelProduct.InterchangeableStrap = SpecificationAttributeOptionUtil.FindSpecificationAttributeOptionOfProductBySpecificationAttribute("Interchangeable Strap", product.ProductSpecificationAttributeMapping.ToList());

            return excelProduct;
        }
    }
}
