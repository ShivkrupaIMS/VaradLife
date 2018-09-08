
namespace Serene.Masters.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Masters.CompanyType")]
    [BasedOnRow(typeof(Entities.CompanyTypeRow), CheckNames = true)]
    public class CompanyTypeForm
    {
        public String CompanyType { get; set; }
        public Boolean IsActive { get; set; }
    }
}