
namespace Serene.Masters.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("Masters.Customers")]
    [BasedOnRow(typeof(Entities.CustomersRow), CheckNames = true)]
    public class CustomersColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 CustomersId { get; set; }
        [EditLink]
        public String CustomersName { get; set; }
        public String CustomerType { get; set; }
        public String GstNo { get; set; }
        public String GstRegistrationType { get; set; }
        public String Phone { get; set; }
        public String Fax { get; set; }
        public String Email { get; set; }
        public String Address { get; set; }
        public String CountryCountryCode { get; set; }
        public String StateStateCode { get; set; }
        public String PinCode { get; set; }
        public String PanNo { get; set; }
        public String Website { get; set; }
        public String ContactPerson { get; set; }
        public String MobileNo { get; set; }
        public String CinNo { get; set; }
        public String Branch { get; set; }
        public Boolean IsActive { get; set; }
        public Double OpeningBalance { get; set; }
    }
}