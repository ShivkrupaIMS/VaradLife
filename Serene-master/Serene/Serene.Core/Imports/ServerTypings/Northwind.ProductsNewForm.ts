namespace Serene.Northwind {
    export interface ProductsNewForm {
        ProductName: Serenity.StringEditor;
        SupplierId: Serenity.IntegerEditor;
        CategoryId: Serenity.IntegerEditor;
        QuantityPerUnit: Serenity.StringEditor;
        UnitPrice: Serenity.DecimalEditor;
        UnitsInStock: Serenity.IntegerEditor;
        UnitsOnOrder: Serenity.IntegerEditor;
        ReorderLevel: Serenity.IntegerEditor;
        Discontinued: Serenity.BooleanEditor;
        ProductImage: Serenity.StringEditor;
        Igst: Serenity.IntegerEditor;
        Cgst: Serenity.IntegerEditor;
        Sgst: Serenity.IntegerEditor;
    }

    export class ProductsNewForm extends Serenity.PrefixedContext {
        static formKey = 'Northwind.ProductsNew';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!ProductsNewForm.init)  {
                ProductsNewForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.IntegerEditor;
                var w2 = s.DecimalEditor;
                var w3 = s.BooleanEditor;

                Q.initFormType(ProductsNewForm, [
                    'ProductName', w0,
                    'SupplierId', w1,
                    'CategoryId', w1,
                    'QuantityPerUnit', w0,
                    'UnitPrice', w2,
                    'UnitsInStock', w1,
                    'UnitsOnOrder', w1,
                    'ReorderLevel', w1,
                    'Discontinued', w3,
                    'ProductImage', w0,
                    'Igst', w1,
                    'Cgst', w1,
                    'Sgst', w1
                ]);
            }
        }
    }
}
