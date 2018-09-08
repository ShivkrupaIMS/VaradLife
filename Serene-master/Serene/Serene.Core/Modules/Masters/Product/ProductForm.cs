
namespace Serene.Masters.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Masters.Product")]
    [BasedOnRow(typeof(Entities.ProductRow), CheckNames = true)]
    public class ProductForm
    {
        public Int32 HsnSacId { get; set; }
        public String ProductName { get; set; }
        public Int32 ProductTypeId { get; set; }
        public String Description { get; set; }
        public String Ingredient { get; set; }
        public Double Igst { get; set; }
        public Double Cgst { get; set; }
        public Double Sgst { get; set; }
        public String Comment { get; set; }
        public Boolean IsActive { get; set; }

        [ProductDetailsEditor]
        public List<Entities.ProductDetailsRow> ProductDetailsList { get; set; }

        [ProductLicenseDetailsEditor]
        public List<Entities.ProductLicenseDetailsRow> LicenseList { get; set; }
    }
}