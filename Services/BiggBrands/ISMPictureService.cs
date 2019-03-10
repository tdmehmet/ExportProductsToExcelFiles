using System.Collections.Generic;
using ExportProductsToExcelFiles.BiggBrands;

namespace ExportProductsToExcelFiles.Services.BiggBrands
{
    public interface ISMPictureService
    {
        List<Picture_SMProductDb> FindAllPictures();
        void DeleteSMPicture(Picture_SMProductDb picture);
    }
}
