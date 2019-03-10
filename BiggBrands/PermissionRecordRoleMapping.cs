using System;
using System.Collections.Generic;

namespace ExportProductsToExcelFiles.BiggBrands
{
    public partial class PermissionRecordRoleMapping
    {
        public int PermissionRecordId { get; set; }
        public int CustomerRoleId { get; set; }

        public virtual CustomerRole CustomerRole { get; set; }
        public virtual PermissionRecord PermissionRecord { get; set; }
    }
}
