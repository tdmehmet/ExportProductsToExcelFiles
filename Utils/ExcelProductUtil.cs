using ExportProductsToExcelFiles.AppModels;
using ExportProductsToExcelFiles.BiggBrands;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace ExportProductsToExcelFiles.Utils
{
    public static class ExcelProductUtil
    {
        public static List<Product> products;
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
            if(product.Sku == "PRL19247040203")
            {
                string sku = "PRL19247040203";
            }
            excelProduct.GTIN = product.Gtin;
            excelProduct.ProductTitle = product.Name;
            excelProduct.PartnerSKUUnique = product.Sku;
            excelProduct.FeatureBullet1 = product.BulletPoint1;
            excelProduct.FeatureBullet2 = product.BulletPoint2;
            excelProduct.FeatureBullet3 = product.BulletPoint3;
            excelProduct.FeatureBullet4 = product.BulletPoint4;
            excelProduct.FeatureBullet5 = product.BulletPoint5;

            for (int i = 1; i < product.ProductPictureMapping.Count; i++)
            {
                if(i == 1)
                {
                    excelProduct.ImageURL1 = product.ProductPictureMapping.ToArray()[i].Picture.SeoFilename;
                }
                if (i == 2)
                {
                    excelProduct.ImageURL2 = product.ProductPictureMapping.ToArray()[i].Picture.SeoFilename;
                }
                if (i == 3)
                {
                    excelProduct.ImageURL3 = product.ProductPictureMapping.ToArray()[i].Picture.SeoFilename;
                }
                if (i == 4)
                {
                    excelProduct.ImageURL4 = product.ProductPictureMapping.ToArray()[i].Picture.SeoFilename;
                }
                if (i == 5)
                {
                    excelProduct.ImageURL5 = product.ProductPictureMapping.ToArray()[i].Picture.SeoFilename;
                }
            }
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


        public static string FindSpecificationAttributeValue(string specificationAttributeName, ExcelProduct excelProduct)
        {
            if (specificationAttributeName == "Season Code") return excelProduct.SeasonCode;
            if (specificationAttributeName == "Year") return excelProduct.Year;
            if (specificationAttributeName == "Style or Part Number") return excelProduct.StyleorPartNumber;
            if (specificationAttributeName == "Brand Name") return excelProduct.BrandName;
            if (specificationAttributeName == "Department") return excelProduct.Department;
            if (specificationAttributeName == "Product Type") return excelProduct.ProductType;
            if (specificationAttributeName == "Product Subtype") return excelProduct.ProductSubtype;
            if (specificationAttributeName == "Sport Type") return excelProduct.SportType;
            if (specificationAttributeName == "Country of Origin") return excelProduct.CountryofOrigin;
            if (specificationAttributeName == "Style or Part Name") return excelProduct.StyleorPartName;
            if (specificationAttributeName == "Colour Name") return excelProduct.ColourName;
            if (specificationAttributeName == "Colour Family") return excelProduct.ColourFamily;
            if (specificationAttributeName == "Size") return excelProduct.Size;
            if (specificationAttributeName == "Sizing Standard") return excelProduct.SizingStandard;
            if (specificationAttributeName == "Target Age Range") return excelProduct.TargetAgeRange;
            if (specificationAttributeName == "Special Size Type") return excelProduct.SpecialSizeType;
            if (specificationAttributeName == "Material") return excelProduct.Material;
            if (specificationAttributeName == "Lining Material") return excelProduct.LiningMaterial;
            if (specificationAttributeName == "Neckline") return excelProduct.Neckline;
            if (specificationAttributeName == "Sleeve Type") return excelProduct.SleeveType;
            if (specificationAttributeName == "Fit") return excelProduct.Fit;
            if (specificationAttributeName == "Occasion") return excelProduct.Occasion;
            if (specificationAttributeName == "Skirt/Dress Length") return excelProduct.SkirtDressLength;
            if (specificationAttributeName == "Waist Type") return excelProduct.WaistType;
            if (specificationAttributeName == "Bra Support") return excelProduct.BraSupport;
            if (specificationAttributeName == "Care Instructions") return excelProduct.CareInstructions;
            if (specificationAttributeName == "Attribute Key 1") return excelProduct.AttributeKey1;
            if (specificationAttributeName == "Attribute Value 1") return excelProduct.AttributeValue1;
            if (specificationAttributeName == "Attribute Key 2") return excelProduct.AttributeKey2;
            if (specificationAttributeName == "Attribute Value 2") return excelProduct.AttributeValue2;
            if (specificationAttributeName == "Attribute Key 3") return excelProduct.AttributeKey3;
            if (specificationAttributeName == "Attribute Value 3") return excelProduct.AttributeValue3;
            if (specificationAttributeName == "Attribute Key 4") return excelProduct.AttributeKey4;
            if (specificationAttributeName == "Attribute Value 4") return excelProduct.AttributeValue4;
            if (specificationAttributeName == "Attribute Key 5") return excelProduct.AttributeKey5;
            if (specificationAttributeName == "Attribute Value 5") return excelProduct.AttributeValue5;
            if (specificationAttributeName == "Shipping Length (cm)") return excelProduct.ShippingLengthcm;
            if (specificationAttributeName == "Shipping Height (cm)") return excelProduct.ShippingHeightcm;
            if (specificationAttributeName == "Shipping Width/Depth (cm)") return excelProduct.ShippingWidthDepthcm;
            if (specificationAttributeName == "Shipping Weight (KG)") return excelProduct.ShippingWeightKG;
            if (specificationAttributeName == "Shipping Destination") return excelProduct.ShippingDestination;
            if (specificationAttributeName == "Quantity/Stock") return excelProduct.QuantityStock;
            if (specificationAttributeName == "Fulfilment Method") return excelProduct.FulfilmentMethod;
            if (specificationAttributeName == "Processing Time") return excelProduct.ProcessingTime;
            if (specificationAttributeName == "MSRP AE") return excelProduct.MSRPAE;
            if (specificationAttributeName == "MSRP SA") return excelProduct.MSRPSA;
            if (specificationAttributeName == "MSRP EG") return excelProduct.MSRPEG;
            if (specificationAttributeName == "Cost (AED)") return excelProduct.CostAED;
            if (specificationAttributeName == "Selling Price (AED)") return excelProduct.SellingPriceAED;
            if (specificationAttributeName == "Selling Price (SAR)") return excelProduct.SellingPriceSAR;
            if (specificationAttributeName == "Selling Price (EGP)") return excelProduct.SellingPriceEGP;
            if (specificationAttributeName == "Promotional Price (AED)") return excelProduct.PromotionalPriceAED;
            if (specificationAttributeName == "Promotional Price (SAR)") return excelProduct.PromotionalPriceSAR;
            if (specificationAttributeName == "Promotional Price (EGP)") return excelProduct.PromotionalPriceEGP;
            if (specificationAttributeName == "HS Code") return excelProduct.HSCode;
            if (specificationAttributeName == "Model Number") return excelProduct.ModelNumber;
            if (specificationAttributeName == "Model Name") return excelProduct.ModelName;
            if (specificationAttributeName == "Product Length") return excelProduct.ProductLength;
            if (specificationAttributeName == "Length Unit") return excelProduct.LengthUnit;
            if (specificationAttributeName == "Product Height") return excelProduct.ProductHeight;
            if (specificationAttributeName == "Height Unit") return excelProduct.HeightUnit;
            if (specificationAttributeName == "Product Width/Depth") return excelProduct.ProductWidthDepth;
            if (specificationAttributeName == "Width/Depth Unit") return excelProduct.WidthDepthUnit;
            if (specificationAttributeName == "Product Weight") return excelProduct.ProductWeight;
            if (specificationAttributeName == "Weight Unit") return excelProduct.WeightUnit;
            if (specificationAttributeName == "Capacity") return excelProduct.Capacity;
            if (specificationAttributeName == "Capacity Unit") return excelProduct.CapacityUnit;
            if (specificationAttributeName == "Number of Pieces") return excelProduct.NumberofPieces;
            if (specificationAttributeName == "Size Unit") return excelProduct.SizeUnit;
            if (specificationAttributeName == "Exterior Material") return excelProduct.ExteriorMaterial;
            if (specificationAttributeName == "Interior Material") return excelProduct.InteriorMaterial;
            if (specificationAttributeName == "Strap Material") return excelProduct.StrapMaterial;
            if (specificationAttributeName == "Compatible With") return excelProduct.CompatibleWith;
            if (specificationAttributeName == "Base Material") return excelProduct.BaseMaterial;
            if (specificationAttributeName == "Secondary Material") return excelProduct.SecondaryMaterial;
            if (specificationAttributeName == "Material Finish") return excelProduct.MaterialFinish;
            if (specificationAttributeName == "Types of Shower Head") return excelProduct.TypesofShowerHead;
            if (specificationAttributeName == "Types of Dispenser") return excelProduct.TypesofDispenser;
            if (specificationAttributeName == "Number of Spray Settings") return excelProduct.NumberofSpraySettings;
            if (specificationAttributeName == "Assembly Required") return excelProduct.AssemblyRequired;
            if (specificationAttributeName == "Set Includes") return excelProduct.SetIncludes;
            if (specificationAttributeName == "Filling Material") return excelProduct.FillingMaterial;
            if (specificationAttributeName == "Comfort Level") return excelProduct.ComfortLevel;
            if (specificationAttributeName == "Sheet Type") return excelProduct.SheetType;
            if (specificationAttributeName == "Pack Size") return excelProduct.PackSize;
            if (specificationAttributeName == "Formation") return excelProduct.Formation;
            if (specificationAttributeName == "Target Use/Application") return excelProduct.TargetUseApplication;
            if (specificationAttributeName == "Target Skin Type") return excelProduct.TargetSkinType;
            if (specificationAttributeName == "UV Protection") return excelProduct.UVProtection;
            if (specificationAttributeName == "Battery Size") return excelProduct.BatterySize;
            if (specificationAttributeName == "Battery Size Unit") return excelProduct.BatterySizeUnit;
            if (specificationAttributeName == "Brand Compatibility") return excelProduct.BrandCompatibility;
            if (specificationAttributeName == "Connection Type") return excelProduct.ConnectionType;
            if (specificationAttributeName == "Case Type") return excelProduct.CaseType;
            if (specificationAttributeName == "Charging Type") return excelProduct.ChargingType;
            if (specificationAttributeName == "Phone Case Material") return excelProduct.PhoneCaseMaterial;
            if (specificationAttributeName == "Audio Headphone Type") return excelProduct.AudioHeadphoneType;
            if (specificationAttributeName == "Warranty Years") return excelProduct.WarrantyYears;
            if (specificationAttributeName == "Frame Colour") return excelProduct.FrameColour;
            if (specificationAttributeName == "Frame Colour Family") return excelProduct.FrameColourFamily;
            if (specificationAttributeName == "Lens Colour") return excelProduct.LensColour;
            if (specificationAttributeName == "Lens Colour Family") return excelProduct.LensColourFamily;
            if (specificationAttributeName == "Frame Shape/Style") return excelProduct.FrameShapeStyle;
            if (specificationAttributeName == "Lens Focal Type") return excelProduct.LensFocalType;
            if (specificationAttributeName == "Lens Magnification") return excelProduct.LensMagnification;
            if (specificationAttributeName == "Lens Type") return excelProduct.LensType;
            if (specificationAttributeName == "Width Profile") return excelProduct.WidthProfile;
            if (specificationAttributeName == "Upper Material") return excelProduct.UpperMaterial;
            if (specificationAttributeName == "Sole Material") return excelProduct.SoleMaterial;
            if (specificationAttributeName == "Heel Type") return excelProduct.HeelType;
            if (specificationAttributeName == "Heel Profile") return excelProduct.HeelProfile;
            if (specificationAttributeName == "Heel Height") return excelProduct.HeelHeight;
            if (specificationAttributeName == "Heel Height Unit") return excelProduct.HeelHeightUnit;
            if (specificationAttributeName == "Boot Shaft Height") return excelProduct.BootShaftHeight;
            if (specificationAttributeName == "Boot Shaft Height Unit") return excelProduct.BootShaftHeightUnit;
            if (specificationAttributeName == "Boot Circumference") return excelProduct.BootCircumference;
            if (specificationAttributeName == "Boot Circumference Unit") return excelProduct.BootCircumferenceUnit;
            if (specificationAttributeName == "Closure/Fastener") return excelProduct.ClosureFastener;
            if (specificationAttributeName == "Wardrobe Design") return excelProduct.WardrobeDesign;
            if (specificationAttributeName == "Upholstery Type") return excelProduct.UpholsteryType;
            if (specificationAttributeName == "Seat Filling") return excelProduct.SeatFilling;
            if (specificationAttributeName == "Seat Cushion") return excelProduct.SeatCushion;
            if (specificationAttributeName == "Wood Type") return excelProduct.WoodType;
            if (specificationAttributeName == "Wood Tone") return excelProduct.WoodTone;
            if (specificationAttributeName == "Shape") return excelProduct.Shape;
            if (specificationAttributeName == "Number of Drawers") return excelProduct.NumberofDrawers;
            if (specificationAttributeName == "Number of Doors") return excelProduct.NumberofDoors;
            if (specificationAttributeName == "Number of Shelves") return excelProduct.NumberofShelves;
            if (specificationAttributeName == "Number of Seats") return excelProduct.NumberofSeats;
            if (specificationAttributeName == "Number of Panels") return excelProduct.NumberofPanels;
            if (specificationAttributeName == "Installation") return excelProduct.Installation;
            if (specificationAttributeName == "Energy Used") return excelProduct.EnergyUsed;
            if (specificationAttributeName == "Additional Feature 1") return excelProduct.AdditionalFeature1;
            if (specificationAttributeName == "Additional Feature 2") return excelProduct.AdditionalFeature2;
            if (specificationAttributeName == "Additional Feature 3") return excelProduct.AdditionalFeature3;
            if (specificationAttributeName == "Pattern") return excelProduct.Pattern;
            if (specificationAttributeName == "Mats, Rugs & Carpet Design") return excelProduct.MatsRugsCarpetDesign;
            if (specificationAttributeName == "Technique") return excelProduct.Technique;
            if (specificationAttributeName == "Style of Curtain Lining") return excelProduct.StyleofCurtainLining;
            if (specificationAttributeName == "Dispenser Type") return excelProduct.DispenserType;
            if (specificationAttributeName == "Scents/Notes") return excelProduct.ScentsNotes;
            if (specificationAttributeName == "Aromatherapy Type") return excelProduct.AromatherapyType;
            if (specificationAttributeName == "Fine/Luxury Material") return excelProduct.FineLuxuryMaterial;
            if (specificationAttributeName == "Base Material Type") return excelProduct.BaseMaterialType;
            if (specificationAttributeName == "Stone/Gem") return excelProduct.StoneGem;
            if (specificationAttributeName == "Carat Weight") return excelProduct.CaratWeight;
            if (specificationAttributeName == "Closure/Fastening") return excelProduct.ClosureFastening;
            if (specificationAttributeName == "Product Features 1") return excelProduct.ProductFeatures1;
            if (specificationAttributeName == "Product Features 2") return excelProduct.ProductFeatures2;
            if (specificationAttributeName == "Product Features 3") return excelProduct.ProductFeatures3;
            if (specificationAttributeName == "Product Features 4") return excelProduct.ProductFeatures4;
            if (specificationAttributeName == "Product Features 5") return excelProduct.ProductFeatures5;
            if (specificationAttributeName == "Ink Colour Family") return excelProduct.InkColourFamily;
            if (specificationAttributeName == "Pen Material") return excelProduct.PenMaterial;
            if (specificationAttributeName == "Point or Nib Type") return excelProduct.PointorNibType;
            if (specificationAttributeName == "Point Size") return excelProduct.PointSize;
            if (specificationAttributeName == "Point Size Unit") return excelProduct.PointSizeUnit;
            if (specificationAttributeName == "Refillable") return excelProduct.Refillable;
            if (specificationAttributeName == "Watch Band Colour") return excelProduct.WatchBandColour;
            if (specificationAttributeName == "Watch Band Colour Family") return excelProduct.WatchBandColourFamily;
            if (specificationAttributeName == "Band Length") return excelProduct.BandLength;
            if (specificationAttributeName == "Band Length Unit") return excelProduct.BandLengthUnit;
            if (specificationAttributeName == "Watch Band Material") return excelProduct.WatchBandMaterial;
            if (specificationAttributeName == "Watch Dial/Face Type") return excelProduct.WatchDialFaceType;
            if (specificationAttributeName == "Dial/Face Diameter") return excelProduct.DialFaceDiameter;
            if (specificationAttributeName == "Dial/Face Diameter Unit") return excelProduct.DialFaceDiameterUnit;
            if (specificationAttributeName == "Watch Dial/Face Colour") return excelProduct.WatchDialFaceColour;
            if (specificationAttributeName == "Watch Dial/Face Colour Family") return excelProduct.WatchDialFaceColourFamily;
            if (specificationAttributeName == "Watch Movement") return excelProduct.WatchMovement;
            if (specificationAttributeName == "Watch Case Shape") return excelProduct.WatchCaseShape;
            if (specificationAttributeName == "Watch Band Closure") return excelProduct.WatchBandClosure;
            if (specificationAttributeName == "Interchangeable Dial/Face") return excelProduct.InterchangeableDialFace;
            if (specificationAttributeName == "Interchangeable Strap") return excelProduct.InterchangeableStrap;

            if (specificationAttributeName == "GTIN") return excelProduct.GTIN;
            if (specificationAttributeName == "Product Title") return excelProduct.ProductTitle;
            if (specificationAttributeName == "Partner SKU Unique") return excelProduct.PartnerSKUUnique;
            if (specificationAttributeName == "Feature/Bullet 1") return excelProduct.FeatureBullet1;
            if (specificationAttributeName == "Feature/Bullet 2") return excelProduct.FeatureBullet2;
            if (specificationAttributeName == "Feature/Bullet 3") return excelProduct.FeatureBullet3;
            if (specificationAttributeName == "Feature/Bullet 4") return excelProduct.FeatureBullet4;
            if (specificationAttributeName == "Feature/Bullet 5") return excelProduct.FeatureBullet5;
            if (specificationAttributeName == "Brand Name") return excelProduct.BrandName;
            if (specificationAttributeName == "Image URL 1") return excelProduct.ImageURL1;
            if (specificationAttributeName == "Image URL 2") return excelProduct.ImageURL2;
            if (specificationAttributeName == "Image URL 3") return excelProduct.ImageURL3;
            if (specificationAttributeName == "Image URL 4") return excelProduct.ImageURL4;
            if (specificationAttributeName == "Image URL 5") return excelProduct.ImageURL5;
            return "";
            
            
            
            
            
            

        }
    }
}
