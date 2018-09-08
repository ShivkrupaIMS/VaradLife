namespace Serene.Masters {
    export interface SupplierTypeForm {
        SupplierType: Serenity.StringEditor;
        IsActive: Serenity.BooleanEditor;
    }

    export class SupplierTypeForm extends Serenity.PrefixedContext {
        static formKey = 'Masters.SupplierType';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!SupplierTypeForm.init)  {
                SupplierTypeForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.BooleanEditor;

                Q.initFormType(SupplierTypeForm, [
                    'SupplierType', w0,
                    'IsActive', w1
                ]);
            }
        }
    }
}
