
namespace Serene.Masters.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("Masters.ProductDetails")]
    [BasedOnRow(typeof(Entities.ProductDetailsRow), CheckNames = true)]
    public class ProductDetailsColumns
    {
        [EditLink]
        public String Sku { get; set; }
        public String ProductUnit { get; set; }
        public Int32 PackageSize { get; set; }
        public Double PurchasePrice { get; set; }
        public Double SalePrice { get; set; }
        public Double Mrp { get; set; }
        public String PackageWeight { get; set; }
        public String ManufacturerManufacturerName { get; set; }
        public Int32 MinQuantity { get; set; }
        public Double Discount { get; set; }
        public String Description { get; set; }
        public Boolean IsActive { get; set; }
    }
}