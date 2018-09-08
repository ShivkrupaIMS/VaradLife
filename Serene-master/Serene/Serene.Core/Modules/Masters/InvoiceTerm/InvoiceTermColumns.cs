
namespace Serene.Masters.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("Masters.InvoiceTerm")]
    [BasedOnRow(typeof(Entities.InvoiceTermRow), CheckNames = true)]
    public class InvoiceTermColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 InvoiceTermId { get; set; }
        [EditLink]
        public String InvoiceTerm { get; set; }
        public Boolean IsActive { get; set; }
    }
}