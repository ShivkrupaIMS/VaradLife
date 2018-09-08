namespace Serene.Masters {
    export interface PurchaseInvoiceForm {
        InvoiceStatusId: Serenity.LookupEditor;
        InvoiceTermId: Serenity.LookupEditor;
        SuppliersId: Serenity.LookupEditor;
        InvoiceDate: Serenity.DateEditor;
        PaymentDueDate: Serenity.DateEditor;
        PurchaseInvoiceNumber: Serenity.StringEditor;
        TotalTaxableAmount: Serenity.DecimalEditor;
        TotalTax: Serenity.DecimalEditor;
        TotalAmount: Serenity.DecimalEditor;
        IsReverseCharge: Serenity.BooleanEditor;
        IsActive: Serenity.BooleanEditor;
        PurchaseInvoiceDetailsList: PurchaseInvoiceDetailsEditor;
    }

    export class PurchaseInvoiceForm extends Serenity.PrefixedContext {
        static formKey = 'Masters.PurchaseInvoice';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!PurchaseInvoiceForm.init)  {
                PurchaseInvoiceForm.init = true;

                var s = Serenity;
                var w0 = s.LookupEditor;
                var w1 = s.DateEditor;
                var w2 = s.StringEditor;
                var w3 = s.DecimalEditor;
                var w4 = s.BooleanEditor;
                var w5 = PurchaseInvoiceDetailsEditor;

                Q.initFormType(PurchaseInvoiceForm, [
                    'InvoiceStatusId', w0,
                    'InvoiceTermId', w0,
                    'SuppliersId', w0,
                    'InvoiceDate', w1,
                    'PaymentDueDate', w1,
                    'PurchaseInvoiceNumber', w2,
                    'TotalTaxableAmount', w3,
                    'TotalTax', w3,
                    'TotalAmount', w3,
                    'IsReverseCharge', w4,
                    'IsActive', w4,
                    'PurchaseInvoiceDetailsList', w5
                ]);
            }
        }
    }
}
