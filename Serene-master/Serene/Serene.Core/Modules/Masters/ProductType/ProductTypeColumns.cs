
namespace Serene.Masters.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("Masters.ProductType")]
    [BasedOnRow(typeof(Entities.ProductTypeRow), CheckNames = true)]
    public class ProductTypeColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 ProductTypeId { get; set; }
        [EditLink]
        public String ProductType { get; set; }
        public Boolean IsActive { get; set; }
    }
}