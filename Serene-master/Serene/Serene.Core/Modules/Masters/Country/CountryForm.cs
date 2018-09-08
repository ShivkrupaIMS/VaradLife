
namespace Serene.Masters.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Masters.Country")]
    [BasedOnRow(typeof(Entities.CountryRow), CheckNames = true)]
    public class CountryForm
    {
        public String CountryCode { get; set; }
        public String CountryName { get; set; }
        public Boolean IsActive { get; set; }
    }
}