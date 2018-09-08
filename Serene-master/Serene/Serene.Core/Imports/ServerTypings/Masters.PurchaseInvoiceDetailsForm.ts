namespace Serene.Masters {
    export interface PurchaseInvoiceDetailsForm {
        ProductId: Serenity.LookupEditor;
        ProductDetailsId: Serenity.LookupEditor;
        PackageSize: Serenity.StringEditor;
        BatchNumber: Serenity.StringEditor;
        ExpiryDate: Serenity.DateEditor;
        Quantity: Serenity.IntegerEditor;
        DiscountPercent: Serenity.DecimalEditor;
        ProductValue: Serenity.DecimalEditor;
        DiscountValue: Serenity.DecimalEditor;
        TaxableValue: Serenity.DecimalEditor;
        IgstRate: Serenity.DecimalEditor;
        IgstAmount: Serenity.DecimalEditor;
        CgstRate: Serenity.DecimalEditor;
        CgstAmount: Serenity.DecimalEditor;
        SgstRate: Serenity.DecimalEditor;
        SgstAmount: Serenity.DecimalEditor;
        CessRate: Serenity.DecimalEditor;
        CessAmount: Serenity.DecimalEditor;
        TotalTaxPlusCess: Serenity.DecimalEditor;
        TotalTransactionAmount: Serenity.DecimalEditor;
        IsActive: Serenity.BooleanEditor;
    }

    export class PurchaseInvoiceDetailsForm extends Serenity.PrefixedContext {
        static formKey = 'Masters.PurchaseInvoiceDetails';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!PurchaseInvoiceDetailsForm.init)  {
                PurchaseInvoiceDetailsForm.init = true;

                var s = Serenity;
                var w0 = s.LookupEditor;
                var w1 = s.StringEditor;
                var w2 = s.DateEditor;
                var w3 = s.IntegerEditor;
                var w4 = s.DecimalEditor;
                var w5 = s.BooleanEditor;

                Q.initFormType(PurchaseInvoiceDetailsForm, [
                    'ProductId', w0,
                    'ProductDetailsId', w0,
                    'PackageSize', w1,
                    'BatchNumber', w1,
                    'ExpiryDate', w2,
                    'Quantity', w3,
                    'DiscountPercent', w4,
                    'ProductValue', w4,
                    'DiscountValue', w4,
                    'TaxableValue', w4,
                    'IgstRate', w4,
                    'IgstAmount', w4,
                    'CgstRate', w4,
                    'CgstAmount', w4,
                    'SgstRate', w4,
                    'SgstAmount', w4,
                    'CessRate', w4,
                    'CessAmount', w4,
                    'TotalTaxPlusCess', w4,
                    'TotalTransactionAmount', w4,
                    'IsActive', w5
                ]);
            }
        }
    }
}
