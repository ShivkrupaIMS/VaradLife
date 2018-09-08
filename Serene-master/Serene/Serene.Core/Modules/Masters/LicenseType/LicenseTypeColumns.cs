
namespace Serene.Masters.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("Masters.LicenseType")]
    [BasedOnRow(typeof(Entities.LicenseTypeRow), CheckNames = true)]
    public class LicenseTypeColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 LicenseTypeId { get; set; }
        [EditLink]
        public String LicenseType { get; set; }
        public String ShortName { get; set; }
        public String Description { get; set; }
        public Boolean IsActive { get; set; }
    }
}