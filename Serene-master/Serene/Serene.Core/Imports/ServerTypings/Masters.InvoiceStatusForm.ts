namespace Serene.Masters {
    export interface InvoiceStatusForm {
        InvoiceStatus: Serenity.StringEditor;
        IsActive: Serenity.BooleanEditor;
    }

    export class InvoiceStatusForm extends Serenity.PrefixedContext {
        static formKey = 'Masters.InvoiceStatus';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!InvoiceStatusForm.init)  {
                InvoiceStatusForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.BooleanEditor;

                Q.initFormType(InvoiceStatusForm, [
                    'InvoiceStatus', w0,
                    'IsActive', w1
                ]);
            }
        }
    }
}
