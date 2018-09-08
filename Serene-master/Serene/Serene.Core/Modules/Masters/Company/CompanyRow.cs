
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

    [ConnectionKey("Masters"), Module("Masters"), TableName("[dbo].[Company]")]
    [DisplayName("Company"), InstanceName("Company")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class CompanyRow : Row, IIdRow, INameRow
    {

        [DisplayName("Company Id"), Identity]
        public Int32? CompanyId
        {
            get { return Fields.CompanyId[this]; }
            set { Fields.CompanyId[this] = value; }
        }

        [DisplayName("Company Name"), Size(255), NotNull, QuickSearch]
        public String CompanyName
        {
            get { return Fields.CompanyName[this]; }
            set { Fields.CompanyName[this] = value; }
        }

        [DisplayName("Company Type"), NotNull, ForeignKey("[dbo].[CompanyType]", "CompanyTypeId"), LeftJoin("jCompanyType"), TextualField("CompanyType")]
        [LookupEditor(typeof(CompanyTypeRow), InplaceAdd = true)]
        public Int32? CompanyTypeId
        {
            get { return Fields.CompanyTypeId[this]; }
            set { Fields.CompanyTypeId[this] = value; }
        }

        [DisplayName("Gst No"), Column("GSTNo"), Size(50)]
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

        [DisplayName("Country"), ForeignKey("[dbo].[Country]", "CountryId"), LeftJoin("jCountry"), TextualField("CountryCountryName")]
        [LookupEditor(typeof(CountryRow), InplaceAdd = true)]
        public Int32? CountryId
        {
            get { return Fields.CountryId[this]; }
            set { Fields.CountryId[this] = value; }
        }

        [DisplayName("State"), ForeignKey("[dbo].[State]", "StateId"), LeftJoin("jState"), TextualField("StateStateName")]
        [LookupEditor(typeof(StateRow), InplaceAdd = true, CascadeFrom = "CountryId", CascadeField = "CountryId")]
        public Int32? StateId
        {
            get { return Fields.StateId[this]; }
            set { Fields.StateId[this] = value; }
        }

        [DisplayName("City"), NotNull, ForeignKey("[dbo].[City]", "CityId"), LeftJoin("jCity"), TextualField("CityCityName")]
        [LookupEditor(typeof(CityRow), InplaceAdd = true, CascadeFrom = "StateId", CascadeField = "StateId")]
        public Int32? CityId
        {
            get { return Fields.CityId[this]; }
            set { Fields.CityId[this] = value; }
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

        [DisplayName("Fy Start Date"), Column("FYStartDate")]
        public DateTime? FyStartDate
        {
            get { return Fields.FyStartDate[this]; }
            set { Fields.FyStartDate[this] = value; }
        }

        [DisplayName("Book Start Date")]
        public DateTime? BookStartDate
        {
            get { return Fields.BookStartDate[this]; }
            set { Fields.BookStartDate[this] = value; }
        }

        [DisplayName("Branch"), Size(50)]
        public String Branch
        {
            get { return Fields.Branch[this]; }
            set { Fields.Branch[this] = value; }
        }

        [DisplayName("Is Active"), NotNull,DefaultValue(true)]
        public Boolean? IsActive
        {
            get { return Fields.IsActive[this]; }
            set { Fields.IsActive[this] = value; }
        }

        [MasterDetailRelation(foreignKey: "CompanyId", IncludeColumns = "LicenseType")]
        [DisplayName("License List"), NotMapped]
        [CompanyLicenseDetailsEditor]
        public List<Entities.CompanyLicenseDetailsRow> LicenseList
        {
            get { return Fields.LicenseList[this]; }
            set { Fields.LicenseList[this] = value; }
        }

        [DisplayName("Company Type"), Expression("jCompanyType.[CompanyType]")]
        public String CompanyType
        {
            get { return Fields.CompanyType[this]; }
            set { Fields.CompanyType[this] = value; }
        }

        [DisplayName("Company Type Is Active"), Expression("jCompanyType.[IsActive]")]
        public Boolean? CompanyTypeIsActive
        {
            get { return Fields.CompanyTypeIsActive[this]; }
            set { Fields.CompanyTypeIsActive[this] = value; }
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



        [DisplayName("City City Code"), Expression("jCity.[CityCode]")]
        public String CityCityCode
        {
            get { return Fields.CityCityCode[this]; }
            set { Fields.CityCityCode[this] = value; }
        }

        [DisplayName("City City Name"), Expression("jCity.[CityName]")]
        public String CityCityName
        {
            get { return Fields.CityCityName[this]; }
            set { Fields.CityCityName[this] = value; }
        }

        [DisplayName("City Is Active"), Expression("jCity.[IsActive]")]
        public Boolean? CityIsActive
        {
            get { return Fields.CityIsActive[this]; }
            set { Fields.CityIsActive[this] = value; }
        }

        [DisplayName("City State Id"), Expression("jCity.[StateId]")]
        public Int32? CityStateId
        {
            get { return Fields.CityStateId[this]; }
            set { Fields.CityStateId[this] = value; }
        }



        IIdField IIdRow.IdField
        {
            get { return Fields.CompanyId; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.CompanyName; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public CompanyRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {

            public Int32Field CompanyId;

            public StringField CompanyName;

            public Int32Field CompanyTypeId;

            public StringField GstNo;

            public Int32Field GstRegistrationTypeId;

            public StringField Phone;

            public StringField Fax;

            public StringField Email;

            public StringField Address;

            public Int32Field CountryId;

            public Int32Field StateId;

            public Int32Field CityId;

            public StringField PinCode;

            public StringField PanNo;

            public StringField Website;

            public StringField ContactPerson;

            public StringField MobileNo;

            public StringField CinNo;

            public DateTimeField FyStartDate;

            public DateTimeField BookStartDate;

            public StringField Branch;

            public BooleanField IsActive;



            public StringField CompanyType;

            public BooleanField CompanyTypeIsActive;



            public StringField GstRegistrationType;

            public BooleanField GstRegistrationTypeIsActive;



            public StringField CountryCountryCode;

            public StringField CountryCountryName;

            public BooleanField CountryIsActive;



            public StringField StateStateCode;

            public StringField StateStateName;

            public Int32Field StateCountryId;

            public BooleanField StateIsActive;



            public StringField CityCityCode;

            public StringField CityCityName;

            public BooleanField CityIsActive;

            public Int32Field CityStateId;

            public RowListField<Entities.CompanyLicenseDetailsRow> LicenseList;
        }
    }
}
