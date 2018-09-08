
namespace Serene.Masters.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Masters"), Module("Masters"), TableName("[dbo].[State]")]
    [DisplayName("State"), InstanceName("State")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    [LookupScript]
    public sealed class StateRow : Row, IIdRow, INameRow
    {

        [DisplayName("State Id"), Identity]
        public Int32? StateId
        {
            get { return Fields.StateId[this]; }
            set { Fields.StateId[this] = value; }
        }

        [DisplayName("State Code"), Size(5), NotNull, QuickSearch]
        public String StateCode
        {
            get { return Fields.StateCode[this]; }
            set { Fields.StateCode[this] = value; }
        }

        [DisplayName("State Name"), Size(255), NotNull]
        public String StateName
        {
            get { return Fields.StateName[this]; }
            set { Fields.StateName[this] = value; }
        }

        [DisplayName("Country"), ForeignKey("[dbo].[Country]", "CountryId"), LeftJoin("jCountry"), TextualField("CountryCountryName"), LookupInclude]
        [LookupEditor(typeof(CountryRow), InplaceAdd = true)]
        public Int32? CountryId
        {
            get { return Fields.CountryId[this]; }
            set { Fields.CountryId[this] = value; }
        }

        [DisplayName("Is Active"), NotNull]
        public Boolean? IsActive
        {
            get { return Fields.IsActive[this]; }
            set { Fields.IsActive[this] = value; }
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



        IIdField IIdRow.IdField
        {
            get { return Fields.StateId; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.StateName; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public StateRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {

            public Int32Field StateId;

            public StringField StateCode;

            public StringField StateName;

            public Int32Field CountryId;

            public BooleanField IsActive;



            public StringField CountryCountryCode;

            public StringField CountryCountryName;

            public BooleanField CountryIsActive;


		}
    }
}
