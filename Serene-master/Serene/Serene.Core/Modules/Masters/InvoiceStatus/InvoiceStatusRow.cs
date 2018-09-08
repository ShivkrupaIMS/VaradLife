
namespace Serene.Masters.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Masters"), Module("Masters"), TableName("[dbo].[InvoiceStatus]")]
    [DisplayName("Invoice Status"), InstanceName("Invoice Status")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    [LookupScript]
    public sealed class InvoiceStatusRow : Row, IIdRow, INameRow
    {

        [DisplayName("Invoice Status Id"), Identity]
        public Int32? InvoiceStatusId
        {
            get { return Fields.InvoiceStatusId[this]; }
            set { Fields.InvoiceStatusId[this] = value; }
        }

        [DisplayName("Invoice Status"), Size(255), NotNull, QuickSearch]
        public String InvoiceStatus
        {
            get { return Fields.InvoiceStatus[this]; }
            set { Fields.InvoiceStatus[this] = value; }
        }

        [DisplayName("Is Active"), NotNull]
        public Boolean? IsActive
        {
            get { return Fields.IsActive[this]; }
            set { Fields.IsActive[this] = value; }
        }



        IIdField IIdRow.IdField
        {
            get { return Fields.InvoiceStatusId; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.InvoiceStatus; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public InvoiceStatusRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {

            public Int32Field InvoiceStatusId;

            public StringField InvoiceStatus;

            public BooleanField IsActive;


		}
    }
}
