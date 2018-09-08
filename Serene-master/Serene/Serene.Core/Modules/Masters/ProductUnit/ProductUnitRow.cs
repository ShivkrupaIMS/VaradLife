
namespace Serene.Masters.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Masters"), Module("Masters"), TableName("[dbo].[ProductUnit]")]
    [DisplayName("Product Unit"), InstanceName("Product Unit")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    [LookupScript]
    public sealed class ProductUnitRow : Row, IIdRow, INameRow
    {

        [DisplayName("Product Unit Id"), Identity]
        public Int32? ProductUnitId
        {
            get { return Fields.ProductUnitId[this]; }
            set { Fields.ProductUnitId[this] = value; }
        }

        [DisplayName("Product Unit"), Size(255), NotNull, QuickSearch]
        public String ProductUnit
        {
            get { return Fields.ProductUnit[this]; }
            set { Fields.ProductUnit[this] = value; }
        }

        [DisplayName("Is Active"), NotNull]
        public Boolean? IsActive
        {
            get { return Fields.IsActive[this]; }
            set { Fields.IsActive[this] = value; }
        }



        IIdField IIdRow.IdField
        {
            get { return Fields.ProductUnitId; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.ProductUnit; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public ProductUnitRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {

            public Int32Field ProductUnitId;

            public StringField ProductUnit;

            public BooleanField IsActive;


		}
    }
}
