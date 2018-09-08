namespace Serene.Masters {
    export interface InvoiceTermForm {
        InvoiceTerm: Serenity.StringEditor;
        IsActive: Serenity.BooleanEditor;
    }

    export class InvoiceTermForm extends Serenity.PrefixedContext {
        static formKey = 'Masters.InvoiceTerm';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!InvoiceTermForm.init)  {
                InvoiceTermForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.BooleanEditor;

                Q.initFormType(InvoiceTermForm, [
                    'InvoiceTerm', w0,
                    'IsActive', w1
                ]);
            }
        }
    }
}
