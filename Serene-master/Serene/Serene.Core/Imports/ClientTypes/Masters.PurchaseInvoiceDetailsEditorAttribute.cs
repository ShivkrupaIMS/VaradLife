using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace Serene.Masters
{
    public partial class PurchaseInvoiceDetailsEditorAttribute : CustomEditorAttribute
    {
        public const string Key = "Serene.Masters.PurchaseInvoiceDetailsEditor";

        public PurchaseInvoiceDetailsEditorAttribute()
            : base(Key)
        {
        }
    }
}
