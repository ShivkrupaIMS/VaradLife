
namespace Serene.Masters.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("Masters.SupplierType")]
    [BasedOnRow(typeof(Entities.SupplierTypeRow), CheckNames = true)]
    public class SupplierTypeColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 SupplierTypeId { get; set; }
        [EditLink]
        public String SupplierType { get; set; }
        public Boolean IsActive { get; set; }
    }
}