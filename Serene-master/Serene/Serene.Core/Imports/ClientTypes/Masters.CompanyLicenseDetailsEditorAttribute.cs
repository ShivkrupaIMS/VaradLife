using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace Serene.Masters
{
    public partial class CompanyLicenseDetailsEditorAttribute : CustomEditorAttribute
    {
        public const string Key = "Serene.Masters.CompanyLicenseDetailsEditor";

        public CompanyLicenseDetailsEditorAttribute()
            : base(Key)
        {
        }
    }
}
