
namespace Serene.Masters.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Masters"), Module("Masters"), TableName("[dbo].[PurchaseInvoiceDetails]")]
    [DisplayName("Purchase Invoice Details"), InstanceName("Purchase Invoice Details")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class PurchaseInvoiceDetailsRow : Row, IIdRow, INameRow
    {

        [DisplayName("Purchase Invoice Details Id"), Identity]
        public Int32? PurchaseInvoiceDetailsId
        {
            get { return Fields.PurchaseInvoiceDetailsId[this]; }
            set { Fields.PurchaseInvoiceDetailsId[this] = value; }
        }

        [DisplayName("Purchase Invoice"), NotNull, ForeignKey("[dbo].[PurchaseInvoice]", "PurchaseInvoiceId"), LeftJoin("jPurchaseInvoice"), TextualField("PurchaseInvoicePurchaseInvoiceNumber")]
        public Int32? PurchaseInvoiceId
        {
            get { return Fields.PurchaseInvoiceId[this]; }
            set { Fields.PurchaseInvoiceId[this] = value; }
        }

        [DisplayName("Product"), NotNull, ForeignKey("[dbo].[Product]", "ProductId"), LeftJoin("jProduct"), TextualField("ProductProductName")]
        [LookupEditor(typeof(ProductRow), InplaceAdd = true)]
        public Int32? ProductId
        {
            get { return Fields.ProductId[this]; }
            set { Fields.ProductId[this] = value; }
        }

        [DisplayName("Product Details"), NotNull, ForeignKey("[dbo].[ProductDetails]", "ProductDetailsId"), LeftJoin("jProductDetails"), TextualField("ProductDetailsSku")]
        [LookupEditor(typeof(ProductDetailsRow), InplaceAdd = true, CascadeFrom = "ProductId", CascadeField = "ProductId")]
        public Int32? ProductDetailsId
        {
            get { return Fields.ProductDetailsId[this]; }
            set { Fields.ProductDetailsId[this] = value; }
        }

        [DisplayName("Package Size"), Size(255), NotNull, QuickSearch]
        public String PackageSize
        {
            get { return Fields.PackageSize[this]; }
            set { Fields.PackageSize[this] = value; }
        }

        [DisplayName("Batch Number"), Size(100), NotNull]
        public String BatchNumber
        {
            get { return Fields.BatchNumber[this]; }
            set { Fields.BatchNumber[this] = value; }
        }

        [DisplayName("Expiry Date"), NotNull]
        public DateTime? ExpiryDate
        {
            get { return Fields.ExpiryDate[this]; }
            set { Fields.ExpiryDate[this] = value; }
        }

        [DisplayName("Quantity"), NotNull]
        public Int32? Quantity
        {
            get { return Fields.Quantity[this]; }
            set { Fields.Quantity[this] = value; }
        }

        [DisplayName("Discount Percent"), NotNull]
        public Double? DiscountPercent
        {
            get { return Fields.DiscountPercent[this]; }
            set { Fields.DiscountPercent[this] = value; }
        }

        [DisplayName("Product Value"), NotNull]
        public Double? ProductValue
        {
            get { return Fields.ProductValue[this]; }
            set { Fields.ProductValue[this] = value; }
        }

        [DisplayName("Discount Value"), NotNull]
        public Double? DiscountValue
        {
            get { return Fields.DiscountValue[this]; }
            set { Fields.DiscountValue[this] = value; }
        }

        [DisplayName("Taxable Value"), NotNull]
        public Double? TaxableValue
        {
            get { return Fields.TaxableValue[this]; }
            set { Fields.TaxableValue[this] = value; }
        }

        [DisplayName("Igst Rate"), Column("IGSTRate"), NotNull]
        public Double? IgstRate
        {
            get { return Fields.IgstRate[this]; }
            set { Fields.IgstRate[this] = value; }
        }

        [DisplayName("Igst Amount"), Column("IGSTAmount"), NotNull]
        public Double? IgstAmount
        {
            get { return Fields.IgstAmount[this]; }
            set { Fields.IgstAmount[this] = value; }
        }

        [DisplayName("Cgst Rate"), Column("CGSTRate"), NotNull]
        public Double? CgstRate
        {
            get { return Fields.CgstRate[this]; }
            set { Fields.CgstRate[this] = value; }
        }

        [DisplayName("Cgst Amount"), Column("CGSTAmount"), NotNull]
        public Double? CgstAmount
        {
            get { return Fields.CgstAmount[this]; }
            set { Fields.CgstAmount[this] = value; }
        }

        [DisplayName("Sgst Rate"), Column("SGSTRate"), NotNull]
        public Double? SgstRate
        {
            get { return Fields.SgstRate[this]; }
            set { Fields.SgstRate[this] = value; }
        }

        [DisplayName("Sgst Amount"), Column("SGSTAmount"), NotNull]
        public Double? SgstAmount
        {
            get { return Fields.SgstAmount[this]; }
            set { Fields.SgstAmount[this] = value; }
        }

        [DisplayName("Cess Rate"), NotNull]
        public Double? CessRate
        {
            get { return Fields.CessRate[this]; }
            set { Fields.CessRate[this] = value; }
        }

        [DisplayName("Cess Amount"), NotNull]
        public Double? CessAmount
        {
            get { return Fields.CessAmount[this]; }
            set { Fields.CessAmount[this] = value; }
        }

        [DisplayName("Total Tax Plus Cess"), NotNull]
        public Double? TotalTaxPlusCess
        {
            get { return Fields.TotalTaxPlusCess[this]; }
            set { Fields.TotalTaxPlusCess[this] = value; }
        }

        [DisplayName("Total Transaction Amount"), NotNull]
        public Double? TotalTransactionAmount
        {
            get { return Fields.TotalTransactionAmount[this]; }
            set { Fields.TotalTransactionAmount[this] = value; }
        }

        [DisplayName("Is Active"), NotNull]
        public Boolean? IsActive
        {
            get { return Fields.IsActive[this]; }
            set { Fields.IsActive[this] = value; }
        }



        [DisplayName("Purchase Invoice Invoice Status Id"), Expression("jPurchaseInvoice.[InvoiceStatusId]")]
        public Int32? PurchaseInvoiceInvoiceStatusId
        {
            get { return Fields.PurchaseInvoiceInvoiceStatusId[this]; }
            set { Fields.PurchaseInvoiceInvoiceStatusId[this] = value; }
        }

        [DisplayName("Purchase Invoice Invoice Term Id"), Expression("jPurchaseInvoice.[InvoiceTermId]")]
        public Int32? PurchaseInvoiceInvoiceTermId
        {
            get { return Fields.PurchaseInvoiceInvoiceTermId[this]; }
            set { Fields.PurchaseInvoiceInvoiceTermId[this] = value; }
        }

        [DisplayName("Purchase Invoice Suppliers Id"), Expression("jPurchaseInvoice.[SuppliersId]")]
        public Int32? PurchaseInvoiceSuppliersId
        {
            get { return Fields.PurchaseInvoiceSuppliersId[this]; }
            set { Fields.PurchaseInvoiceSuppliersId[this] = value; }
        }

        [DisplayName("Purchase Invoice Invoice Date"), Expression("jPurchaseInvoice.[InvoiceDate]")]
        public DateTime? PurchaseInvoiceInvoiceDate
        {
            get { return Fields.PurchaseInvoiceInvoiceDate[this]; }
            set { Fields.PurchaseInvoiceInvoiceDate[this] = value; }
        }

        [DisplayName("Purchase Invoice Payment Due Date"), Expression("jPurchaseInvoice.[PaymentDueDate]")]
        public DateTime? PurchaseInvoicePaymentDueDate
        {
            get { return Fields.PurchaseInvoicePaymentDueDate[this]; }
            set { Fields.PurchaseInvoicePaymentDueDate[this] = value; }
        }

        [DisplayName("Purchase Invoice Purchase Invoice Number"), Expression("jPurchaseInvoice.[PurchaseInvoiceNumber]")]
        public String PurchaseInvoicePurchaseInvoiceNumber
        {
            get { return Fields.PurchaseInvoicePurchaseInvoiceNumber[this]; }
            set { Fields.PurchaseInvoicePurchaseInvoiceNumber[this] = value; }
        }

        [DisplayName("Purchase Invoice Total Taxable Amount"), Expression("jPurchaseInvoice.[TotalTaxableAmount]")]
        public Double? PurchaseInvoiceTotalTaxableAmount
        {
            get { return Fields.PurchaseInvoiceTotalTaxableAmount[this]; }
            set { Fields.PurchaseInvoiceTotalTaxableAmount[this] = value; }
        }

        [DisplayName("Purchase Invoice Total Tax"), Expression("jPurchaseInvoice.[TotalTax]")]
        public Double? PurchaseInvoiceTotalTax
        {
            get { return Fields.PurchaseInvoiceTotalTax[this]; }
            set { Fields.PurchaseInvoiceTotalTax[this] = value; }
        }

        [DisplayName("Purchase Invoice Total Amount"), Expression("jPurchaseInvoice.[TotalAmount]")]
        public Double? PurchaseInvoiceTotalAmount
        {
            get { return Fields.PurchaseInvoiceTotalAmount[this]; }
            set { Fields.PurchaseInvoiceTotalAmount[this] = value; }
        }

        [DisplayName("Purchase Invoice Is Reverse Charge"), Expression("jPurchaseInvoice.[IsReverseCharge]")]
        public Boolean? PurchaseInvoiceIsReverseCharge
        {
            get { return Fields.PurchaseInvoiceIsReverseCharge[this]; }
            set { Fields.PurchaseInvoiceIsReverseCharge[this] = value; }
        }

        [DisplayName("Purchase Invoice Is Active"), Expression("jPurchaseInvoice.[IsActive]")]
        public Boolean? PurchaseInvoiceIsActive
        {
            get { return Fields.PurchaseInvoiceIsActive[this]; }
            set { Fields.PurchaseInvoiceIsActive[this] = value; }
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



        [DisplayName("Product Details Product Id"), Expression("jProductDetails.[ProductId]")]
        public Int32? ProductDetailsProductId
        {
            get { return Fields.ProductDetailsProductId[this]; }
            set { Fields.ProductDetailsProductId[this] = value; }
        }

        [DisplayName("Product Details Sku"), Expression("jProductDetails.[Sku]")]
        public String ProductDetailsSku
        {
            get { return Fields.ProductDetailsSku[this]; }
            set { Fields.ProductDetailsSku[this] = value; }
        }

        [DisplayName("Product Details Product Unit Id"), Expression("jProductDetails.[ProductUnitId]")]
        public Int32? ProductDetailsProductUnitId
        {
            get { return Fields.ProductDetailsProductUnitId[this]; }
            set { Fields.ProductDetailsProductUnitId[this] = value; }
        }

        [DisplayName("Product Details Package Size"), Expression("jProductDetails.[PackageSize]")]
        public Int32? ProductDetailsPackageSize
        {
            get { return Fields.ProductDetailsPackageSize[this]; }
            set { Fields.ProductDetailsPackageSize[this] = value; }
        }

        [DisplayName("Product Details Purchase Price"), Expression("jProductDetails.[PurchasePrice]")]
        public Double? ProductDetailsPurchasePrice
        {
            get { return Fields.ProductDetailsPurchasePrice[this]; }
            set { Fields.ProductDetailsPurchasePrice[this] = value; }
        }

        [DisplayName("Product Details Sale Price"), Expression("jProductDetails.[SalePrice]")]
        public Double? ProductDetailsSalePrice
        {
            get { return Fields.ProductDetailsSalePrice[this]; }
            set { Fields.ProductDetailsSalePrice[this] = value; }
        }

        [DisplayName("Product Details Mrp"), Expression("jProductDetails.[MRP]")]
        public Double? ProductDetailsMrp
        {
            get { return Fields.ProductDetailsMrp[this]; }
            set { Fields.ProductDetailsMrp[this] = value; }
        }

        [DisplayName("Product Details Package Weight"), Expression("jProductDetails.[PackageWeight]")]
        public String ProductDetailsPackageWeight
        {
            get { return Fields.ProductDetailsPackageWeight[this]; }
            set { Fields.ProductDetailsPackageWeight[this] = value; }
        }

        [DisplayName("Product Details Manufacturer Id"), Expression("jProductDetails.[ManufacturerId]")]
        public Int32? ProductDetailsManufacturerId
        {
            get { return Fields.ProductDetailsManufacturerId[this]; }
            set { Fields.ProductDetailsManufacturerId[this] = value; }
        }

        [DisplayName("Product Details Min Quantity"), Expression("jProductDetails.[MinQuantity]")]
        public Int32? ProductDetailsMinQuantity
        {
            get { return Fields.ProductDetailsMinQuantity[this]; }
            set { Fields.ProductDetailsMinQuantity[this] = value; }
        }

        [DisplayName("Product Details Discount"), Expression("jProductDetails.[Discount]")]
        public Double? ProductDetailsDiscount
        {
            get { return Fields.ProductDetailsDiscount[this]; }
            set { Fields.ProductDetailsDiscount[this] = value; }
        }

        [DisplayName("Product Details Description"), Expression("jProductDetails.[Description]")]
        public String ProductDetailsDescription
        {
            get { return Fields.ProductDetailsDescription[this]; }
            set { Fields.ProductDetailsDescription[this] = value; }
        }

        [DisplayName("Product Details Is Active"), Expression("jProductDetails.[IsActive]")]
        public Boolean? ProductDetailsIsActive
        {
            get { return Fields.ProductDetailsIsActive[this]; }
            set { Fields.ProductDetailsIsActive[this] = value; }
        }



        IIdField IIdRow.IdField
        {
            get { return Fields.PurchaseInvoiceDetailsId; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.PackageSize; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public PurchaseInvoiceDetailsRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {

            public Int32Field PurchaseInvoiceDetailsId;

            public Int32Field PurchaseInvoiceId;

            public Int32Field ProductId;

            public Int32Field ProductDetailsId;

            public StringField PackageSize;

            public StringField BatchNumber;

            public DateTimeField ExpiryDate;

            public Int32Field Quantity;

            public DoubleField DiscountPercent;

            public DoubleField ProductValue;

            public DoubleField DiscountValue;

            public DoubleField TaxableValue;

            public DoubleField IgstRate;

            public DoubleField IgstAmount;

            public DoubleField CgstRate;

            public DoubleField CgstAmount;

            public DoubleField SgstRate;

            public DoubleField SgstAmount;

            public DoubleField CessRate;

            public DoubleField CessAmount;

            public DoubleField TotalTaxPlusCess;

            public DoubleField TotalTransactionAmount;

            public BooleanField IsActive;



            public Int32Field PurchaseInvoiceInvoiceStatusId;

            public Int32Field PurchaseInvoiceInvoiceTermId;

            public Int32Field PurchaseInvoiceSuppliersId;

            public DateTimeField PurchaseInvoiceInvoiceDate;

            public DateTimeField PurchaseInvoicePaymentDueDate;

            public StringField PurchaseInvoicePurchaseInvoiceNumber;

            public DoubleField PurchaseInvoiceTotalTaxableAmount;

            public DoubleField PurchaseInvoiceTotalTax;

            public DoubleField PurchaseInvoiceTotalAmount;

            public BooleanField PurchaseInvoiceIsReverseCharge;

            public BooleanField PurchaseInvoiceIsActive;



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



            public Int32Field ProductDetailsProductId;

            public StringField ProductDetailsSku;

            public Int32Field ProductDetailsProductUnitId;

            public Int32Field ProductDetailsPackageSize;

            public DoubleField ProductDetailsPurchasePrice;

            public DoubleField ProductDetailsSalePrice;

            public DoubleField ProductDetailsMrp;

            public StringField ProductDetailsPackageWeight;

            public Int32Field ProductDetailsManufacturerId;

            public Int32Field ProductDetailsMinQuantity;

            public DoubleField ProductDetailsDiscount;

            public StringField ProductDetailsDescription;

            public BooleanField ProductDetailsIsActive;


		}
    }
}
