
namespace Serene.Masters.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Masters.Customers")]
    [BasedOnRow(typeof(Entities.CustomersRow), CheckNames = true)]
    public class CustomersForm
    {
        public String CustomersName { get; set; }
        public Int32 CustomerTypeId { get; set; }
        public String GstNo { get; set; }
        public Int32 GstRegistrationTypeId { get; set; }
        public String Phone { get; set; }
        public String Fax { get; set; }
        public String Email { get; set; }
        public String Address { get; set; }
        public Int32 CountryId { get; set; }
        public Int32 StateId { get; set; }
        public String PinCode { get; set; }
        public String PanNo { get; set; }
        public String Website { get; set; }
        public String ContactPerson { get; set; }
        public String MobileNo { get; set; }
        public String CinNo { get; set; }
        public String Branch { get; set; }
        public Boolean IsActive { get; set; }
        public Double OpeningBalance { get; set; }

        [CustomersLicenseDetailsEditor]
        public List<Entities.CustomersLicenseDetailsRow> LicenseList { get; set; }
    }
}