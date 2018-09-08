namespace Serene.Masters {
    export interface CompanyLicenseDetailsForm {
        LicenseTypeId: Serenity.LookupEditor;
        LicenseNo: Serenity.StringEditor;
        ValidFrom: Serenity.DateEditor;
        ValidTo: Serenity.DateEditor;
        IsActive: Serenity.BooleanEditor;
    }

    export class CompanyLicenseDetailsForm extends Serenity.PrefixedContext {
        static formKey = 'Masters.CompanyLicenseDetails';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!CompanyLicenseDetailsForm.init)  {
                CompanyLicenseDetailsForm.init = true;

                var s = Serenity;
                var w0 = s.LookupEditor;
                var w1 = s.StringEditor;
                var w2 = s.DateEditor;
                var w3 = s.BooleanEditor;

                Q.initFormType(CompanyLicenseDetailsForm, [
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
