
namespace Serene.Masters.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Masters"), Module("Masters"), TableName("[dbo].[PurchaseInvoice]")]
    [DisplayName("Purchase Invoice"), InstanceName("Purchase Invoice")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class PurchaseInvoiceRow : Row, IIdRow, INameRow
    {

        [DisplayName("Purchase Invoice Id"), Identity]
        public Int32? PurchaseInvoiceId
        {
            get { return Fields.PurchaseInvoiceId[this]; }
            set { Fields.PurchaseInvoiceId[this] = value; }
        }

        [DisplayName("Invoice Status"), NotNull, ForeignKey("[dbo].[InvoiceStatus]", "InvoiceStatusId"), LeftJoin("jInvoiceStatus"), TextualField("InvoiceStatus")]
        [LookupEditor(typeof(InvoiceStatusRow), InplaceAdd = true)]
        public Int32? InvoiceStatusId
        {
            get { return Fields.InvoiceStatusId[this]; }
            set { Fields.InvoiceStatusId[this] = value; }
        }

        [DisplayName("Invoice Term"), NotNull, ForeignKey("[dbo].[InvoiceTerm]", "InvoiceTermId"), LeftJoin("jInvoiceTerm"), TextualField("InvoiceTerm")]
        [LookupEditor(typeof(InvoiceTermRow), InplaceAdd = true)]
        public Int32? InvoiceTermId
        {
            get { return Fields.InvoiceTermId[this]; }
            set { Fields.InvoiceTermId[this] = value; }
        }

        [DisplayName("Suppliers"), NotNull, ForeignKey("[dbo].[Suppliers]", "SuppliersId"), LeftJoin("jSuppliers"), TextualField("SuppliersSuppliersName")]
        [LookupEditor(typeof(SuppliersRow), InplaceAdd = true)]
        public Int32? SuppliersId
        {
            get { return Fields.SuppliersId[this]; }
            set { Fields.SuppliersId[this] = value; }
        }

        [DisplayName("Invoice Date"), NotNull]
        public DateTime? InvoiceDate
        {
            get { return Fields.InvoiceDate[this]; }
            set { Fields.InvoiceDate[this] = value; }
        }

        [DisplayName("Payment Due Date"), NotNull]
        public DateTime? PaymentDueDate
        {
            get { return Fields.PaymentDueDate[this]; }
            set { Fields.PaymentDueDate[this] = value; }
        }

        [DisplayName("Purchase Invoice Number"), Size(255), NotNull, QuickSearch]
        public String PurchaseInvoiceNumber
        {
            get { return Fields.PurchaseInvoiceNumber[this]; }
            set { Fields.PurchaseInvoiceNumber[this] = value; }
        }

        [DisplayName("Total Taxable Amount"), NotNull]
        public Double? TotalTaxableAmount
        {
            get { return Fields.TotalTaxableAmount[this]; }
            set { Fields.TotalTaxableAmount[this] = value; }
        }

        [DisplayName("Total Tax"), NotNull]
        public Double? TotalTax
        {
            get { return Fields.TotalTax[this]; }
            set { Fields.TotalTax[this] = value; }
        }

        [DisplayName("Total Amount"), NotNull]
        public Double? TotalAmount
        {
            get { return Fields.TotalAmount[this]; }
            set { Fields.TotalAmount[this] = value; }
        }

        [DisplayName("Is Reverse Charge"), NotNull]
        public Boolean? IsReverseCharge
        {
            get { return Fields.IsReverseCharge[this]; }
            set { Fields.IsReverseCharge[this] = value; }
        }

        [DisplayName("Is Active"), NotNull]
        public Boolean? IsActive
        {
            get { return Fields.IsActive[this]; }
            set { Fields.IsActive[this] = value; }
        }

        [MasterDetailRelation(foreignKey: "PurchaseInvoiceId", IncludeColumns = "ProductProductName, ProductDetailsSku")]
        [DisplayName("Product List"), NotMapped]
        [PurchaseInvoiceDetailsEditor]
        public List<Entities.PurchaseInvoiceDetailsRow> PurchaseInvoiceDetailsList
        {
            get { return Fields.PurchaseInvoiceDetailsList[this]; }
            set { Fields.PurchaseInvoiceDetailsList[this] = value; }
        }


        [DisplayName("Invoice Status"), Expression("jInvoiceStatus.[InvoiceStatus]")]
        public String InvoiceStatus
        {
            get { return Fields.InvoiceStatus[this]; }
            set { Fields.InvoiceStatus[this] = value; }
        }

        [DisplayName("Invoice Status Is Active"), Expression("jInvoiceStatus.[IsActive]")]
        public Boolean? InvoiceStatusIsActive
        {
            get { return Fields.InvoiceStatusIsActive[this]; }
            set { Fields.InvoiceStatusIsActive[this] = value; }
        }



        [DisplayName("Invoice Term"), Expression("jInvoiceTerm.[InvoiceTerm]")]
        public String InvoiceTerm
        {
            get { return Fields.InvoiceTerm[this]; }
            set { Fields.InvoiceTerm[this] = value; }
        }

        [DisplayName("Invoice Term Is Active"), Expression("jInvoiceTerm.[IsActive]")]
        public Boolean? InvoiceTermIsActive
        {
            get { return Fields.InvoiceTermIsActive[this]; }
            set { Fields.InvoiceTermIsActive[this] = value; }
        }



        [DisplayName("Suppliers Suppliers Name"), Expression("jSuppliers.[SuppliersName]")]
        public String SuppliersSuppliersName
        {
            get { return Fields.SuppliersSuppliersName[this]; }
            set { Fields.SuppliersSuppliersName[this] = value; }
        }

        [DisplayName("Suppliers Supplier Type Id"), Expression("jSuppliers.[SupplierTypeId]")]
        public Int32? SuppliersSupplierTypeId
        {
            get { return Fields.SuppliersSupplierTypeId[this]; }
            set { Fields.SuppliersSupplierTypeId[this] = value; }
        }

        [DisplayName("Suppliers Gst No"), Expression("jSuppliers.[GSTNo]")]
        public String SuppliersGstNo
        {
            get { return Fields.SuppliersGstNo[this]; }
            set { Fields.SuppliersGstNo[this] = value; }
        }

        [DisplayName("Suppliers Gst Registration Type Id"), Expression("jSuppliers.[GSTRegistrationTypeId]")]
        public Int32? SuppliersGstRegistrationTypeId
        {
            get { return Fields.SuppliersGstRegistrationTypeId[this]; }
            set { Fields.SuppliersGstRegistrationTypeId[this] = value; }
        }

        [DisplayName("Suppliers Phone"), Expression("jSuppliers.[Phone]")]
        public String SuppliersPhone
        {
            get { return Fields.SuppliersPhone[this]; }
            set { Fields.SuppliersPhone[this] = value; }
        }

        [DisplayName("Suppliers Fax"), Expression("jSuppliers.[Fax]")]
        public String SuppliersFax
        {
            get { return Fields.SuppliersFax[this]; }
            set { Fields.SuppliersFax[this] = value; }
        }

        [DisplayName("Suppliers Email"), Expression("jSuppliers.[Email]")]
        public String SuppliersEmail
        {
            get { return Fields.SuppliersEmail[this]; }
            set { Fields.SuppliersEmail[this] = value; }
        }

        [DisplayName("Suppliers Address"), Expression("jSuppliers.[Address]")]
        public String SuppliersAddress
        {
            get { return Fields.SuppliersAddress[this]; }
            set { Fields.SuppliersAddress[this] = value; }
        }

        [DisplayName("Suppliers Country Id"), Expression("jSuppliers.[CountryId]")]
        public Int32? SuppliersCountryId
        {
            get { return Fields.SuppliersCountryId[this]; }
            set { Fields.SuppliersCountryId[this] = value; }
        }

        [DisplayName("Suppliers State Id"), Expression("jSuppliers.[StateId]")]
        public Int32? SuppliersStateId
        {
            get { return Fields.SuppliersStateId[this]; }
            set { Fields.SuppliersStateId[this] = value; }
        }

        [DisplayName("Suppliers Pin Code"), Expression("jSuppliers.[PinCode]")]
        public String SuppliersPinCode
        {
            get { return Fields.SuppliersPinCode[this]; }
            set { Fields.SuppliersPinCode[this] = value; }
        }

        [DisplayName("Suppliers Pan No"), Expression("jSuppliers.[PANNo]")]
        public String SuppliersPanNo
        {
            get { return Fields.SuppliersPanNo[this]; }
            set { Fields.SuppliersPanNo[this] = value; }
        }

        [DisplayName("Suppliers Website"), Expression("jSuppliers.[Website]")]
        public String SuppliersWebsite
        {
            get { return Fields.SuppliersWebsite[this]; }
            set { Fields.SuppliersWebsite[this] = value; }
        }

        [DisplayName("Suppliers Contact Person"), Expression("jSuppliers.[ContactPerson]")]
        public String SuppliersContactPerson
        {
            get { return Fields.SuppliersContactPerson[this]; }
            set { Fields.SuppliersContactPerson[this] = value; }
        }

        [DisplayName("Suppliers Mobile No"), Expression("jSuppliers.[MobileNo]")]
        public String SuppliersMobileNo
        {
            get { return Fields.SuppliersMobileNo[this]; }
            set { Fields.SuppliersMobileNo[this] = value; }
        }

        [DisplayName("Suppliers Cin No"), Expression("jSuppliers.[CINNo]")]
        public String SuppliersCinNo
        {
            get { return Fields.SuppliersCinNo[this]; }
            set { Fields.SuppliersCinNo[this] = value; }
        }

        [DisplayName("Suppliers Is Active"), Expression("jSuppliers.[IsActive]")]
        public Boolean? SuppliersIsActive
        {
            get { return Fields.SuppliersIsActive[this]; }
            set { Fields.SuppliersIsActive[this] = value; }
        }

        [DisplayName("Suppliers Opening Balance"), Expression("jSuppliers.[OpeningBalance]")]
        public Double? SuppliersOpeningBalance
        {
            get { return Fields.SuppliersOpeningBalance[this]; }
            set { Fields.SuppliersOpeningBalance[this] = value; }
        }



        IIdField IIdRow.IdField
        {
            get { return Fields.PurchaseInvoiceId; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.PurchaseInvoiceNumber; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public PurchaseInvoiceRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {

            public Int32Field PurchaseInvoiceId;

            public Int32Field InvoiceStatusId;

            public Int32Field InvoiceTermId;

            public Int32Field SuppliersId;

            public DateTimeField InvoiceDate;

            public DateTimeField PaymentDueDate;

            public StringField PurchaseInvoiceNumber;

            public DoubleField TotalTaxableAmount;

            public DoubleField TotalTax;

            public DoubleField TotalAmount;

            public BooleanField IsReverseCharge;

            public BooleanField IsActive;



            public StringField InvoiceStatus;

            public BooleanField InvoiceStatusIsActive;



            public StringField InvoiceTerm;

            public BooleanField InvoiceTermIsActive;



            public StringField SuppliersSuppliersName;

            public Int32Field SuppliersSupplierTypeId;

            public StringField SuppliersGstNo;

            public Int32Field SuppliersGstRegistrationTypeId;

            public StringField SuppliersPhone;

            public StringField SuppliersFax;

            public StringField SuppliersEmail;

            public StringField SuppliersAddress;

            public Int32Field SuppliersCountryId;

            public Int32Field SuppliersStateId;

            public StringField SuppliersPinCode;

            public StringField SuppliersPanNo;

            public StringField SuppliersWebsite;

            public StringField SuppliersContactPerson;

            public StringField SuppliersMobileNo;

            public StringField SuppliersCinNo;

            public BooleanField SuppliersIsActive;

            public DoubleField SuppliersOpeningBalance;

            public RowListField<Entities.PurchaseInvoiceDetailsRow> PurchaseInvoiceDetailsList;

        }
    }
}
