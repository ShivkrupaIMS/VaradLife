namespace Serene.Masters {
    export interface ProductUnitForm {
        ProductUnit: Serenity.StringEditor;
        IsActive: Serenity.BooleanEditor;
    }

    export class ProductUnitForm extends Serenity.PrefixedContext {
        static formKey = 'Masters.ProductUnit';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!ProductUnitForm.init)  {
                ProductUnitForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.BooleanEditor;

                Q.initFormType(ProductUnitForm, [
                    'ProductUnit', w0,
                    'IsActive', w1
                ]);
            }
        }
    }
}
