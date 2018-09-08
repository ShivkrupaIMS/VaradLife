using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace Serene.Core.Modules.Northwind
{
    public partial class MovieCastEditorAttribute : CustomEditorAttribute
    {
        public const string Key = "Serene.Core.Modules.Northwind.MovieCastEditor";

        public MovieCastEditorAttribute()
            : base(Key)
        {
        }
    }
}
