using ExportProductsToExcelFiles.BiggBrands;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace ExportProductsToExcelFiles.Utils
{
    public static class CategoryUtil
    {
        public static UrlRecord GetCategoryUrlRecordForUpdate(List<UrlRecord> urlRecords, Category category, List<UrlRecord> existingUpdateUrlRecords)
        {
            UrlRecord urlRecord = urlRecords.Where(ur => ur.EntityId == category.Id && ur.EntityName == "category").FirstOrDefault();
            UrlRecord existingUpdateUrlRecord = existingUpdateUrlRecords.Where(ur => ur.EntityId == category.Id && ur.EntityName == "Category").FirstOrDefault();
            if (urlRecord != null && existingUpdateUrlRecord == null)
            {
                urlRecord.Slug = UrlUtil.ModifyUrl(category.Name);
                urlRecord.IsActive = true;
                urlRecord.LanguageId = 0;
                return urlRecord;
            }

            return null;
        }

        public static UrlRecord GetCategoryUrlRecordForInsert(List<UrlRecord> urlRecords, Category category, List<UrlRecord> existingInsertUrlRecords)
        {
            UrlRecord existingInsertUrlRecord = existingInsertUrlRecords.Where(ur => ur.EntityId == category.Id && ur.EntityName == "Category").FirstOrDefault();
            if (existingInsertUrlRecord == null)
            {
                return new UrlRecord()
                {
                    EntityId = category.Id,
                    EntityName = "Category",
                    Slug = UrlUtil.ModifyUrl(category.Name),
                    IsActive = true,
                    LanguageId = 0,
                };
            }
            else
            {
                return null;
            }
        }
    }
}
