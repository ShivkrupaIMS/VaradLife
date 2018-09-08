
namespace Serene.Masters.Forms
{
    using Serenity.ComponentModel;
    using System;

    [FormScript("Masters.CompanyLicenseDetails")]
    [BasedOnRow(typeof(Entities.CompanyLicenseDetailsRow), CheckNames = true)]
    public class CompanyLicenseDetailsForm
    {
        public Int32 LicenseTypeId { get; set; }
        public String LicenseNo { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime ValidTo { get; set; }
        public Boolean IsActive { get; set; }
    }
}