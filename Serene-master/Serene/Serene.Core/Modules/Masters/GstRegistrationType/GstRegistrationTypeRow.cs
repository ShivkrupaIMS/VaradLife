
namespace Serene.Masters.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Masters"), Module("Masters"), TableName("[dbo].[GSTRegistrationType]")]
    [DisplayName("Gst Registration Type"), InstanceName("Gst Registration Type")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    [LookupScript]
    public sealed class GstRegistrationTypeRow : Row, IIdRow, INameRow
    {

        [DisplayName("Gst Registration Type Id"), Column("GSTRegistrationTypeId"), Identity]
        public Int32? GstRegistrationTypeId
        {
            get { return Fields.GstRegistrationTypeId[this]; }
            set { Fields.GstRegistrationTypeId[this] = value; }
        }

        [DisplayName("Gst Registration Type"), Column("GSTRegistrationType"), Size(255), NotNull, QuickSearch]
        public String GstRegistrationType
        {
            get { return Fields.GstRegistrationType[this]; }
            set { Fields.GstRegistrationType[this] = value; }
        }

        [DisplayName("Is Active"), NotNull]
        public Boolean? IsActive
        {
            get { return Fields.IsActive[this]; }
            set { Fields.IsActive[this] = value; }
        }



        IIdField IIdRow.IdField
        {
            get { return Fields.GstRegistrationTypeId; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.GstRegistrationType; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public GstRegistrationTypeRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {

            public Int32Field GstRegistrationTypeId;

            public StringField GstRegistrationType;

            public BooleanField IsActive;


		}
    }
}
