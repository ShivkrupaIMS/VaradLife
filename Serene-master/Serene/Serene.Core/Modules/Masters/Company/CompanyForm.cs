
namespace Serene.Masters.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Masters.Company")]
    [BasedOnRow(typeof(Entities.CompanyRow), CheckNames = true)]
    public class CompanyForm
    {
        public String CompanyName { get; set; }
        public Int32 CompanyTypeId { get; set; }
        public String GstNo { get; set; }
        public Int32 GstRegistrationTypeId { get; set; }
        public String Phone { get; set; }
        public String Fax { get; set; }
        public String Email { get; set; }
        public String Address { get; set; }
        public Int32 CountryId { get; set; }
        public Int32 StateId { get; set; }
        public Int32 CityId { get; set; }
        public String PinCode { get; set; }
        public String PanNo { get; set; }
        public String Website { get; set; }
        public String ContactPerson { get; set; }
        public String MobileNo { get; set; }
        public String CinNo { get; set; }
        public DateTime FyStartDate { get; set; }
        public DateTime BookStartDate { get; set; }
        public String Branch { get; set; }
        public Boolean IsActive { get; set; }

        [CompanyLicenseDetailsEditor]
        public List<Entities.CompanyLicenseDetailsRow> LicenseList { get; set; }
    }
}