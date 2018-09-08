
namespace Serene.Masters.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Masters"), Module("Masters"), TableName("[dbo].[ProductType]")]
    [DisplayName("Product Type"), InstanceName("Product Type")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    [LookupScript]
    public sealed class ProductTypeRow : Row, IIdRow, INameRow
    {

        [DisplayName("Product Type Id"), Identity]
        public Int32? ProductTypeId
        {
            get { return Fields.ProductTypeId[this]; }
            set { Fields.ProductTypeId[this] = value; }
        }

        [DisplayName("Product Type"), Size(255), NotNull, QuickSearch]
        public String ProductType
        {
            get { return Fields.ProductType[this]; }
            set { Fields.ProductType[this] = value; }
        }

        [DisplayName("Is Active"), NotNull]
        public Boolean? IsActive
        {
            get { return Fields.IsActive[this]; }
            set { Fields.IsActive[this] = value; }
        }



        IIdField IIdRow.IdField
        {
            get { return Fields.ProductTypeId; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.ProductType; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public ProductTypeRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {

            public Int32Field ProductTypeId;

            public StringField ProductType;

            public BooleanField IsActive;


		}
    }
}
