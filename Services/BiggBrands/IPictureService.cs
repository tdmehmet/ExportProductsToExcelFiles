using System.Collections.Generic;
using ExportProductsToExcelFiles.BiggBrands;

namespace ExportProductsToExcelFiles.Services.BiggBrands
{
    public interface IPictureService
    {
        List<Picture> FindAllPictures();
        void InsertOrUpdatePictureProductMapping(Product product, string pictures);
    }
}
