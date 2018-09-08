
namespace Serene.Masters.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("Masters.GstRegistrationType")]
    [BasedOnRow(typeof(Entities.GstRegistrationTypeRow), CheckNames = true)]
    public class GstRegistrationTypeColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 GstRegistrationTypeId { get; set; }
        [EditLink]
        public String GstRegistrationType { get; set; }
        public Boolean IsActive { get; set; }
    }
}