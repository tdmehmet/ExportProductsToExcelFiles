using System;
using System.Collections.Generic;

namespace ExportProductsToExcelFiles.BiggBrands
{
    public partial class PictureBinary
    {
        public int Id { get; set; }
        public byte[] BinaryData { get; set; }
        public int PictureId { get; set; }

        public virtual Picture Picture { get; set; }
    }
}
