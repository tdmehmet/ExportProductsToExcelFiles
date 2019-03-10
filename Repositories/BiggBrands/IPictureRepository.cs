using ExportProductsToExcelFiles.BiggBrands;

namespace ExportProductsToExcelFiles.Repositories.BiggBrands
{
    public interface IPictureRepository : IGenericRepository<Picture>
    {
        Picture FindPictureByResimUrl(string resimUrl);
    }
}
