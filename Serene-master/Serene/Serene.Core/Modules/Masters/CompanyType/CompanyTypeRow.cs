
namespace Serene.Masters.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Masters"), Module("Masters"), TableName("[dbo].[CompanyType]")]
    [DisplayName("Company Type"), InstanceName("Company Type")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    [LookupScript]
    public sealed class CompanyTypeRow : Row, IIdRow, INameRow
    {

        [DisplayName("Company Type Id"), Identity]
        public Int32? CompanyTypeId
        {
            get { return Fields.CompanyTypeId[this]; }
            set { Fields.CompanyTypeId[this] = value; }
        }

        [DisplayName("Company Type"), Size(255), NotNull, QuickSearch]
        public String CompanyType
        {
            get { return Fields.CompanyType[this]; }
            set { Fields.CompanyType[this] = value; }
        }

        [DisplayName("Is Active"), NotNull]
        public Boolean? IsActive
        {
            get { return Fields.IsActive[this]; }
            set { Fields.IsActive[this] = value; }
        }



        IIdField IIdRow.IdField
        {
            get { return Fields.CompanyTypeId; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.CompanyType; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public CompanyTypeRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {

            public Int32Field CompanyTypeId;

            public StringField CompanyType;

            public BooleanField IsActive;


		}
    }
}
