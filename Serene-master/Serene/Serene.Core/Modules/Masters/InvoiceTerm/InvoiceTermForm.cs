
namespace Serene.Masters.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Masters.InvoiceTerm")]
    [BasedOnRow(typeof(Entities.InvoiceTermRow), CheckNames = true)]
    public class InvoiceTermForm
    {
        public String InvoiceTerm { get; set; }
        public Boolean IsActive { get; set; }
    }
}