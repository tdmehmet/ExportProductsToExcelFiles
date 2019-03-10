using System.Collections.Generic;
using ExportProductsToExcelFiles.Repositories.BiggBrands;
using ExportProductsToExcelFiles.BiggBrands;
using ExportProductsToExcelFiles.Utils;

namespace ExportProductsToExcelFiles.Services.BiggBrands
{
    public class UrlRecordService : IUrlRecordService
    {
        private readonly IUrlRecordRepository _thyMenaUrlRecordRepository;

        public UrlRecordService(IUrlRecordRepository thyMenaUrlRecordRepository)
        {
            _thyMenaUrlRecordRepository = thyMenaUrlRecordRepository;
        }

        public List<UrlRecord> FindAllUrlRecords()
        {
            return _thyMenaUrlRecordRepository.FindAllItems();
        }

        public void SaveURLRecords(List<UrlRecord> urlRecords) {
            _thyMenaUrlRecordRepository.AddRange(urlRecords);
            _thyMenaUrlRecordRepository.Save();
        }

        public void UpdateURLRecords(List<UrlRecord> urlRecords)
        {
            _thyMenaUrlRecordRepository.UpdateRange(urlRecords);
            _thyMenaUrlRecordRepository.Save();
        }

        public void UpdateURLForProduct(Product product) {
            string slug = UrlUtil.ModifyUrl(product.Name);
            List<UrlRecord> urlRecordsList = _thyMenaUrlRecordRepository.FindUrlRecordsByEntityIdEntityName(product.Id, "Product");
            if(urlRecordsList == null || urlRecordsList.Count == 0) {
                string tmpSlug = "";
                List <UrlRecord> urlRecords = _thyMenaUrlRecordRepository.FindSameUrlRecordsForDifferentProducts(
                    slug, "Product", product.Id);
                if(urlRecords!= null && urlRecords.Count > 0) {
                    for (int i = 2; i < 6; i++) {
                         tmpSlug = slug + i.ToString();
                        urlRecords = _thyMenaUrlRecordRepository.FindSameUrlRecordsForDifferentProducts(
                            tmpSlug, "Product", product.Id);
                        if(urlRecords!= null && urlRecords.Count > 0 ) {
                            continue;
                        }else {
                            break;
                        }
                    }
                }
                UrlRecord urlRecord = _thyMenaUrlRecordRepository.FindUrlRecordBySlugEntityName(tmpSlug, "Product");
                if(urlRecord == null) {
                    _thyMenaUrlRecordRepository.Add(new UrlRecord()
                    {
                        EntityId = product.Id,
                        EntityName = "Product",
                        Slug = tmpSlug,
                        IsActive = true,
                        LanguageId = 0
                    });
                    _thyMenaUrlRecordRepository.Save();
                }else {
                    urlRecord.EntityId = product.Id;
                    _thyMenaUrlRecordRepository.Update(urlRecord);
                    _thyMenaUrlRecordRepository.Save();
                }
            }else {
                UrlRecord urlRecord = urlRecordsList[0];
                urlRecord.Slug = slug;
                urlRecord.IsActive = true;
                urlRecord.LanguageId = 0;
                _thyMenaUrlRecordRepository.Update(urlRecord);
                _thyMenaUrlRecordRepository.Save();
            }

        }

        public List<UrlRecord> FindUrlRecordsForProductToSave(Product product)
        {
            string slug = UrlUtil.ModifyUrl(product.Name);
            List<UrlRecord> urlRecordsList = _thyMenaUrlRecordRepository.FindUrlRecordsByEntityIdEntityName(product.Id, "Product");
            List<UrlRecord> urlRecordsToSave = new List<UrlRecord>();
            if (urlRecordsList == null || urlRecordsList.Count == 0)
            {
                string tmpSlug = "";
                List<UrlRecord> urlRecords = _thyMenaUrlRecordRepository.FindSameUrlRecordsForDifferentProducts(
                    slug, "Product", product.Id);
                if (urlRecords != null && urlRecords.Count > 0)
                {
                    for (int i = 2; i < 6; i++)
                    {
                        tmpSlug = slug + i.ToString();
                        urlRecords = _thyMenaUrlRecordRepository.FindSameUrlRecordsForDifferentProducts(
                            tmpSlug, "Product", product.Id);
                        if (urlRecords != null && urlRecords.Count > 0)
                        {
                            continue;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
                UrlRecord urlRecord = _thyMenaUrlRecordRepository.FindUrlRecordBySlugEntityName(tmpSlug, "Product");
                if (urlRecord == null)
                {
                    urlRecordsToSave.Add(new UrlRecord()
                    {
                        EntityId = product.Id,
                        EntityName = "Product",
                        Slug = tmpSlug,
                        IsActive = true,
                        LanguageId = 0
                    });
                }
                
            }
            return urlRecordsToSave;
        }

        public List<UrlRecord> FindUrlRecordsForProductToUpdate(Product product)
        {
            string slug = UrlUtil.ModifyUrl(product.Name);
            List<UrlRecord> urlRecordsList = _thyMenaUrlRecordRepository.FindUrlRecordsByEntityIdEntityName(product.Id, "Product");
            List<UrlRecord> urlRecordsToUpdate = new List<UrlRecord>();
            if (urlRecordsList != null && urlRecordsList.Count > 0)
            {
                UrlRecord urlRecord = urlRecordsList[0];
                urlRecord.Slug = slug;
                urlRecord.IsActive = true;
                urlRecord.LanguageId = 0;
                urlRecordsToUpdate.Add(urlRecord);
            }else
            {
                string tmpSlug = "";
                List<UrlRecord> urlRecords = _thyMenaUrlRecordRepository.FindSameUrlRecordsForDifferentProducts(
                    slug, "Product", product.Id);
                if (urlRecords != null && urlRecords.Count > 0)
                {
                    for (int i = 2; i < 6; i++)
                    {
                        tmpSlug = slug + i.ToString();
                        urlRecords = _thyMenaUrlRecordRepository.FindSameUrlRecordsForDifferentProducts(
                            tmpSlug, "Product", product.Id);
                        if (urlRecords != null && urlRecords.Count > 0)
                        {
                            continue;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
                UrlRecord urlRecord = _thyMenaUrlRecordRepository.FindUrlRecordBySlugEntityName(tmpSlug, "Product");
                if (urlRecord == null)
                {
                    urlRecord.EntityId = product.Id;
                    urlRecordsToUpdate.Add(urlRecord);
                }
            }
            return urlRecordsToUpdate;
        }


        public UrlRecord GenerateUrlRecordForProduct(Product product) {
            return new UrlRecord()
            {
                EntityId = product.Id,
                EntityName = "Product",
                Slug = UrlUtil.ModifyUrl(product.Name),
                IsActive = true,
                LanguageId = 0
            };
        }


    }
}
