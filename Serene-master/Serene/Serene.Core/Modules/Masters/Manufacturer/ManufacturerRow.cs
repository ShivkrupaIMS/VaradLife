
namespace Serene.Masters.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Masters"), Module("Masters"), TableName("[dbo].[Manufacturer]")]
    [DisplayName("Manufacturer"), InstanceName("Manufacturer")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    [LookupScript]
    public sealed class ManufacturerRow : Row, IIdRow, INameRow
    {

        [DisplayName("Manufacturer Id"), Identity]
        public Int32? ManufacturerId
        {
            get { return Fields.ManufacturerId[this]; }
            set { Fields.ManufacturerId[this] = value; }
        }

        [DisplayName("Manufacturer Name"), Size(255), NotNull, QuickSearch]
        public String ManufacturerName
        {
            get { return Fields.ManufacturerName[this]; }
            set { Fields.ManufacturerName[this] = value; }
        }

        [DisplayName("Short Name"), Size(50)]
        public String ShortName
        {
            get { return Fields.ShortName[this]; }
            set { Fields.ShortName[this] = value; }
        }

        [DisplayName("Description"), Size(255)]
        public String Description
        {
            get { return Fields.Description[this]; }
            set { Fields.Description[this] = value; }
        }

        [DisplayName("Is Active"), NotNull]
        public Boolean? IsActive
        {
            get { return Fields.IsActive[this]; }
            set { Fields.IsActive[this] = value; }
        }



        IIdField IIdRow.IdField
        {
            get { return Fields.ManufacturerId; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.ManufacturerName; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public ManufacturerRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {

            public Int32Field ManufacturerId;

            public StringField ManufacturerName;

            public StringField ShortName;

            public StringField Description;

            public BooleanField IsActive;


		}
    }
}
