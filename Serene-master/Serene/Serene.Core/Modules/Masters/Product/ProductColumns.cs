
namespace Serene.Masters.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("Masters.Product")]
    [BasedOnRow(typeof(Entities.ProductRow), CheckNames = true)]
    public class ProductColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 ProductId { get; set; }
        public String HsnSacHsnsacNo { get; set; }
        [EditLink]
        public String ProductName { get; set; }
        public String ProductType { get; set; }
        public String Description { get; set; }
        public String Ingredient { get; set; }
        public Double Igst { get; set; }
        public Double Cgst { get; set; }
        public Double Sgst { get; set; }
        public String Comment { get; set; }
        public Boolean IsActive { get; set; }
    }
}