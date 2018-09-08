
namespace Serene.Northwind.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Northwind.ProductsNew")]
    [BasedOnRow(typeof(Entities.ProductsNewRow), CheckNames = true)]
    public class ProductsNewForm
    {
        public String ProductName { get; set; }
        public Int32 SupplierId { get; set; }
        public Int32 CategoryId { get; set; }
        public String QuantityPerUnit { get; set; }
        public Decimal UnitPrice { get; set; }
        public Int16 UnitsInStock { get; set; }
        public Int16 UnitsOnOrder { get; set; }
        public Int16 ReorderLevel { get; set; }
        public Boolean Discontinued { get; set; }
        public String ProductImage { get; set; }
        public Int32 Igst { get; set; }
        public Int32 Cgst { get; set; }
        public Int32 Sgst { get; set; }
    }
}