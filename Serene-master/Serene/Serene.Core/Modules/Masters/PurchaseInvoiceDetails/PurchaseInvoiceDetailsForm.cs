
namespace Serene.Masters.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Masters.PurchaseInvoiceDetails")]
    [BasedOnRow(typeof(Entities.PurchaseInvoiceDetailsRow), CheckNames = true)]
    public class PurchaseInvoiceDetailsForm
    {
        public Int32 ProductId { get; set; }
        public Int32 ProductDetailsId { get; set; }
        public String PackageSize { get; set; }
        public String BatchNumber { get; set; }
        public DateTime ExpiryDate { get; set; }
        public Int32 Quantity { get; set; }
        public Double DiscountPercent { get; set; }
        public Double ProductValue { get; set; }
        public Double DiscountValue { get; set; }
        public Double TaxableValue { get; set; }
        public Double IgstRate { get; set; }
        public Double IgstAmount { get; set; }
        public Double CgstRate { get; set; }
        public Double CgstAmount { get; set; }
        public Double SgstRate { get; set; }
        public Double SgstAmount { get; set; }
        public Double CessRate { get; set; }
        public Double CessAmount { get; set; }
        public Double TotalTaxPlusCess { get; set; }
        public Double TotalTransactionAmount { get; set; }
        public Boolean IsActive { get; set; }
    }
}