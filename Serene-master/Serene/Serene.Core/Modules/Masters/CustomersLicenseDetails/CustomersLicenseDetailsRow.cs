
namespace Serene.Masters.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Masters"), Module("Masters"), TableName("[dbo].[CustomersLicenseDetails]")]
    [DisplayName("Customers License Details"), InstanceName("Customers License Details")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class CustomersLicenseDetailsRow : Row, IIdRow, INameRow
    {

        [DisplayName("Customers License Details Id"), Identity]
        public Int32? CustomersLicenseDetailsId
        {
            get { return Fields.CustomersLicenseDetailsId[this]; }
            set { Fields.CustomersLicenseDetailsId[this] = value; }
        }

        [DisplayName("License Type"), NotNull, ForeignKey("[dbo].[LicenseType]", "LicenseTypeId"), LeftJoin("jLicenseType"), TextualField("LicenseType")]
        [LookupEditor(typeof(LicenseTypeRow), InplaceAdd = true)]
        public Int32? LicenseTypeId
        {
            get { return Fields.LicenseTypeId[this]; }
            set { Fields.LicenseTypeId[this] = value; }
        }

        [DisplayName("Customers"), NotNull, ForeignKey("[dbo].[Customers]", "CustomersId"), LeftJoin("jCustomers"), TextualField("CustomersCustomersName")]
        public Int32? CustomersId
        {
            get { return Fields.CustomersId[this]; }
            set { Fields.CustomersId[this] = value; }
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



        [DisplayName("Customers Customers Name"), Expression("jCustomers.[CustomersName]")]
        public String CustomersCustomersName
        {
            get { return Fields.CustomersCustomersName[this]; }
            set { Fields.CustomersCustomersName[this] = value; }
        }

        [DisplayName("Customers Customer Type Id"), Expression("jCustomers.[CustomerTypeId]")]
        public Int32? CustomersCustomerTypeId
        {
            get { return Fields.CustomersCustomerTypeId[this]; }
            set { Fields.CustomersCustomerTypeId[this] = value; }
        }

        [DisplayName("Customers Gst No"), Expression("jCustomers.[GSTNo]")]
        public String CustomersGstNo
        {
            get { return Fields.CustomersGstNo[this]; }
            set { Fields.CustomersGstNo[this] = value; }
        }

        [DisplayName("Customers Gst Registration Type Id"), Expression("jCustomers.[GSTRegistrationTypeId]")]
        public Int32? CustomersGstRegistrationTypeId
        {
            get { return Fields.CustomersGstRegistrationTypeId[this]; }
            set { Fields.CustomersGstRegistrationTypeId[this] = value; }
        }

        [DisplayName("Customers Phone"), Expression("jCustomers.[Phone]")]
        public String CustomersPhone
        {
            get { return Fields.CustomersPhone[this]; }
            set { Fields.CustomersPhone[this] = value; }
        }

        [DisplayName("Customers Fax"), Expression("jCustomers.[Fax]")]
        public String CustomersFax
        {
            get { return Fields.CustomersFax[this]; }
            set { Fields.CustomersFax[this] = value; }
        }

        [DisplayName("Customers Email"), Expression("jCustomers.[Email]")]
        public String CustomersEmail
        {
            get { return Fields.CustomersEmail[this]; }
            set { Fields.CustomersEmail[this] = value; }
        }

        [DisplayName("Customers Address"), Expression("jCustomers.[Address]")]
        public String CustomersAddress
        {
            get { return Fields.CustomersAddress[this]; }
            set { Fields.CustomersAddress[this] = value; }
        }

        [DisplayName("Customers Country Id"), Expression("jCustomers.[CountryId]")]
        public Int32? CustomersCountryId
        {
            get { return Fields.CustomersCountryId[this]; }
            set { Fields.CustomersCountryId[this] = value; }
        }

        [DisplayName("Customers State Id"), Expression("jCustomers.[StateId]")]
        public Int32? CustomersStateId
        {
            get { return Fields.CustomersStateId[this]; }
            set { Fields.CustomersStateId[this] = value; }
        }

        [DisplayName("Customers Pin Code"), Expression("jCustomers.[PinCode]")]
        public String CustomersPinCode
        {
            get { return Fields.CustomersPinCode[this]; }
            set { Fields.CustomersPinCode[this] = value; }
        }

        [DisplayName("Customers Pan No"), Expression("jCustomers.[PANNo]")]
        public String CustomersPanNo
        {
            get { return Fields.CustomersPanNo[this]; }
            set { Fields.CustomersPanNo[this] = value; }
        }

        [DisplayName("Customers Website"), Expression("jCustomers.[Website]")]
        public String CustomersWebsite
        {
            get { return Fields.CustomersWebsite[this]; }
            set { Fields.CustomersWebsite[this] = value; }
        }

        [DisplayName("Customers Contact Person"), Expression("jCustomers.[ContactPerson]")]
        public String CustomersContactPerson
        {
            get { return Fields.CustomersContactPerson[this]; }
            set { Fields.CustomersContactPerson[this] = value; }
        }

        [DisplayName("Customers Mobile No"), Expression("jCustomers.[MobileNo]")]
        public String CustomersMobileNo
        {
            get { return Fields.CustomersMobileNo[this]; }
            set { Fields.CustomersMobileNo[this] = value; }
        }

        [DisplayName("Customers Cin No"), Expression("jCustomers.[CINNo]")]
        public String CustomersCinNo
        {
            get { return Fields.CustomersCinNo[this]; }
            set { Fields.CustomersCinNo[this] = value; }
        }

        [DisplayName("Customers Branch"), Expression("jCustomers.[Branch]")]
        public String CustomersBranch
        {
            get { return Fields.CustomersBranch[this]; }
            set { Fields.CustomersBranch[this] = value; }
        }

        [DisplayName("Customers Is Active"), Expression("jCustomers.[IsActive]")]
        public Boolean? CustomersIsActive
        {
            get { return Fields.CustomersIsActive[this]; }
            set { Fields.CustomersIsActive[this] = value; }
        }

        [DisplayName("Customers Opening Balance"), Expression("jCustomers.[OpeningBalance]")]
        public Double? CustomersOpeningBalance
        {
            get { return Fields.CustomersOpeningBalance[this]; }
            set { Fields.CustomersOpeningBalance[this] = value; }
        }



        IIdField IIdRow.IdField
        {
            get { return Fields.CustomersLicenseDetailsId; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.LicenseNo; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public CustomersLicenseDetailsRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {

            public Int32Field CustomersLicenseDetailsId;

            public Int32Field LicenseTypeId;

            public Int32Field CustomersId;

            public StringField LicenseNo;

            public DateTimeField ValidFrom;

            public DateTimeField ValidTo;

            public BooleanField IsActive;



            public StringField LicenseType;

            public StringField LicenseTypeShortName;

            public StringField LicenseTypeDescription;

            public BooleanField LicenseTypeIsActive;



            public StringField CustomersCustomersName;

            public Int32Field CustomersCustomerTypeId;

            public StringField CustomersGstNo;

            public Int32Field CustomersGstRegistrationTypeId;

            public StringField CustomersPhone;

            public StringField CustomersFax;

            public StringField CustomersEmail;

            public StringField CustomersAddress;

            public Int32Field CustomersCountryId;

            public Int32Field CustomersStateId;

            public StringField CustomersPinCode;

            public StringField CustomersPanNo;

            public StringField CustomersWebsite;

            public StringField CustomersContactPerson;

            public StringField CustomersMobileNo;

            public StringField CustomersCinNo;

            public StringField CustomersBranch;

            public BooleanField CustomersIsActive;

            public DoubleField CustomersOpeningBalance;


		}
    }
}
