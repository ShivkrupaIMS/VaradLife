
namespace Serene.Masters.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Masters"), Module("Masters"), TableName("[dbo].[HSNSAC]")]
    [DisplayName("Hsnsac"), InstanceName("Hsnsac")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    [LookupScript]
    public sealed class HsnsacRow : Row, IIdRow, INameRow
    {

        [DisplayName("Hsnsac Id"), Column("HSNSACId"), Identity]
        public Int32? HsnsacId
        {
            get { return Fields.HsnsacId[this]; }
            set { Fields.HsnsacId[this] = value; }
        }

        [DisplayName("Hsnsac No"), Column("HSNSACNo"), Size(255), NotNull, QuickSearch]
        public String HsnsacNo
        {
            get { return Fields.HsnsacNo[this]; }
            set { Fields.HsnsacNo[this] = value; }
        }

        [DisplayName("Tax Rate")]
        public Double? TaxRate
        {
            get { return Fields.TaxRate[this]; }
            set { Fields.TaxRate[this] = value; }
        }

        [DisplayName("Is Active"), NotNull]
        public Boolean? IsActive
        {
            get { return Fields.IsActive[this]; }
            set { Fields.IsActive[this] = value; }
        }



        IIdField IIdRow.IdField
        {
            get { return Fields.HsnsacId; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.HsnsacNo; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public HsnsacRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {

            public Int32Field HsnsacId;

            public StringField HsnsacNo;

            public DoubleField TaxRate;

            public BooleanField IsActive;


		}
    }
}
