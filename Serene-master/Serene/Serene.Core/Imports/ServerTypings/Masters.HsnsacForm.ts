namespace Serene.Masters {
    export interface HsnsacForm {
        HsnsacNo: Serenity.StringEditor;
        TaxRate: Serenity.DecimalEditor;
        IsActive: Serenity.BooleanEditor;
    }

    export class HsnsacForm extends Serenity.PrefixedContext {
        static formKey = 'Masters.Hsnsac';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!HsnsacForm.init)  {
                HsnsacForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.DecimalEditor;
                var w2 = s.BooleanEditor;

                Q.initFormType(HsnsacForm, [
                    'HsnsacNo', w0,
                    'TaxRate', w1,
                    'IsActive', w2
                ]);
            }
        }
    }
}
