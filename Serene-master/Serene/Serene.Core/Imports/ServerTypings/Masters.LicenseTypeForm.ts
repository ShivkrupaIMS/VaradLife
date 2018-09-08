namespace Serene.Masters {
    export interface LicenseTypeForm {
        LicenseType: Serenity.StringEditor;
        ShortName: Serenity.StringEditor;
        Description: Serenity.StringEditor;
        IsActive: Serenity.BooleanEditor;
    }

    export class LicenseTypeForm extends Serenity.PrefixedContext {
        static formKey = 'Masters.LicenseType';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!LicenseTypeForm.init)  {
                LicenseTypeForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.BooleanEditor;

                Q.initFormType(LicenseTypeForm, [
                    'LicenseType', w0,
                    'ShortName', w0,
                    'Description', w0,
                    'IsActive', w1
                ]);
            }
        }
    }
}
