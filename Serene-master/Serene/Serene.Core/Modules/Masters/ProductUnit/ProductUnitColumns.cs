
namespace Serene.Masters.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("Masters.ProductUnit")]
    [BasedOnRow(typeof(Entities.ProductUnitRow), CheckNames = true)]
    public class ProductUnitColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 ProductUnitId { get; set; }
        [EditLink]
        public String ProductUnit { get; set; }
        public Boolean IsActive { get; set; }
    }
}