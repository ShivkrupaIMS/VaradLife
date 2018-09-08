namespace Serene.Masters {
    export interface ProductDetailsForm {
        Sku: Serenity.StringEditor;
        ProductUnitId: Serenity.LookupEditor;
        PackageSize: Serenity.IntegerEditor;
        PurchasePrice: Serenity.DecimalEditor;
        SalePrice: Serenity.DecimalEditor;
        Mrp: Serenity.DecimalEditor;
        PackageWeight: Serenity.StringEditor;
        ManufacturerId: Serenity.LookupEditor;
        MinQuantity: Serenity.IntegerEditor;
        Discount: Serenity.DecimalEditor;
        Description: Serenity.StringEditor;
        IsActive: Serenity.BooleanEditor;
    }

    export class ProductDetailsForm extends Serenity.PrefixedContext {
        static formKey = 'Masters.ProductDetails';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!ProductDetailsForm.init)  {
                ProductDetailsForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.LookupEditor;
                var w2 = s.IntegerEditor;
                var w3 = s.DecimalEditor;
                var w4 = s.BooleanEditor;

                Q.initFormType(ProductDetailsForm, [
                    'Sku', w0,
                    'ProductUnitId', w1,
                    'PackageSize', w2,
                    'PurchasePrice', w3,
                    'SalePrice', w3,
                    'Mrp', w3,
                    'PackageWeight', w0,
                    'ManufacturerId', w1,
                    'MinQuantity', w2,
                    'Discount', w3,
                    'Description', w0,
                    'IsActive', w4
                ]);
            }
        }
    }
}
