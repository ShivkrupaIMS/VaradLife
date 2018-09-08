
namespace Serene.Masters.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Masters.State")]
    [BasedOnRow(typeof(Entities.StateRow), CheckNames = true)]
    public class StateForm
    {
        public String StateCode { get; set; }
        public String StateName { get; set; }
        public Int32 CountryId { get; set; }
        public Boolean IsActive { get; set; }
    }
}