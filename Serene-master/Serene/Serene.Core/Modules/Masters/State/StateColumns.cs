
namespace Serene.Masters.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("Masters.State")]
    [BasedOnRow(typeof(Entities.StateRow), CheckNames = true)]
    public class StateColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 StateId { get; set; }
        [EditLink]
        public String StateCode { get; set; }
        public String StateName { get; set; }
        public String CountryCountryCode { get; set; }
        public Boolean IsActive { get; set; }
    }
}