
namespace Serene.Masters.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("Masters.Company")]
    [BasedOnRow(typeof(Entities.CompanyRow), CheckNames = true)]
    public class CompanyColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 CompanyId { get; set; }
        [EditLink]
        public String CompanyName { get; set; }
        public String CompanyType { get; set; }
        public String GstNo { get; set; }
        public String GstRegistrationType { get; set; }
        public String Phone { get; set; }
        public String Fax { get; set; }
        public String Email { get; set; }
        public String Address { get; set; }
        public String CountryCountryCode { get; set; }
        public String StateStateCode { get; set; }
        public String CityCityCode { get; set; }
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
    }
}