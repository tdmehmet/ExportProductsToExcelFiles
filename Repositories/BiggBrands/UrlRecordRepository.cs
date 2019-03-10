using System.Collections.Generic;
using System.Linq;
using ExportProductsToExcelFiles.Config;
using ExportProductsToExcelFiles.BiggBrands;

namespace ExportProductsToExcelFiles.Repositories.BiggBrands
{
    public class UrlRecordRepository : GenericRepository<UrlRecord>, IUrlRecordRepository
    {
        public UrlRecordRepository(BiggBrandsContext biggBrandsContext) : base(biggBrandsContext)
        {
        }

        public UrlRecord FindUrlRecordByEntityIdEntityName(int entityId, string entityName)
        {
            return this._entities.UrlRecord.Where(urlRecord => urlRecord.EntityId == entityId && 
                                           urlRecord.EntityName == entityName).FirstOrDefault();
        }

        public List<UrlRecord> FindSameUrlRecordsForDifferentProducts(string slug, string entityName, int entityId) {
            return this._entities.UrlRecord.Where(urlRecord => urlRecord.Slug == slug &&
                                                                        urlRecord.EntityName == entityName &&
                                                                        urlRecord.EntityId != entityId).ToList();
        }

        public List<UrlRecord> FindUrlRecordsByEntityIdEntityName(int entityId, string entityName) {
            return this._entities.UrlRecord.Where(urlRecord => urlRecord.EntityName == entityName &&
                                                               urlRecord.EntityId != entityId).ToList();
        }

        public UrlRecord FindUrlRecordBySlugEntityName(string slug, string entityName)
        {
            return this._entities.UrlRecord.Where(urlRecord => urlRecord.Slug == slug &&
                                           urlRecord.EntityName == entityName).FirstOrDefault();
        }

    }
}
