
namespace Serene.Masters.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("Masters.CompanyType")]
    [BasedOnRow(typeof(Entities.CompanyTypeRow), CheckNames = true)]
    public class CompanyTypeColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 CompanyTypeId { get; set; }
        [EditLink]
        public String CompanyType { get; set; }
        public Boolean IsActive { get; set; }
    }
}