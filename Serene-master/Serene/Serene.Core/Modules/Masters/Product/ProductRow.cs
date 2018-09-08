
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

    [ConnectionKey("Masters"), Module("Masters"), TableName("[dbo].[Product]")]
    [DisplayName("Product"), InstanceName("Product")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    [LookupScript]
    public sealed class ProductRow : Row, IIdRow, INameRow
    {

        [DisplayName("Product Id"), Identity]
        public Int32? ProductId
        {
            get { return Fields.ProductId[this]; }
            set { Fields.ProductId[this] = value; }
        }

        [DisplayName("Hsn Sac"), ForeignKey("[dbo].[HSNSAC]", "HSNSACId"), LeftJoin("jHsnSac"), TextualField("HsnSacHsnsacNo"), LookupInclude]
        [LookupEditor(typeof(HsnsacRow), InplaceAdd = true)]
        public Int32? HsnSacId
        {
            get { return Fields.HsnSacId[this]; }
            set { Fields.HsnSacId[this] = value; }
        }

        [DisplayName("Product Name"), Size(255), NotNull, QuickSearch]
        public String ProductName
        {
            get { return Fields.ProductName[this]; }
            set { Fields.ProductName[this] = value; }
        }

        [DisplayName("Product Type"), NotNull, ForeignKey("[dbo].[ProductType]", "ProductTypeId"), LeftJoin("jProductType"), TextualField("ProductType")]
        [LookupEditor(typeof(ProductTypeRow), InplaceAdd = true)]
        public Int32? ProductTypeId
        {
            get { return Fields.ProductTypeId[this]; }
            set { Fields.ProductTypeId[this] = value; }
        }

        [DisplayName("Description"), Size(1000), NotNull]
        public String Description
        {
            get { return Fields.Description[this]; }
            set { Fields.Description[this] = value; }
        }

        [DisplayName("Ingredient"), Size(255)]
        public String Ingredient
        {
            get { return Fields.Ingredient[this]; }
            set { Fields.Ingredient[this] = value; }
        }

        [DisplayName("Igst"), Column("IGST"), NotNull, LookupInclude]
        public Double? Igst
        {
            get { return Fields.Igst[this]; }
            set { Fields.Igst[this] = value; }
        }

        [DisplayName("Cgst"), Column("CGST"), NotNull, LookupInclude]
        public Double? Cgst
        {
            get { return Fields.Cgst[this]; }
            set { Fields.Cgst[this] = value; }
        }

        [DisplayName("Sgst"), Column("SGST"), NotNull, LookupInclude]
        public Double? Sgst
        {
            get { return Fields.Sgst[this]; }
            set { Fields.Sgst[this] = value; }
        }

        [DisplayName("Comment"), Size(255), NotNull]
        public String Comment
        {
            get { return Fields.Comment[this]; }
            set { Fields.Comment[this] = value; }
        }

        [DisplayName("Is Active"), NotNull]
        public Boolean? IsActive
        {
            get { return Fields.IsActive[this]; }
            set { Fields.IsActive[this] = value; }
        }

        [MasterDetailRelation(foreignKey: "ProductId", IncludeColumns = "ManufacturerManufacturerName, ProductUnit")]
        [DisplayName("Product Details"), NotMapped]
        [ProductDetailsEditor]
        public List<Entities.ProductDetailsRow> ProductDetailsList
        {
            get { return Fields.ProductDetailsList[this]; }
            set { Fields.ProductDetailsList[this] = value; }
        }

        [MasterDetailRelation(foreignKey: "ProductId", IncludeColumns = "LicenseType")]
        [DisplayName("License List"), NotMapped]
        [ProductLicenseDetailsEditor]
        public List<Entities.ProductLicenseDetailsRow> LicenseList
        {
            get { return Fields.LicenseList[this]; }
            set { Fields.LicenseList[this] = value; }
        }

        [DisplayName("Hsn Sac Hsnsac No"), Expression("jHsnSac.[HSNSACNo]")]
        public String HsnSacHsnsacNo
        {
            get { return Fields.HsnSacHsnsacNo[this]; }
            set { Fields.HsnSacHsnsacNo[this] = value; }
        }

        [DisplayName("Hsn Sac Tax Rate"), Expression("jHsnSac.[TaxRate]")]
        public Double? HsnSacTaxRate
        {
            get { return Fields.HsnSacTaxRate[this]; }
            set { Fields.HsnSacTaxRate[this] = value; }
        }

        [DisplayName("Hsn Sac Is Active"), Expression("jHsnSac.[IsActive]")]
        public Boolean? HsnSacIsActive
        {
            get { return Fields.HsnSacIsActive[this]; }
            set { Fields.HsnSacIsActive[this] = value; }
        }



        [DisplayName("Product Type"), Expression("jProductType.[ProductType]")]
        public String ProductType
        {
            get { return Fields.ProductType[this]; }
            set { Fields.ProductType[this] = value; }
        }

        [DisplayName("Product Type Is Active"), Expression("jProductType.[IsActive]")]
        public Boolean? ProductTypeIsActive
        {
            get { return Fields.ProductTypeIsActive[this]; }
            set { Fields.ProductTypeIsActive[this] = value; }
        }



        IIdField IIdRow.IdField
        {
            get { return Fields.ProductId; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.ProductName; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public ProductRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {

            public Int32Field ProductId;

            public Int32Field HsnSacId;

            public StringField ProductName;

            public Int32Field ProductTypeId;

            public StringField Description;

            public StringField Ingredient;

            public DoubleField Igst;

            public DoubleField Cgst;

            public DoubleField Sgst;

            public StringField Comment;

            public BooleanField IsActive;



            public StringField HsnSacHsnsacNo;

            public DoubleField HsnSacTaxRate;

            public BooleanField HsnSacIsActive;



            public StringField ProductType;

            public BooleanField ProductTypeIsActive;

            public RowListField<Entities.ProductDetailsRow> ProductDetailsList;

            public RowListField<Entities.ProductLicenseDetailsRow> LicenseList;
        }
    }
}
