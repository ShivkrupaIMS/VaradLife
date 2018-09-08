
namespace Serene.Masters.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("Masters.CompanyLicenseDetails")]
    [BasedOnRow(typeof(Entities.CompanyLicenseDetailsRow), CheckNames = true)]
    public class CompanyLicenseDetailsColumns
    {
        public String LicenseType { get; set; }
         [EditLink]
        public String LicenseNo { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime ValidTo { get; set; }
        public Boolean IsActive { get; set; }
    }
}