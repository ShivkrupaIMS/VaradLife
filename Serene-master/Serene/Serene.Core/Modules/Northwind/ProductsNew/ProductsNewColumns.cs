
namespace Serene.Northwind.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("Northwind.ProductsNew")]
    [BasedOnRow(typeof(Entities.ProductsNewRow), CheckNames = true)]
    public class ProductsNewColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 ProductId { get; set; }
        [EditLink]
        public String ProductName { get; set; }
        public String SupplierCompanyName { get; set; }
        public String CategoryCategoryName { get; set; }
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