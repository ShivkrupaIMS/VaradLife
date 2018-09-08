using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace Serene.Masters
{
    public partial class ProductLicenseDetailsEditorAttribute : CustomEditorAttribute
    {
        public const string Key = "Serene.Masters.ProductLicenseDetailsEditor";

        public ProductLicenseDetailsEditorAttribute()
            : base(Key)
        {
        }
    }
}
