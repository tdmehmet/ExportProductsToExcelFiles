using System;
using System.Collections.Generic;

namespace ExportProductsToExcelFiles.BiggBrands
{
    public partial class CustomerAttribute
    {
        public CustomerAttribute()
        {
            CustomerAttributeValue = new HashSet<CustomerAttributeValue>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsRequired { get; set; }
        public int AttributeControlTypeId { get; set; }
        public int DisplayOrder { get; set; }

        public virtual ICollection<CustomerAttributeValue> CustomerAttributeValue { get; set; }
    }
}
