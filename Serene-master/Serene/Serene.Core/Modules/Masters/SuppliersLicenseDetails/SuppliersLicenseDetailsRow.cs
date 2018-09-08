
namespace Serene.Masters.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Masters"), Module("Masters"), TableName("[dbo].[SuppliersLicenseDetails]")]
    [DisplayName("Suppliers License Details"), InstanceName("Suppliers License Details")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class SuppliersLicenseDetailsRow : Row, IIdRow, INameRow
    {

        [DisplayName("Suppliers License Details Id"), Identity]
        public Int32? SuppliersLicenseDetailsId
        {
            get { return Fields.SuppliersLicenseDetailsId[this]; }
            set { Fields.SuppliersLicenseDetailsId[this] = value; }
        }

        [DisplayName("License Type"), NotNull, ForeignKey("[dbo].[LicenseType]", "LicenseTypeId"), LeftJoin("jLicenseType"), TextualField("LicenseType")]
        [LookupEditor(typeof(LicenseTypeRow), InplaceAdd = true)]
        public Int32? LicenseTypeId
        {
            get { return Fields.LicenseTypeId[this]; }
            set { Fields.LicenseTypeId[this] = value; }
        }

        [DisplayName("Suppliers"), NotNull, ForeignKey("[dbo].[Suppliers]", "SuppliersId"), LeftJoin("jSuppliers"), TextualField("SuppliersSuppliersName")]
        public Int32? SuppliersId
        {
            get { return Fields.SuppliersId[this]; }
            set { Fields.SuppliersId[this] = value; }
        }

        [DisplayName("License No"), Size(50), NotNull, QuickSearch]
        public String LicenseNo
        {
            get { return Fields.LicenseNo[this]; }
            set { Fields.LicenseNo[this] = value; }
        }

        [DisplayName("Valid From")]
        public DateTime? ValidFrom
        {
            get { return Fields.ValidFrom[this]; }
            set { Fields.ValidFrom[this] = value; }
        }

        [DisplayName("Valid To")]
        public DateTime? ValidTo
        {
            get { return Fields.ValidTo[this]; }
            set { Fields.ValidTo[this] = value; }
        }

        [DisplayName("Is Active"), NotNull]
        public Boolean? IsActive
        {
            get { return Fields.IsActive[this]; }
            set { Fields.IsActive[this] = value; }
        }



        [DisplayName("License Type"), Expression("jLicenseType.[LicenseType]")]
        public String LicenseType
        {
            get { return Fields.LicenseType[this]; }
            set { Fields.LicenseType[this] = value; }
        }

        [DisplayName("License Type Short Name"), Expression("jLicenseType.[ShortName]")]
        public String LicenseTypeShortName
        {
            get { return Fields.LicenseTypeShortName[this]; }
            set { Fields.LicenseTypeShortName[this] = value; }
        }

        [DisplayName("License Type Description"), Expression("jLicenseType.[Description]")]
        public String LicenseTypeDescription
        {
            get { return Fields.LicenseTypeDescription[this]; }
            set { Fields.LicenseTypeDescription[this] = value; }
        }

        [DisplayName("License Type Is Active"), Expression("jLicenseType.[IsActive]")]
        public Boolean? LicenseTypeIsActive
        {
            get { return Fields.LicenseTypeIsActive[this]; }
            set { Fields.LicenseTypeIsActive[this] = value; }
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
            get { return Fields.SuppliersLicenseDetailsId; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.LicenseNo; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public SuppliersLicenseDetailsRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {

            public Int32Field SuppliersLicenseDetailsId;

            public Int32Field LicenseTypeId;

            public Int32Field SuppliersId;

            public StringField LicenseNo;

            public DateTimeField ValidFrom;

            public DateTimeField ValidTo;

            public BooleanField IsActive;



            public StringField LicenseType;

            public StringField LicenseTypeShortName;

            public StringField LicenseTypeDescription;

            public BooleanField LicenseTypeIsActive;



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


		}
    }
}
