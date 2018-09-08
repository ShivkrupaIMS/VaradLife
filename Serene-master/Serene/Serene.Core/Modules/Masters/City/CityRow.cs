
namespace Serene.Masters.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Masters"), Module("Masters"), TableName("[dbo].[City]")]
    [DisplayName("City"), InstanceName("City")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    [LookupScript]
    public sealed class CityRow : Row, IIdRow, INameRow
    {

        [DisplayName("City Id"), Identity]
        public Int32? CityId
        {
            get { return Fields.CityId[this]; }
            set { Fields.CityId[this] = value; }
        }

        [DisplayName("City Code"), Size(5), NotNull, QuickSearch]
        public String CityCode
        {
            get { return Fields.CityCode[this]; }
            set { Fields.CityCode[this] = value; }
        }

        [DisplayName("City Name"), Size(255), NotNull]
        public String CityName
        {
            get { return Fields.CityName[this]; }
            set { Fields.CityName[this] = value; }
        }

        [DisplayName("Is Active"), NotNull]
        public Boolean? IsActive
        {
            get { return Fields.IsActive[this]; }
            set { Fields.IsActive[this] = value; }
        }

        [DisplayName("State"), ForeignKey("[dbo].[State]", "StateId"), LeftJoin("jState"), TextualField("StateStateName"), LookupInclude]
        [LookupEditor(typeof(StateRow), InplaceAdd = true)]
        public Int32? StateId
        {
            get { return Fields.StateId[this]; }
            set { Fields.StateId[this] = value; }
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
            get { return Fields.CityId; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.CityName; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public CityRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {

            public Int32Field CityId;

            public StringField CityCode;

            public StringField CityName;

            public BooleanField IsActive;

            public Int32Field StateId;



            public StringField StateStateCode;

            public StringField StateStateName;

            public Int32Field StateCountryId;

            public BooleanField StateIsActive;


		}
    }
}
