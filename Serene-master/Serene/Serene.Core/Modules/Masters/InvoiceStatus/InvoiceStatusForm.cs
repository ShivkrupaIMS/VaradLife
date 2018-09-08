
namespace Serene.Masters.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Masters.InvoiceStatus")]
    [BasedOnRow(typeof(Entities.InvoiceStatusRow), CheckNames = true)]
    public class InvoiceStatusForm
    {
        public String InvoiceStatus { get; set; }
        public Boolean IsActive { get; set; }
    }
}