using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace Serene.Masters
{
    public partial class ProductDetailsEditorAttribute : CustomEditorAttribute
    {
        public const string Key = "Serene.Masters.ProductDetailsEditor";

        public ProductDetailsEditorAttribute()
            : base(Key)
        {
        }
    }
}
