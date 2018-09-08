
namespace Serene.Masters.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("Masters.Hsnsac")]
    [BasedOnRow(typeof(Entities.HsnsacRow), CheckNames = true)]
    public class HsnsacColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 HsnsacId { get; set; }
        [EditLink]
        public String HsnsacNo { get; set; }
        public Double TaxRate { get; set; }
        public Boolean IsActive { get; set; }
    }
}