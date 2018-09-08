
namespace Serene.Masters.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Masters"), Module("Masters"), TableName("[dbo].[CustomerType]")]
    [DisplayName("Customer Type"), InstanceName("Customer Type")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    [LookupScript]
    public sealed class CustomerTypeRow : Row, IIdRow, INameRow
    {

        [DisplayName("Customer Type Id"), Identity]
        public Int32? CustomerTypeId
        {
            get { return Fields.CustomerTypeId[this]; }
            set { Fields.CustomerTypeId[this] = value; }
        }

        [DisplayName("Customer Type"), Size(255), NotNull, QuickSearch]
        public String CustomerType
        {
            get { return Fields.CustomerType[this]; }
            set { Fields.CustomerType[this] = value; }
        }

        [DisplayName("Is Active"), NotNull]
        public Boolean? IsActive
        {
            get { return Fields.IsActive[this]; }
            set { Fields.IsActive[this] = value; }
        }



        IIdField IIdRow.IdField
        {
            get { return Fields.CustomerTypeId; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.CustomerType; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public CustomerTypeRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {

            public Int32Field CustomerTypeId;

            public StringField CustomerType;

            public BooleanField IsActive;


		}
    }
}
