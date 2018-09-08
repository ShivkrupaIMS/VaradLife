namespace Serene.Masters {
    export interface ProductForm {
        HsnSacId: Serenity.LookupEditor;
        ProductName: Serenity.StringEditor;
        ProductTypeId: Serenity.LookupEditor;
        Description: Serenity.StringEditor;
        Ingredient: Serenity.StringEditor;
        Igst: Serenity.DecimalEditor;
        Cgst: Serenity.DecimalEditor;
        Sgst: Serenity.DecimalEditor;
        Comment: Serenity.StringEditor;
        IsActive: Serenity.BooleanEditor;
        ProductDetailsList: ProductDetailsEditor;
        LicenseList: ProductLicenseDetailsEditor;
    }

    export class ProductForm extends Serenity.PrefixedContext {
        static formKey = 'Masters.Product';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!ProductForm.init)  {
                ProductForm.init = true;

                var s = Serenity;
                var w0 = s.LookupEditor;
                var w1 = s.StringEditor;
                var w2 = s.DecimalEditor;
                var w3 = s.BooleanEditor;
                var w4 = ProductDetailsEditor;
                var w5 = ProductLicenseDetailsEditor;

                Q.initFormType(ProductForm, [
                    'HsnSacId', w0,
                    'ProductName', w1,
                    'ProductTypeId', w0,
                    'Description', w1,
                    'Ingredient', w1,
                    'Igst', w2,
                    'Cgst', w2,
                    'Sgst', w2,
                    'Comment', w1,
                    'IsActive', w3,
                    'ProductDetailsList', w4,
                    'LicenseList', w5
                ]);
            }
        }
    }
}
