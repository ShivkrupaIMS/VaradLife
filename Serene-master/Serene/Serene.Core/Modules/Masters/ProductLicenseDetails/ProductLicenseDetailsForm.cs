
namespace Serene.Masters.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Masters.ProductLicenseDetails")]
    [BasedOnRow(typeof(Entities.ProductLicenseDetailsRow), CheckNames = true)]
    public class ProductLicenseDetailsForm
    {
        public Int32 LicenseTypeId { get; set; }
        public Boolean IsActive { get; set; }
    }
}