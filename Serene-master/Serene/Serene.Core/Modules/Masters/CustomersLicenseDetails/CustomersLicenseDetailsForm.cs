
namespace Serene.Masters.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Masters.CustomersLicenseDetails")]
    [BasedOnRow(typeof(Entities.CustomersLicenseDetailsRow), CheckNames = true)]
    public class CustomersLicenseDetailsForm
    {
        public Int32 LicenseTypeId { get; set; }
        public String LicenseNo { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime ValidTo { get; set; }
        public Boolean IsActive { get; set; }
    }
}