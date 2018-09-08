
namespace Serene.Masters.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Masters"), Module("Masters"), TableName("[dbo].[ProductDetails]")]
    [DisplayName("Product Details"), InstanceName("Product Details")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    [LookupScript]
    public sealed class ProductDetailsRow : Row, IIdRow, INameRow
    {

        [DisplayName("Product Details Id"), Identity]
        public Int32? ProductDetailsId
        {
            get { return Fields.ProductDetailsId[this]; }
            set { Fields.ProductDetailsId[this] = value; }
        }

        [DisplayName("Product"), NotNull, ForeignKey("[dbo].[Product]", "ProductId"), LeftJoin("jProduct"), TextualField("ProductProductName"), LookupInclude]
        public Int32? ProductId
        {
            get { return Fields.ProductId[this]; }
            set { Fields.ProductId[this] = value; }
        }

        [DisplayName("Sku"), Size(255), NotNull, QuickSearch]
        public String Sku
        {
            get { return Fields.Sku[this]; }
            set { Fields.Sku[this] = value; }
        }

        [DisplayName("Product Unit"), NotNull, ForeignKey("[dbo].[ProductUnit]", "ProductUnitId"), LeftJoin("jProductUnit"), TextualField("ProductUnit")]
        [LookupEditor(typeof(ProductUnitRow), InplaceAdd = true)]
        public Int32? ProductUnitId
        {
            get { return Fields.ProductUnitId[this]; }
            set { Fields.ProductUnitId[this] = value; }
        }

        [DisplayName("Package Size"), NotNull, LookupInclude]
        public Int32? PackageSize
        {
            get { return Fields.PackageSize[this]; }
            set { Fields.PackageSize[this] = value; }
        }

        [DisplayName("Purchase Price"), LookupInclude]
        public Double? PurchasePrice
        {
            get { return Fields.PurchasePrice[this]; }
            set { Fields.PurchasePrice[this] = value; }
        }

        [DisplayName("Sale Price")]
        public Double? SalePrice
        {
            get { return Fields.SalePrice[this]; }
            set { Fields.SalePrice[this] = value; }
        }

        [DisplayName("Mrp"), Column("MRP")]
        public Double? Mrp
        {
            get { return Fields.Mrp[this]; }
            set { Fields.Mrp[this] = value; }
        }

        [DisplayName("Package Weight"), Size(50), LookupInclude]
        public String PackageWeight
        {
            get { return Fields.PackageWeight[this]; }
            set { Fields.PackageWeight[this] = value; }
        }

        [DisplayName("Manufacturer"), ForeignKey("[dbo].[Manufacturer]", "ManufacturerId"), LeftJoin("jManufacturer"), TextualField("ManufacturerManufacturerName")]
        [LookupEditor(typeof(ManufacturerRow), InplaceAdd = true)]
        public Int32? ManufacturerId
        {
            get { return Fields.ManufacturerId[this]; }
            set { Fields.ManufacturerId[this] = value; }
        }

        [DisplayName("Min Quantity")]
        public Int32? MinQuantity
        {
            get { return Fields.MinQuantity[this]; }
            set { Fields.MinQuantity[this] = value; }
        }

        [DisplayName("Discount")]
        public Double? Discount
        {
            get { return Fields.Discount[this]; }
            set { Fields.Discount[this] = value; }
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



        [DisplayName("Product Unit"), Expression("jProductUnit.[ProductUnit]"), LookupInclude]
        public String ProductUnit
        {
            get { return Fields.ProductUnit[this]; }
            set { Fields.ProductUnit[this] = value; }
        }

        [DisplayName("Product Unit Is Active"), Expression("jProductUnit.[IsActive]")]
        public Boolean? ProductUnitIsActive
        {
            get { return Fields.ProductUnitIsActive[this]; }
            set { Fields.ProductUnitIsActive[this] = value; }
        }



        [DisplayName("Manufacturer Manufacturer Name"), Expression("jManufacturer.[ManufacturerName]")]
        public String ManufacturerManufacturerName
        {
            get { return Fields.ManufacturerManufacturerName[this]; }
            set { Fields.ManufacturerManufacturerName[this] = value; }
        }

        [DisplayName("Manufacturer Short Name"), Expression("jManufacturer.[ShortName]")]
        public String ManufacturerShortName
        {
            get { return Fields.ManufacturerShortName[this]; }
            set { Fields.ManufacturerShortName[this] = value; }
        }

        [DisplayName("Manufacturer Description"), Expression("jManufacturer.[Description]")]
        public String ManufacturerDescription
        {
            get { return Fields.ManufacturerDescription[this]; }
            set { Fields.ManufacturerDescription[this] = value; }
        }

        [DisplayName("Manufacturer Is Active"), Expression("jManufacturer.[IsActive]")]
        public Boolean? ManufacturerIsActive
        {
            get { return Fields.ManufacturerIsActive[this]; }
            set { Fields.ManufacturerIsActive[this] = value; }
        }



        IIdField IIdRow.IdField
        {
            get { return Fields.ProductDetailsId; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.Sku; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public ProductDetailsRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {

            public Int32Field ProductDetailsId;

            public Int32Field ProductId;

            public StringField Sku;

            public Int32Field ProductUnitId;

            public Int32Field PackageSize;

            public DoubleField PurchasePrice;

            public DoubleField SalePrice;

            public DoubleField Mrp;

            public StringField PackageWeight;

            public Int32Field ManufacturerId;

            public Int32Field MinQuantity;

            public DoubleField Discount;

            public StringField Description;

            public BooleanField IsActive;



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



            public StringField ProductUnit;

            public BooleanField ProductUnitIsActive;



            public StringField ManufacturerManufacturerName;

            public StringField ManufacturerShortName;

            public StringField ManufacturerDescription;

            public BooleanField ManufacturerIsActive;


		}
    }
}
