
namespace Serene.Masters.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Masters.CustomerType")]
    [BasedOnRow(typeof(Entities.CustomerTypeRow), CheckNames = true)]
    public class CustomerTypeForm
    {
        public String CustomerType { get; set; }
        public Boolean IsActive { get; set; }
    }
}