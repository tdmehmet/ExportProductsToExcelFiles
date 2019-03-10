using System;
using System.Linq;
using System.Collections.Generic;
using ExportProductsToExcelFiles.AppModels;
using ExportProductsToExcelFiles.BiggBrands;

namespace ExportProductsToExcelFiles.Utils
{
    public static class ProductUtil
    {

        public static AppProduct ConvertExcelProductToAppProduct(ExcelProduct excelProduct)
        {

            return new AppProduct()
            {
                Name = excelProduct.ProductTitle?.TrimStart().TrimEnd(),
                LogoKodu = excelProduct.PartnerSKUUnique,
                KatalogKodu = excelProduct.PartnerSKUUnique,
                CategoryID = 325,
                Marka = excelProduct.BrandName,
                //Stok = ConversionUtil.ConvertStringToIntNotParsable0(excelProduct.Quantity_Stock),
                BulletPoint1 = excelProduct.FeatureBullet1,
                BulletPoint2 = excelProduct.FeatureBullet2,
                BulletPoint3 = excelProduct.FeatureBullet3,
                BulletPoint4 = excelProduct.FeatureBullet4,
                BulletPoint5 = excelProduct.FeatureBullet5,
                GTIN = excelProduct.GTIN
            };
        }


        public static Product CreateUpdateProductModelFromExcelProduct(Product product, ExcelProduct excelProduct) {
            product.Name = string.IsNullOrEmpty(excelProduct.ProductTitle) ? product.Name : excelProduct.ProductTitle.TrimEnd().TrimStart();
            product.UpdatedOnUtc = DateTime.Now;
            product.FullDescription = string.IsNullOrEmpty(excelProduct.LongDescription) ? product.FullDescription : excelProduct.ProductTitle.TrimEnd().TrimStart();
            product.Gtin = excelProduct.GTIN;
            product.BulletPoint1 = excelProduct.FeatureBullet1;
            product.BulletPoint2 = excelProduct.FeatureBullet2;
            product.BulletPoint3 = excelProduct.FeatureBullet3;
            product.BulletPoint4 = excelProduct.FeatureBullet4;
            product.BulletPoint5 = excelProduct.FeatureBullet5;
            return product;
        }
        public static Product CreateInsertProductModel(ExcelProduct excelProduct)
        {
            Product product = new Product();
            product.ProductTypeId = 5;
            product.ParentGroupedProductId = 0;
            product.VisibleIndividually = false;

            product.Name = excelProduct.ProductTitle?.TrimEnd().TrimStart();
            product.ProductTemplateId = 1;

            product.VendorId = 0;
            product.ShowOnHomePage = false;
            product.AllowCustomerReviews =  false;
            product.ApprovedRatingSum =  0;
            product.NotApprovedRatingSum =  0;
            product.ApprovedTotalReviews =  0;
            product.NotApprovedTotalReviews =  0;
            product.SubjectToAcl =  false;
            product.LimitedToStores =  false;
            product.IsGiftCard =  false;
            product.GiftCardTypeId =  0;
            product.RequireOtherProducts =  false;
            product.AutomaticallyAddRequiredProducts =  false;
            product.IsDownload =  false;
            product.DownloadId =  0;
            product.UnlimitedDownloads =  false;
            product.MaxNumberOfDownloads =  0;
            product.DownloadActivationTypeId =  0;
            product.HasSampleDownload =  false;
            product.SampleDownloadId =  0;
            product.HasUserAgreement =  false;
            product.IsRecurring =  false;
            product.RecurringCycleLength =  0;
            product.RecurringCyclePeriodId =  0;
            product.RecurringTotalCycles =  0;
            product.IsRental =  false;
            product.RentalPriceLength =  0;
            product.RentalPricePeriodId =  0;
            product.IsShipEnabled =  false;
            product.IsFreeShipping =  false;
            product.ShipSeparately =  false;
            product.AdditionalShippingCharge =  0;
            product.DeliveryDateId =  0;
            product.IsTaxExempt =  false;
            product.TaxCategoryId =  0;
            product.IsTelecommunicationsOrBroadcastingOrElectronicServices =  false;
            product.ManageInventoryMethodId =  0;
            product.ProductAvailabilityRangeId =  0;
            product.UseMultipleWarehouses =  false;
            product.WarehouseId =  0;
            product.StockQuantity =  20;
            product.DisplayStockAvailability =  false;
            product.DisplayStockQuantity =  false;
            product.MinStockQuantity =  20;
            product.LowStockActivityId =  0;
            product.NotifyAdminForQuantityBelow =  1;
            product.BackorderModeId =  0;
            product.AllowBackInStockSubscriptions =  false;
            product.OrderMinimumQuantity =  1;
            product.OrderMaximumQuantity =  100;
            product.AllowAddingOnlyExistingAttributeCombinations = false;
            product.NotReturnable =  false;
            product.DisableBuyButton =  false;
            product.DisableWishlistButton =  false;
            product.AvailableForPreOrder =  false;
            product.CallForPrice =  false;
            product.Price =  0;
            product.OldPrice =  0;
            product.ProductCost =  0;
            product.CustomerEntersPrice =  false;
            product.MinimumCustomerEnteredPrice =  0;
            product.MaximumCustomerEnteredPrice =  0;
            product.BasepriceEnabled =  false;
            product.BasepriceAmount = 0;
            product.BasepriceUnitId = 0;
            product.BasepriceBaseAmount =  0;
            product.BasepriceBaseUnitId =  0;
            product.MarkAsNew =  false;
            product.HasTierPrices =  false;
            product.HasDiscountsApplied =  false;
            product.Weight =  0;
            product.Length =  0;
            product.Width =  0;
            product.Height =  0;
            product.DisplayOrder =  0;
            product.Published =  true;
            product.Deleted =  false;
            product.CreatedOnUtc =  DateTime.Now;
            product.UpdatedOnUtc = DateTime.Now;
            product.ParcelDesi =  0;
            product.ParcelWeight =  0;
            product.AbroadDesi =  0;
            product.Sku = excelProduct.PartnerSKUUnique;
            product.ManufacturerPartNumber = excelProduct.GTIN;
            product.FullDescription = product.FullDescription?.TrimEnd().TrimStart();
            product.Gtin = excelProduct.GTIN;
            product.BulletPoint1 = excelProduct.FeatureBullet1;
            product.BulletPoint2 = excelProduct.FeatureBullet2;
            product.BulletPoint3 = excelProduct.FeatureBullet3;
            product.BulletPoint4 = excelProduct.FeatureBullet4;
            product.BulletPoint5 = excelProduct.FeatureBullet5;
            return product;
        }

    }
}
