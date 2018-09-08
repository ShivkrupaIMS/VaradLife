
namespace Serene.Masters.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("Masters.InvoiceStatus")]
    [BasedOnRow(typeof(Entities.InvoiceStatusRow), CheckNames = true)]
    public class InvoiceStatusColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 InvoiceStatusId { get; set; }
        [EditLink]
        public String InvoiceStatus { get; set; }
        public Boolean IsActive { get; set; }
    }
}