using System;
using System.Collections.Generic;
using ExportProductsToExcelFiles.Repositories.BiggBrands;
using ExportProductsToExcelFiles.BiggBrands;

namespace ExportProductsToExcelFiles.Services.BiggBrands
{
    public class PictureService : IPictureService
    {
        private readonly IPictureRepository _thyMenaPictureRepository;
        private readonly IProductPictureMappingRepository _thyMenaProductPictureMappingRepository;

        public PictureService(IPictureRepository thyMenaPictureRepository,
                                     IProductPictureMappingRepository thyMenaProductPictureMappingRepository)
        {
            _thyMenaPictureRepository = thyMenaPictureRepository;
            _thyMenaProductPictureMappingRepository = thyMenaProductPictureMappingRepository;
        }

        public List<Picture> FindAllPictures()
        {
            return _thyMenaPictureRepository.FindAllItems();
        }

        public void InsertOrUpdatePictureProductMapping(Product product, string pictures) {
            string[] imageArray = pictures?.Split('#');
            int displayOrder = 0;

            if (imageArray != null)
            {
                DeleteAllProductImageMappings(product.Id);

                foreach (string image in imageArray)
                {
                    Picture picture = _thyMenaPictureRepository.FindPictureByResimUrl(image);
                    if (picture == null)
                    {
                        picture = _thyMenaPictureRepository.Add(new Picture()
                        {
                            PictureBinary = null,
                            MimeType = "image/jpeg",
                            SeoFilename = image,
                            IsNew = false,
                        });
                    }

                    _thyMenaProductPictureMappingRepository.Add(new ProductPictureMapping()
                    {
                        ProductId = product.Id,
                        PictureId = picture.Id,
                        DisplayOrder = displayOrder,
                    });
                    _thyMenaPictureRepository.Save();
                    displayOrder++;
                }
            }
        }

        private void DeleteAllProductImageMappings(int productId) {
            List<ProductPictureMapping> notUpdatedImageList = 
                _thyMenaProductPictureMappingRepository.FindAllProductPictureMappingsByProductId(productId);
            foreach(ProductPictureMapping productPictureMapping in notUpdatedImageList) {
                _thyMenaProductPictureMappingRepository.Delete(productPictureMapping);
                _thyMenaProductPictureMappingRepository.Save();
            }
        }
    }
}
