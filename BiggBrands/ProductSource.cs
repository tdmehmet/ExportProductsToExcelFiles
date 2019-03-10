using System;
using System.Collections.Generic;

namespace ExportProductsToExcelFiles.BiggBrands
{
    public partial class ProductSource
    {
        public ProductSource()
        {
            ProductProductSourceMapping = new HashSet<ProductProductSourceMapping>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string FullName { get; set; }
        public string ContactName { get; set; }
        public string ContactEmail { get; set; }
        public string ContactPhone { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public DateTime CreatedOnUtc { get; set; }
        public DateTime? UpdatedOnUtc { get; set; }

        public virtual ICollection<ProductProductSourceMapping> ProductProductSourceMapping { get; set; }
    }
}
