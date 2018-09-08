
namespace Serene.Masters.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Masters.Hsnsac")]
    [BasedOnRow(typeof(Entities.HsnsacRow), CheckNames = true)]
    public class HsnsacForm
    {
        public String HsnsacNo { get; set; }
        public Double TaxRate { get; set; }
        public Boolean IsActive { get; set; }
    }
}