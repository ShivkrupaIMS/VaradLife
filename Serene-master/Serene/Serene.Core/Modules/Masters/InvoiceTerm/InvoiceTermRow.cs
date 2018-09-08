
namespace Serene.Masters.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Masters"), Module("Masters"), TableName("[dbo].[InvoiceTerm]")]
    [DisplayName("Invoice Term"), InstanceName("Invoice Term")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    [LookupScript]
    public sealed class InvoiceTermRow : Row, IIdRow, INameRow
    {

        [DisplayName("Invoice Term Id"), Identity]
        public Int32? InvoiceTermId
        {
            get { return Fields.InvoiceTermId[this]; }
            set { Fields.InvoiceTermId[this] = value; }
        }

        [DisplayName("Invoice Term"), Size(255), NotNull, QuickSearch]
        public String InvoiceTerm
        {
            get { return Fields.InvoiceTerm[this]; }
            set { Fields.InvoiceTerm[this] = value; }
        }

        [DisplayName("Is Active"), NotNull]
        public Boolean? IsActive
        {
            get { return Fields.IsActive[this]; }
            set { Fields.IsActive[this] = value; }
        }



        IIdField IIdRow.IdField
        {
            get { return Fields.InvoiceTermId; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.InvoiceTerm; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public InvoiceTermRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {

            public Int32Field InvoiceTermId;

            public StringField InvoiceTerm;

            public BooleanField IsActive;


		}
    }
}
