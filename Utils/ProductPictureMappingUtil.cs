using System.Linq;
using System.Collections.Generic;
using ExportProductsToExcelFiles.BiggBrands;


namespace ExportProductsToExcelFiles.Utils
{
    public static class ProductPictureMappingUtil
    {

        public static List<ProductPictureMapping> GenerateProductPictureMappings(string pictureSeoFileName, List<Picture> pictures, Product product)
        {
           if(!string.IsNullOrEmpty(pictureSeoFileName)) { 
                List<ProductPictureMapping> productPictureMappingList = new List<ProductPictureMapping>();
                int displayOrder = 0;
                Picture picture = pictures.Where(p => p.SeoFilename == pictureSeoFileName).FirstOrDefault();
                if (picture == null)
                {
                    picture = new Picture()
                    {
                        PictureBinary = null,
                        MimeType = "image/jpeg",
                        SeoFilename = pictureSeoFileName,
                        IsNew = false,
                    };
                }
                ProductPictureMapping productPictureMapping = productPictureMappingList
                    .Where(ppm=> ppm.PictureId == picture.Id && ppm.ProductId == product.Id).FirstOrDefault();

                if(productPictureMapping == null) { 
                    productPictureMappingList.Add(new ProductPictureMapping()
                    {
                        ProductId = product.Id,
                        PictureId = picture.Id,
                        DisplayOrder = displayOrder,
                        Product = product,
                        Picture = picture
                    });
                }else
                {
                    productPictureMappingList.Add(productPictureMapping);
                }
                displayOrder++;
                return productPictureMappingList;
            }else
            {
                return null;
            }
        }
    }
}
