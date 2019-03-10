using System;
using System.Collections.Generic;
using ExportProductsToExcelFiles.Repositories.BiggBrands;
using ExportProductsToExcelFiles.BiggBrands;

namespace ExportProductsToExcelFiles.Services.BiggBrands
{
    public class SMPictureService : ISMPictureService
    {
        private readonly ISMPictureRepository _smPictureRepository;
        private readonly IProductPictureMappingRepository _thyMenaProductPictureMappingRepository;

        public SMPictureService(ISMPictureRepository smPictureRepository)
        {
            _smPictureRepository = smPictureRepository;
        }

        public List<Picture_SMProductDb> FindAllPictures()
        {
            return _smPictureRepository.FindAllItems();
        }

        public void DeleteSMPicture(Picture_SMProductDb picture)
        {
            _smPictureRepository.Delete(picture);
            _smPictureRepository.Save();
        }
    }
}
