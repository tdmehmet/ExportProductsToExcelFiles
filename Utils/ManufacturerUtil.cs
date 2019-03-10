using ExportProductsToExcelFiles.BiggBrands;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ExportProductsToExcelFiles.Utils
{
    public static class ManufacturerUtil
    {
        public static Manufacturer CreateManufacturerByBrand(string brand)
        {
            return new Manufacturer()
            {
                Name = brand,
                Description = brand,
                ManufacturerTemplateId = 1,
                MetaKeywords = null,
                MetaDescription = null,
                MetaTitle = null,
                PictureId = 0,
                PageSize = 12,
                AllowCustomersToSelectPageSize = false,
                PageSizeOptions = "4, 2, 8, 12",
                PriceRanges = null,
                Published = true,
                Deleted = false,
                DisplayOrder = 0,
                CreatedOnUtc = DateTime.Now,
                UpdatedOnUtc = DateTime.Now,
                SubjectToAcl = false,
                LimitedToStores = false
            };
        }

        public static UrlRecord GetManufacturerUrlRecordForUpdate(List<UrlRecord> urlRecords, int manufacturerId, string brand, List<UrlRecord> existingUpdateUrlRecords)
        {

            UrlRecord urlRecord = urlRecords.Where(ur => ur.EntityId == manufacturerId && ur.EntityName == "Manufacturer").FirstOrDefault();
            UrlRecord existingUpdateUrlRecord = existingUpdateUrlRecords.Where(ur => ur.EntityId == manufacturerId && ur.EntityName == "Manufacturer").FirstOrDefault();
            if (urlRecord != null && existingUpdateUrlRecord == null)
            {
                urlRecord.Slug = UrlUtil.ModifyUrl(brand);
                urlRecord.IsActive = true;
                urlRecord.LanguageId = 0;
                return urlRecord;
            }

            return null;

        }
        public static UrlRecord GetManufacturerUrlRecordForInsert(List<UrlRecord> urlRecords, int manufacturerId, string brand, List<UrlRecord> existingInsertUrlRecords)
        {
            UrlRecord existingInsertUrlRecord = existingInsertUrlRecords.Where(ur => ur.EntityId == manufacturerId && ur.EntityName == "Manufacturer").FirstOrDefault();
            if (existingInsertUrlRecord == null)
            {
                return new UrlRecord()
                {
                    EntityId = manufacturerId,
                    EntityName = "Manufacturer",
                    Slug = UrlUtil.ModifyUrl(brand),
                    IsActive = true,
                    LanguageId = 0,
                };
            }else {
                return null;
            }
        }
    }
}
