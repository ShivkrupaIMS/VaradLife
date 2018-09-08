
namespace Serene.Masters.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Masters"), Module("Masters"), TableName("[dbo].[Customers]")]
    [DisplayName("Customers"), InstanceName("Customer")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class CustomersRow : Row, IIdRow, INameRow
    {

        [DisplayName("Customers Id"), Identity]
        public Int32? CustomersId
        {
            get { return Fields.CustomersId[this]; }
            set { Fields.CustomersId[this] = value; }
        }

        [DisplayName("Customers Name"), Size(255), NotNull, QuickSearch]
        public String CustomersName
        {
            get { return Fields.CustomersName[this]; }
            set { Fields.CustomersName[this] = value; }
        }

        [DisplayName("Customer Type"), NotNull, ForeignKey("[dbo].[CustomerType]", "CustomerTypeId"), LeftJoin("jCustomerType"), TextualField("CustomerType")]
        [LookupEditor(typeof(CustomerTypeRow), InplaceAdd = true)]
        public Int32? CustomerTypeId
        {
            get { return Fields.CustomerTypeId[this]; }
            set { Fields.CustomerTypeId[this] = value; }
        }

        [DisplayName("Gst No"), Column("GSTNo"), Size(50), NotNull]
        public String GstNo
        {
            get { return Fields.GstNo[this]; }
            set { Fields.GstNo[this] = value; }
        }

        [DisplayName("Gst Registration Type"), Column("GSTRegistrationTypeId"), NotNull, ForeignKey("[dbo].[GSTRegistrationType]", "GSTRegistrationTypeId"), LeftJoin("jGstRegistrationType"), TextualField("GstRegistrationType")]
        [LookupEditor(typeof(GstRegistrationTypeRow), InplaceAdd = true)]
        public Int32? GstRegistrationTypeId
        {
            get { return Fields.GstRegistrationTypeId[this]; }
            set { Fields.GstRegistrationTypeId[this] = value; }
        }

        [DisplayName("Phone"), Size(50)]
        public String Phone
        {
            get { return Fields.Phone[this]; }
            set { Fields.Phone[this] = value; }
        }

        [DisplayName("Fax"), Size(50)]
        public String Fax
        {
            get { return Fields.Fax[this]; }
            set { Fields.Fax[this] = value; }
        }

        [DisplayName("Email"), Size(50)]
        public String Email
        {
            get { return Fields.Email[this]; }
            set { Fields.Email[this] = value; }
        }

        [DisplayName("Address"), Size(255), NotNull]
        public String Address
        {
            get { return Fields.Address[this]; }
            set { Fields.Address[this] = value; }
        }

        [DisplayName("Country"), ForeignKey("[dbo].[Country]", "CountryId"), LeftJoin("jCountry"), TextualField("CountryCountryCode")]
        [LookupEditor(typeof(CountryRow), InplaceAdd = true)]
        public Int32? CountryId
        {
            get { return Fields.CountryId[this]; }
            set { Fields.CountryId[this] = value; }
        }

        [DisplayName("State"), ForeignKey("[dbo].[State]", "StateId"), LeftJoin("jState"), TextualField("StateStateCode")]
        [LookupEditor(typeof(StateRow), InplaceAdd = true, CascadeFrom = "CountryId", CascadeField = "CountryId")]
        public Int32? StateId
        {
            get { return Fields.StateId[this]; }
            set { Fields.StateId[this] = value; }
        }

        [DisplayName("Pin Code"), Size(50)]
        public String PinCode
        {
            get { return Fields.PinCode[this]; }
            set { Fields.PinCode[this] = value; }
        }

        [DisplayName("Pan No"), Column("PANNo"), Size(50)]
        public String PanNo
        {
            get { return Fields.PanNo[this]; }
            set { Fields.PanNo[this] = value; }
        }

        [DisplayName("Website"), Size(50)]
        public String Website
        {
            get { return Fields.Website[this]; }
            set { Fields.Website[this] = value; }
        }

        [DisplayName("Contact Person"), Size(255)]
        public String ContactPerson
        {
            get { return Fields.ContactPerson[this]; }
            set { Fields.ContactPerson[this] = value; }
        }

        [DisplayName("Mobile No"), Size(50)]
        public String MobileNo
        {
            get { return Fields.MobileNo[this]; }
            set { Fields.MobileNo[this] = value; }
        }

        [DisplayName("Cin No"), Column("CINNo"), Size(50)]
        public String CinNo
        {
            get { return Fields.CinNo[this]; }
            set { Fields.CinNo[this] = value; }
        }

        [DisplayName("Branch"), Size(50)]
        public String Branch
        {
            get { return Fields.Branch[this]; }
            set { Fields.Branch[this] = value; }
        }

        [DisplayName("Is Active"), NotNull]
        public Boolean? IsActive
        {
            get { return Fields.IsActive[this]; }
            set { Fields.IsActive[this] = value; }
        }

        [DisplayName("Opening Balance")]
        public Double? OpeningBalance
        {
            get { return Fields.OpeningBalance[this]; }
            set { Fields.OpeningBalance[this] = value; }
        }

        [MasterDetailRelation(foreignKey: "CustomersId", IncludeColumns = "LicenseType")]
        [DisplayName("License List"), NotMapped]
        [CustomersLicenseDetailsEditor]
        public List<Entities.CustomersLicenseDetailsRow> LicenseList
        {
            get { return Fields.LicenseList[this]; }
            set { Fields.LicenseList[this] = value; }
        }


        [DisplayName("Customer Type"), Expression("jCustomerType.[CustomerType]")]
        public String CustomerType
        {
            get { return Fields.CustomerType[this]; }
            set { Fields.CustomerType[this] = value; }
        }

        [DisplayName("Customer Type Is Active"), Expression("jCustomerType.[IsActive]")]
        public Boolean? CustomerTypeIsActive
        {
            get { return Fields.CustomerTypeIsActive[this]; }
            set { Fields.CustomerTypeIsActive[this] = value; }
        }



        [DisplayName("Gst Registration Type"), Expression("jGstRegistrationType.[GSTRegistrationType]")]
        public String GstRegistrationType
        {
            get { return Fields.GstRegistrationType[this]; }
            set { Fields.GstRegistrationType[this] = value; }
        }

        [DisplayName("Gst Registration Type Is Active"), Expression("jGstRegistrationType.[IsActive]")]
        public Boolean? GstRegistrationTypeIsActive
        {
            get { return Fields.GstRegistrationTypeIsActive[this]; }
            set { Fields.GstRegistrationTypeIsActive[this] = value; }
        }



        [DisplayName("Country Country Code"), Expression("jCountry.[CountryCode]")]
        public String CountryCountryCode
        {
            get { return Fields.CountryCountryCode[this]; }
            set { Fields.CountryCountryCode[this] = value; }
        }

        [DisplayName("Country Country Name"), Expression("jCountry.[CountryName]")]
        public String CountryCountryName
        {
            get { return Fields.CountryCountryName[this]; }
            set { Fields.CountryCountryName[this] = value; }
        }

        [DisplayName("Country Is Active"), Expression("jCountry.[IsActive]")]
        public Boolean? CountryIsActive
        {
            get { return Fields.CountryIsActive[this]; }
            set { Fields.CountryIsActive[this] = value; }
        }



        [DisplayName("State State Code"), Expression("jState.[StateCode]")]
        public String StateStateCode
        {
            get { return Fields.StateStateCode[this]; }
            set { Fields.StateStateCode[this] = value; }
        }

        [DisplayName("State State Name"), Expression("jState.[StateName]")]
        public String StateStateName
        {
            get { return Fields.StateStateName[this]; }
            set { Fields.StateStateName[this] = value; }
        }

        [DisplayName("State Country Id"), Expression("jState.[CountryId]")]
        public Int32? StateCountryId
        {
            get { return Fields.StateCountryId[this]; }
            set { Fields.StateCountryId[this] = value; }
        }

        [DisplayName("State Is Active"), Expression("jState.[IsActive]")]
        public Boolean? StateIsActive
        {
            get { return Fields.StateIsActive[this]; }
            set { Fields.StateIsActive[this] = value; }
        }



        IIdField IIdRow.IdField
        {
            get { return Fields.CustomersId; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.CustomersName; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public CustomersRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {

            public Int32Field CustomersId;

            public StringField CustomersName;

            public Int32Field CustomerTypeId;

            public StringField GstNo;

            public Int32Field GstRegistrationTypeId;

            public StringField Phone;

            public StringField Fax;

            public StringField Email;

            public StringField Address;

            public Int32Field CountryId;

            public Int32Field StateId;

            public StringField PinCode;

            public StringField PanNo;

            public StringField Website;

            public StringField ContactPerson;

            public StringField MobileNo;

            public StringField CinNo;

            public StringField Branch;

            public BooleanField IsActive;

            public DoubleField OpeningBalance;



            public StringField CustomerType;

            public BooleanField CustomerTypeIsActive;



            public StringField GstRegistrationType;

            public BooleanField GstRegistrationTypeIsActive;



            public StringField CountryCountryCode;

            public StringField CountryCountryName;

            public BooleanField CountryIsActive;



            public StringField StateStateCode;

            public StringField StateStateName;

            public Int32Field StateCountryId;

            public BooleanField StateIsActive;

            public RowListField<Entities.CustomersLicenseDetailsRow> LicenseList;
        }
    }
}
