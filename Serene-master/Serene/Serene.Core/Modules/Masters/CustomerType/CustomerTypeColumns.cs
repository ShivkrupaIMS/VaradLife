
namespace Serene.Masters.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("Masters.CustomerType")]
    [BasedOnRow(typeof(Entities.CustomerTypeRow), CheckNames = true)]
    public class CustomerTypeColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 CustomerTypeId { get; set; }
        [EditLink]
        public String CustomerType { get; set; }
        public Boolean IsActive { get; set; }
    }
}