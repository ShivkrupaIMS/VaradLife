
namespace Serene.Masters.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Masters"), Module("Masters"), TableName("[dbo].[LicenseType]")]
    [DisplayName("License Type"), InstanceName("License Type")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    [LookupScript]
    public sealed class LicenseTypeRow : Row, IIdRow, INameRow
    {

        [DisplayName("License Type Id"), Identity]
        public Int32? LicenseTypeId
        {
            get { return Fields.LicenseTypeId[this]; }
            set { Fields.LicenseTypeId[this] = value; }
        }

        [DisplayName("License Type"), Size(255), NotNull, QuickSearch]
        public String LicenseType
        {
            get { return Fields.LicenseType[this]; }
            set { Fields.LicenseType[this] = value; }
        }

        [DisplayName("Short Name"), Size(50), NotNull]
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
            get { return Fields.LicenseTypeId; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.LicenseType; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public LicenseTypeRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {

            public Int32Field LicenseTypeId;

            public StringField LicenseType;

            public StringField ShortName;

            public StringField Description;

            public BooleanField IsActive;


		}
    }
}
