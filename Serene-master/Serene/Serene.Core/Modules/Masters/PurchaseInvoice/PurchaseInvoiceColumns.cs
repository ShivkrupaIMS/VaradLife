
namespace Serene.Masters.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("Masters.PurchaseInvoice")]
    [BasedOnRow(typeof(Entities.PurchaseInvoiceRow), CheckNames = true)]
    public class PurchaseInvoiceColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 PurchaseInvoiceId { get; set; }
        public String InvoiceStatus { get; set; }
        public String InvoiceTerm { get; set; }
        public String SuppliersSuppliersName { get; set; }
        public DateTime InvoiceDate { get; set; }
        public DateTime PaymentDueDate { get; set; }
        [EditLink]
        public String PurchaseInvoiceNumber { get; set; }
        public Double TotalTaxableAmount { get; set; }
        public Double TotalTax { get; set; }
        public Double TotalAmount { get; set; }
        public Boolean IsReverseCharge { get; set; }
        public Boolean IsActive { get; set; }
    }
}