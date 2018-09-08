
namespace Serene.Masters.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("Masters.Manufacturer")]
    [BasedOnRow(typeof(Entities.ManufacturerRow), CheckNames = true)]
    public class ManufacturerColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 ManufacturerId { get; set; }
        [EditLink]
        public String ManufacturerName { get; set; }
        public String ShortName { get; set; }
        public String Description { get; set; }
        public Boolean IsActive { get; set; }
    }
}