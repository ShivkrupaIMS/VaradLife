
namespace Serene.Masters.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Masters.SuppliersLicenseDetails")]
    [BasedOnRow(typeof(Entities.SuppliersLicenseDetailsRow), CheckNames = true)]
    public class SuppliersLicenseDetailsForm
    {
        public Int32 LicenseTypeId { get; set; }
        public String LicenseNo { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime ValidTo { get; set; }
        public Boolean IsActive { get; set; }
    }
}