
namespace Serene.Masters.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Masters.SupplierType")]
    [BasedOnRow(typeof(Entities.SupplierTypeRow), CheckNames = true)]
    public class SupplierTypeForm
    {
        public String SupplierType { get; set; }
        public Boolean IsActive { get; set; }
    }
}