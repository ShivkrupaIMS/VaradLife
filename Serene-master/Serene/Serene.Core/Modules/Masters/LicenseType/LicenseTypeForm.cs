
namespace Serene.Masters.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Masters.LicenseType")]
    [BasedOnRow(typeof(Entities.LicenseTypeRow), CheckNames = true)]
    public class LicenseTypeForm
    {
        public String LicenseType { get; set; }
        public String ShortName { get; set; }
        public String Description { get; set; }
        public Boolean IsActive { get; set; }
    }
}