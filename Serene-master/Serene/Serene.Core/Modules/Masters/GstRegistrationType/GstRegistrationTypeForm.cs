
namespace Serene.Masters.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Masters.GstRegistrationType")]
    [BasedOnRow(typeof(Entities.GstRegistrationTypeRow), CheckNames = true)]
    public class GstRegistrationTypeForm
    {
        public String GstRegistrationType { get; set; }
        public Boolean IsActive { get; set; }
    }
}