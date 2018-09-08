
namespace Serene.Masters.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Masters"), Module("Masters"), TableName("[dbo].[SupplierType]")]
    [DisplayName("Supplier Type"), InstanceName("Supplier Type")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    [LookupScript]
    public sealed class SupplierTypeRow : Row, IIdRow, INameRow
    {

        [DisplayName("Supplier Type Id"), Identity]
        public Int32? SupplierTypeId
        {
            get { return Fields.SupplierTypeId[this]; }
            set { Fields.SupplierTypeId[this] = value; }
        }

        [DisplayName("Supplier Type"), Size(255), NotNull, QuickSearch]
        public String SupplierType
        {
            get { return Fields.SupplierType[this]; }
            set { Fields.SupplierType[this] = value; }
        }

        [DisplayName("Is Active"), NotNull]
        public Boolean? IsActive
        {
            get { return Fields.IsActive[this]; }
            set { Fields.IsActive[this] = value; }
        }



        IIdField IIdRow.IdField
        {
            get { return Fields.SupplierTypeId; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.SupplierType; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public SupplierTypeRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {

            public Int32Field SupplierTypeId;

            public StringField SupplierType;

            public BooleanField IsActive;


		}
    }
}
