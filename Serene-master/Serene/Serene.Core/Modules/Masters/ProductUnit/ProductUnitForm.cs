
namespace Serene.Masters.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Masters.ProductUnit")]
    [BasedOnRow(typeof(Entities.ProductUnitRow), CheckNames = true)]
    public class ProductUnitForm
    {
        public String ProductUnit { get; set; }
        public Boolean IsActive { get; set; }
    }
}