
namespace Serene.Masters.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Masters.ProductDetails")]
    [BasedOnRow(typeof(Entities.ProductDetailsRow), CheckNames = true)]
    public class ProductDetailsForm
    {
        public String Sku { get; set; }
        public Int32 ProductUnitId { get; set; }
        public Int32 PackageSize { get; set; }
        public Double PurchasePrice { get; set; }
        public Double SalePrice { get; set; }
        public Double Mrp { get; set; }
        public String PackageWeight { get; set; }
        public Int32 ManufacturerId { get; set; }
        public Int32 MinQuantity { get; set; }
        public Double Discount { get; set; }
        public String Description { get; set; }
        public Boolean IsActive { get; set; }
    }
}