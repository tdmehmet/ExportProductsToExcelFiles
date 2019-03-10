using System;
using System.Collections.Generic;
using ExportProductsToExcelFiles.Repositories.BiggBrands;
using ExportProductsToExcelFiles.BiggBrands;
using ExportProductsToExcelFiles.Utils;

namespace ExportProductsToExcelFiles.Services.BiggBrands
{
	public class ManufacturerService : IManufacturerService
    {
        private readonly IManufacturerRepository _thyMenaManufacturerRepository;
        private readonly IProductManufacturerMappingRepository _thyMenaProductManufacturerMappingRepository;
        private readonly IUrlRecordRepository _thyMenaUrlRecordRepository;

        public ManufacturerService(
            IManufacturerRepository thyMenaManufacturerRepository,
            IProductManufacturerMappingRepository thyMenaProductManufacturerMappingRepository,
            IUrlRecordRepository thyMenaUrlRecordRepository)
        {
            _thyMenaManufacturerRepository = thyMenaManufacturerRepository;
            _thyMenaProductManufacturerMappingRepository = thyMenaProductManufacturerMappingRepository;
            _thyMenaUrlRecordRepository = thyMenaUrlRecordRepository;
        }

        public Manufacturer AddManuFacturer(Manufacturer manufacturer)
        {
            Manufacturer insertedManufacturer = _thyMenaManufacturerRepository.Add(manufacturer);
            _thyMenaManufacturerRepository.Save();
            return insertedManufacturer;
        }

        public List<Manufacturer> FindAllManufacturers()
        {
            return _thyMenaManufacturerRepository.FindAllItems();
        }

        public void InsertOrUpdateProductManufacturerMapping(Product product, string marka)
        {
            Manufacturer manufacturer = _thyMenaManufacturerRepository.FindManufacturerByName(marka);
            if(manufacturer != null) {
                ProductManufacturerMapping productManufacturerMapping = 
                    _thyMenaProductManufacturerMappingRepository.FindByProductId(product.Id);
                if(productManufacturerMapping == null) {
                    _thyMenaProductManufacturerMappingRepository.Add(new ProductManufacturerMapping()
                    {
                        ProductId = product.Id,
                        ManufacturerId = manufacturer.Id,
                        IsFeaturedProduct = false,
                        DisplayOrder = 0
                    });
                    _thyMenaManufacturerRepository.Save();
                }
            }
            else {
                manufacturer = _thyMenaManufacturerRepository.Add(new Manufacturer()
                {
                    Name = marka,
                    Description = marka,
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
                });
                _thyMenaManufacturerRepository.Save();
                _thyMenaProductManufacturerMappingRepository.Add(new ProductManufacturerMapping()
                {
                    ProductId = product.Id,
                    ManufacturerId = manufacturer.Id,
                    IsFeaturedProduct = false,
                    DisplayOrder = 0
                });
                _thyMenaProductManufacturerMappingRepository.Save();
            }
            UrlRecord urlRecord = _thyMenaUrlRecordRepository.FindUrlRecordByEntityIdEntityName(manufacturer.Id, "Manufacturer");
            if (urlRecord == null)
            {
                _thyMenaUrlRecordRepository.Add(new UrlRecord()
                {
                    EntityId = manufacturer.Id,
                    EntityName = "Manufacturer",
                    Slug = UrlUtil.ModifyUrl(marka),
                    IsActive = true,
                    LanguageId = 0,
                });
                _thyMenaUrlRecordRepository.Save();
            }
            else
            {
                urlRecord.Slug = UrlUtil.ModifyUrl(marka);
                urlRecord.IsActive = true;
                urlRecord.LanguageId = 0;
                _thyMenaUrlRecordRepository.Update(urlRecord);
                _thyMenaUrlRecordRepository.Save();
            }
        }
    }
}
