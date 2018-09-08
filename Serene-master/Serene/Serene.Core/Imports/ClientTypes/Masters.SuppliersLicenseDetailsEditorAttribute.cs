using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace Serene.Masters
{
    public partial class SuppliersLicenseDetailsEditorAttribute : CustomEditorAttribute
    {
        public const string Key = "Serene.Masters.SuppliersLicenseDetailsEditor";

        public SuppliersLicenseDetailsEditorAttribute()
            : base(Key)
        {
        }
    }
}
