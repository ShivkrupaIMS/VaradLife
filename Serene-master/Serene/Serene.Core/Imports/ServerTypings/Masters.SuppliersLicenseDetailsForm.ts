namespace Serene.Masters {
    export interface SuppliersLicenseDetailsForm {
        LicenseTypeId: Serenity.LookupEditor;
        LicenseNo: Serenity.StringEditor;
        ValidFrom: Serenity.DateEditor;
        ValidTo: Serenity.DateEditor;
        IsActive: Serenity.BooleanEditor;
    }

    export class SuppliersLicenseDetailsForm extends Serenity.PrefixedContext {
        static formKey = 'Masters.SuppliersLicenseDetails';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!SuppliersLicenseDetailsForm.init)  {
                SuppliersLicenseDetailsForm.init = true;

                var s = Serenity;
                var w0 = s.LookupEditor;
                var w1 = s.StringEditor;
                var w2 = s.DateEditor;
                var w3 = s.BooleanEditor;

                Q.initFormType(SuppliersLicenseDetailsForm, [
                    'LicenseTypeId', w0,
                    'LicenseNo', w1,
                    'ValidFrom', w2,
                    'ValidTo', w2,
                    'IsActive', w3
                ]);
            }
        }
    }
}
