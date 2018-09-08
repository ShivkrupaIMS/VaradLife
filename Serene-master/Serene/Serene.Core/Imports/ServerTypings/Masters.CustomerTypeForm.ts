namespace Serene.Masters {
    export interface CustomerTypeForm {
        CustomerType: Serenity.StringEditor;
        IsActive: Serenity.BooleanEditor;
    }

    export class CustomerTypeForm extends Serenity.PrefixedContext {
        static formKey = 'Masters.CustomerType';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!CustomerTypeForm.init)  {
                CustomerTypeForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.BooleanEditor;

                Q.initFormType(CustomerTypeForm, [
                    'CustomerType', w0,
                    'IsActive', w1
                ]);
            }
        }
    }
}
