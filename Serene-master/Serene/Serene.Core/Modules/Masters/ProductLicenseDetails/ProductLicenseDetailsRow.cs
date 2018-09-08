
namespace Serene.Masters.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Masters"), Module("Masters"), TableName("[dbo].[ProductLicenseDetails]")]
    [DisplayName("Product License Details"), InstanceName("Product License Details")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class ProductLicenseDetailsRow : Row, IIdRow
    {

        [DisplayName("Product License Details Id"), Identity]
        public Int32? ProductLicenseDetailsId
        {
            get { return Fields.ProductLicenseDetailsId[this]; }
            set { Fields.ProductLicenseDetailsId[this] = value; }
        }

        [DisplayName("License Type"), NotNull, ForeignKey("[dbo].[LicenseType]", "LicenseTypeId"), LeftJoin("jLicenseType"), TextualField("LicenseType")]
        [LookupEditor(typeof(LicenseTypeRow), InplaceAdd = true)]
        public Int32? LicenseTypeId
        {
            get { return Fields.LicenseTypeId[this]; }
            set { Fields.LicenseTypeId[this] = value; }
        }

        [DisplayName("Product"), NotNull, ForeignKey("[dbo].[Product]", "ProductId"), LeftJoin("jProduct"), TextualField("ProductProductName")]
        public Int32? ProductId
        {
            get { return Fields.ProductId[this]; }
            set { Fields.ProductId[this] = value; }
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



        [DisplayName("Product Hsn Sac Id"), Expression("jProduct.[HsnSacId]")]
        public Int32? ProductHsnSacId
        {
            get { return Fields.ProductHsnSacId[this]; }
            set { Fields.ProductHsnSacId[this] = value; }
        }

        [DisplayName("Product Product Name"), Expression("jProduct.[ProductName]")]
        public String ProductProductName
        {
            get { return Fields.ProductProductName[this]; }
            set { Fields.ProductProductName[this] = value; }
        }

        [DisplayName("Product Product Type Id"), Expression("jProduct.[ProductTypeId]")]
        public Int32? ProductProductTypeId
        {
            get { return Fields.ProductProductTypeId[this]; }
            set { Fields.ProductProductTypeId[this] = value; }
        }

        [DisplayName("Product Description"), Expression("jProduct.[Description]")]
        public String ProductDescription
        {
            get { return Fields.ProductDescription[this]; }
            set { Fields.ProductDescription[this] = value; }
        }

        [DisplayName("Product Ingredient"), Expression("jProduct.[Ingredient]")]
        public String ProductIngredient
        {
            get { return Fields.ProductIngredient[this]; }
            set { Fields.ProductIngredient[this] = value; }
        }

        [DisplayName("Product Igst"), Expression("jProduct.[IGST]")]
        public Double? ProductIgst
        {
            get { return Fields.ProductIgst[this]; }
            set { Fields.ProductIgst[this] = value; }
        }

        [DisplayName("Product Cgst"), Expression("jProduct.[CGST]")]
        public Double? ProductCgst
        {
            get { return Fields.ProductCgst[this]; }
            set { Fields.ProductCgst[this] = value; }
        }

        [DisplayName("Product Sgst"), Expression("jProduct.[SGST]")]
        public Double? ProductSgst
        {
            get { return Fields.ProductSgst[this]; }
            set { Fields.ProductSgst[this] = value; }
        }

        [DisplayName("Product Comment"), Expression("jProduct.[Comment]")]
        public String ProductComment
        {
            get { return Fields.ProductComment[this]; }
            set { Fields.ProductComment[this] = value; }
        }

        [DisplayName("Product Is Active"), Expression("jProduct.[IsActive]")]
        public Boolean? ProductIsActive
        {
            get { return Fields.ProductIsActive[this]; }
            set { Fields.ProductIsActive[this] = value; }
        }



        IIdField IIdRow.IdField
        {
            get { return Fields.ProductLicenseDetailsId; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public ProductLicenseDetailsRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {

            public Int32Field ProductLicenseDetailsId;

            public Int32Field LicenseTypeId;

            public Int32Field ProductId;

            public BooleanField IsActive;



            public StringField LicenseType;

            public StringField LicenseTypeShortName;

            public StringField LicenseTypeDescription;

            public BooleanField LicenseTypeIsActive;



            public Int32Field ProductHsnSacId;

            public StringField ProductProductName;

            public Int32Field ProductProductTypeId;

            public StringField ProductDescription;

            public StringField ProductIngredient;

            public DoubleField ProductIgst;

            public DoubleField ProductCgst;

            public DoubleField ProductSgst;

            public StringField ProductComment;

            public BooleanField ProductIsActive;


		}
    }
}
