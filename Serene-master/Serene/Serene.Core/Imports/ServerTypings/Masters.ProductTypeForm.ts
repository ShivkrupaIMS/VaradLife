namespace Serene.Masters {
    export interface ProductTypeForm {
        ProductType: Serenity.StringEditor;
        IsActive: Serenity.BooleanEditor;
    }

    export class ProductTypeForm extends Serenity.PrefixedContext {
        static formKey = 'Masters.ProductType';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!ProductTypeForm.init)  {
                ProductTypeForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.BooleanEditor;

                Q.initFormType(ProductTypeForm, [
                    'ProductType', w0,
                    'IsActive', w1
                ]);
            }
        }
    }
}
