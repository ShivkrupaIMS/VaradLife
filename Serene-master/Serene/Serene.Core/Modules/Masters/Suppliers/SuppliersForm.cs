
namespace Serene.Masters.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Masters.Suppliers")]
    [BasedOnRow(typeof(Entities.SuppliersRow), CheckNames = true)]
    public class SuppliersForm
    {
        public String SuppliersName { get; set; }
        public Int32 SupplierTypeId { get; set; }
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
        public Boolean IsActive { get; set; }
        public Double OpeningBalance { get; set; }

        [SuppliersLicenseDetailsEditor]
        public List<Entities.SuppliersLicenseDetailsRow> LicenseList { get; set; }
    }
}