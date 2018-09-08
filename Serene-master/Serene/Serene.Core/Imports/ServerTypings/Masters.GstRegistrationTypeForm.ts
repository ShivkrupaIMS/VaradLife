namespace Serene.Masters {
    export interface GstRegistrationTypeForm {
        GstRegistrationType: Serenity.StringEditor;
        IsActive: Serenity.BooleanEditor;
    }

    export class GstRegistrationTypeForm extends Serenity.PrefixedContext {
        static formKey = 'Masters.GstRegistrationType';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!GstRegistrationTypeForm.init)  {
                GstRegistrationTypeForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.BooleanEditor;

                Q.initFormType(GstRegistrationTypeForm, [
                    'GstRegistrationType', w0,
                    'IsActive', w1
                ]);
            }
        }
    }
}
