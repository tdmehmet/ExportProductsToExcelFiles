using System;
using System.Collections.Generic;

namespace ExportProductsToExcelFiles.BiggBrands
{
    public partial class ProductProductSourceMapping
    {
        public int ProductId { get; set; }
        public int ProductSourceId { get; set; }

        public virtual Product Product { get; set; }
        public virtual ProductSource ProductSource { get; set; }
    }
}
