
namespace Serene.Masters.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("Masters.ProductLicenseDetails")]
    [BasedOnRow(typeof(Entities.ProductLicenseDetailsRow), CheckNames = true)]
    public class ProductLicenseDetailsColumns
    {
        [EditLink]
        public String LicenseType { get; set; }
        public Boolean IsActive { get; set; }
    }
}