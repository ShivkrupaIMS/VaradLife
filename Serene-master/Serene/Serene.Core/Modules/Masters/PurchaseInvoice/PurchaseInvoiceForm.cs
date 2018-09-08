
namespace Serene.Masters.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Masters.PurchaseInvoice")]
    [BasedOnRow(typeof(Entities.PurchaseInvoiceRow), CheckNames = true)]
    public class PurchaseInvoiceForm
    {
        public Int32 InvoiceStatusId { get; set; }
        public Int32 InvoiceTermId { get; set; }
        public Int32 SuppliersId { get; set; }
        public DateTime InvoiceDate { get; set; }
        public DateTime PaymentDueDate { get; set; }
        public String PurchaseInvoiceNumber { get; set; }
        public Double TotalTaxableAmount { get; set; }
        public Double TotalTax { get; set; }
        public Double TotalAmount { get; set; }
        public Boolean IsReverseCharge { get; set; }
        public Boolean IsActive { get; set; }

        [PurchaseInvoiceDetailsEditor]
        public List<Entities.PurchaseInvoiceDetailsRow> PurchaseInvoiceDetailsList { get; set; }

    }
}