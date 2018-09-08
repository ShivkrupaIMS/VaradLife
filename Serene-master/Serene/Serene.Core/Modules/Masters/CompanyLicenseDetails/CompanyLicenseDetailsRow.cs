
namespace Serene.Masters.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Masters"), Module("Masters"), TableName("[dbo].[CompanyLicenseDetails]")]
    [DisplayName("Company License Details"), InstanceName("License Details")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class CompanyLicenseDetailsRow : Row, IIdRow, INameRow
    {

        [DisplayName("Company License Details Id"), Identity]
        public Int32? CompanyLicenseDetailsId
        {
            get { return Fields.CompanyLicenseDetailsId[this]; }
            set { Fields.CompanyLicenseDetailsId[this] = value; }
        }

        [DisplayName("License Type"), NotNull, ForeignKey("[dbo].[LicenseType]", "LicenseTypeId"), LeftJoin("jLicenseType"), TextualField("LicenseType")]
        [LookupEditor(typeof(LicenseTypeRow), InplaceAdd = true)]
        public Int32? LicenseTypeId
        {
            get { return Fields.LicenseTypeId[this]; }
            set { Fields.LicenseTypeId[this] = value; }
        }

        [DisplayName("Company"), NotNull, ForeignKey("[dbo].[Company]", "CompanyId"), LeftJoin("jCompany"), TextualField("CompanyCompanyName")]
        public Int32? CompanyId
        {
            get { return Fields.CompanyId[this]; }
            set { Fields.CompanyId[this] = value; }
        }

        [DisplayName("License No"), Size(50), NotNull, QuickSearch]
        public String LicenseNo
        {
            get { return Fields.LicenseNo[this]; }
            set { Fields.LicenseNo[this] = value; }
        }

        [DisplayName("Valid From")]
        public DateTime? ValidFrom
        {
            get { return Fields.ValidFrom[this]; }
            set { Fields.ValidFrom[this] = value; }
        }

        [DisplayName("Valid To")]
        public DateTime? ValidTo
        {
            get { return Fields.ValidTo[this]; }
            set { Fields.ValidTo[this] = value; }
        }

        [DisplayName("Is Active"), NotNull]
        public Boolean? IsActive
        {
            get { return Fields.IsActive[this]; }
            set { Fields.IsActive[this] = value; }
        }



        [DisplayName("License Type"), Expression("jLicenseType.[LicenseType]")]
        public String LicenseType
        {
            get { return Fields.LicenseType[this]; }
            set { Fields.LicenseType[this] = value; }
        }

        [DisplayName("License Type Short Name"), Expression("jLicenseType.[ShortName]")]
        public String LicenseTypeShortName
        {
            get { return Fields.LicenseTypeShortName[this]; }
            set { Fields.LicenseTypeShortName[this] = value; }
        }

        [DisplayName("License Type Description"), Expression("jLicenseType.[Description]")]
        public String LicenseTypeDescription
        {
            get { return Fields.LicenseTypeDescription[this]; }
            set { Fields.LicenseTypeDescription[this] = value; }
        }

        [DisplayName("License Type Is Active"), Expression("jLicenseType.[IsActive]")]
        public Boolean? LicenseTypeIsActive
        {
            get { return Fields.LicenseTypeIsActive[this]; }
            set { Fields.LicenseTypeIsActive[this] = value; }
        }



        [DisplayName("Company Company Name"), Expression("jCompany.[CompanyName]")]
        public String CompanyCompanyName
        {
            get { return Fields.CompanyCompanyName[this]; }
            set { Fields.CompanyCompanyName[this] = value; }
        }

        [DisplayName("Company Company Type Id"), Expression("jCompany.[CompanyTypeId]")]
        public Int32? CompanyCompanyTypeId
        {
            get { return Fields.CompanyCompanyTypeId[this]; }
            set { Fields.CompanyCompanyTypeId[this] = value; }
        }

        [DisplayName("Company Gst No"), Expression("jCompany.[GSTNo]")]
        public String CompanyGstNo
        {
            get { return Fields.CompanyGstNo[this]; }
            set { Fields.CompanyGstNo[this] = value; }
        }

        [DisplayName("Company Gst Registration Type Id"), Expression("jCompany.[GSTRegistrationTypeId]")]
        public Int32? CompanyGstRegistrationTypeId
        {
            get { return Fields.CompanyGstRegistrationTypeId[this]; }
            set { Fields.CompanyGstRegistrationTypeId[this] = value; }
        }

        [DisplayName("Company Phone"), Expression("jCompany.[Phone]")]
        public String CompanyPhone
        {
            get { return Fields.CompanyPhone[this]; }
            set { Fields.CompanyPhone[this] = value; }
        }

        [DisplayName("Company Fax"), Expression("jCompany.[Fax]")]
        public String CompanyFax
        {
            get { return Fields.CompanyFax[this]; }
            set { Fields.CompanyFax[this] = value; }
        }

        [DisplayName("Company Email"), Expression("jCompany.[Email]")]
        public String CompanyEmail
        {
            get { return Fields.CompanyEmail[this]; }
            set { Fields.CompanyEmail[this] = value; }
        }

        [DisplayName("Company Address"), Expression("jCompany.[Address]")]
        public String CompanyAddress
        {
            get { return Fields.CompanyAddress[this]; }
            set { Fields.CompanyAddress[this] = value; }
        }

        [DisplayName("Company Country Id"), Expression("jCompany.[CountryId]")]
        public Int32? CompanyCountryId
        {
            get { return Fields.CompanyCountryId[this]; }
            set { Fields.CompanyCountryId[this] = value; }
        }

        [DisplayName("Company State Id"), Expression("jCompany.[StateId]")]
        public Int32? CompanyStateId
        {
            get { return Fields.CompanyStateId[this]; }
            set { Fields.CompanyStateId[this] = value; }
        }

        [DisplayName("Company City Id"), Expression("jCompany.[CityId]")]
        public Int32? CompanyCityId
        {
            get { return Fields.CompanyCityId[this]; }
            set { Fields.CompanyCityId[this] = value; }
        }

        [DisplayName("Company Pin Code"), Expression("jCompany.[PinCode]")]
        public String CompanyPinCode
        {
            get { return Fields.CompanyPinCode[this]; }
            set { Fields.CompanyPinCode[this] = value; }
        }

        [DisplayName("Company Pan No"), Expression("jCompany.[PANNo]")]
        public String CompanyPanNo
        {
            get { return Fields.CompanyPanNo[this]; }
            set { Fields.CompanyPanNo[this] = value; }
        }

        [DisplayName("Company Website"), Expression("jCompany.[Website]")]
        public String CompanyWebsite
        {
            get { return Fields.CompanyWebsite[this]; }
            set { Fields.CompanyWebsite[this] = value; }
        }

        [DisplayName("Company Contact Person"), Expression("jCompany.[ContactPerson]")]
        public String CompanyContactPerson
        {
            get { return Fields.CompanyContactPerson[this]; }
            set { Fields.CompanyContactPerson[this] = value; }
        }

        [DisplayName("Company Mobile No"), Expression("jCompany.[MobileNo]")]
        public String CompanyMobileNo
        {
            get { return Fields.CompanyMobileNo[this]; }
            set { Fields.CompanyMobileNo[this] = value; }
        }

        [DisplayName("Company Cin No"), Expression("jCompany.[CINNo]")]
        public String CompanyCinNo
        {
            get { return Fields.CompanyCinNo[this]; }
            set { Fields.CompanyCinNo[this] = value; }
        }

        [DisplayName("Company Fy Start Date"), Expression("jCompany.[FYStartDate]")]
        public DateTime? CompanyFyStartDate
        {
            get { return Fields.CompanyFyStartDate[this]; }
            set { Fields.CompanyFyStartDate[this] = value; }
        }

        [DisplayName("Company Book Start Date"), Expression("jCompany.[BookStartDate]")]
        public DateTime? CompanyBookStartDate
        {
            get { return Fields.CompanyBookStartDate[this]; }
            set { Fields.CompanyBookStartDate[this] = value; }
        }

        [DisplayName("Company Branch"), Expression("jCompany.[Branch]")]
        public String CompanyBranch
        {
            get { return Fields.CompanyBranch[this]; }
            set { Fields.CompanyBranch[this] = value; }
        }

        [DisplayName("Company Is Active"), Expression("jCompany.[IsActive]")]
        public Boolean? CompanyIsActive
        {
            get { return Fields.CompanyIsActive[this]; }
            set { Fields.CompanyIsActive[this] = value; }
        }



        IIdField IIdRow.IdField
        {
            get { return Fields.CompanyLicenseDetailsId; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.LicenseNo; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public CompanyLicenseDetailsRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {

            public Int32Field CompanyLicenseDetailsId;

            public Int32Field LicenseTypeId;

            public Int32Field CompanyId;

            public StringField LicenseNo;

            public DateTimeField ValidFrom;

            public DateTimeField ValidTo;

            public BooleanField IsActive;



            public StringField LicenseType;

            public StringField LicenseTypeShortName;

            public StringField LicenseTypeDescription;

            public BooleanField LicenseTypeIsActive;



            public StringField CompanyCompanyName;

            public Int32Field CompanyCompanyTypeId;

            public StringField CompanyGstNo;

            public Int32Field CompanyGstRegistrationTypeId;

            public StringField CompanyPhone;

            public StringField CompanyFax;

            public StringField CompanyEmail;

            public StringField CompanyAddress;

            public Int32Field CompanyCountryId;

            public Int32Field CompanyStateId;

            public Int32Field CompanyCityId;

            public StringField CompanyPinCode;

            public StringField CompanyPanNo;

            public StringField CompanyWebsite;

            public StringField CompanyContactPerson;

            public StringField CompanyMobileNo;

            public StringField CompanyCinNo;

            public DateTimeField CompanyFyStartDate;

            public DateTimeField CompanyBookStartDate;

            public StringField CompanyBranch;

            public BooleanField CompanyIsActive;


		}
    }
}
