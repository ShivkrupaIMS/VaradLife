
namespace Serene.Masters.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Masters.ProductType")]
    [BasedOnRow(typeof(Entities.ProductTypeRow), CheckNames = true)]
    public class ProductTypeForm
    {
        public String ProductType { get; set; }
        public Boolean IsActive { get; set; }
    }
}