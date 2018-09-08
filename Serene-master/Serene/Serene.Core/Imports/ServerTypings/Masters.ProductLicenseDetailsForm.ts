namespace Serene.Masters {
    export interface ProductLicenseDetailsForm {
        LicenseTypeId: Serenity.LookupEditor;
        IsActive: Serenity.BooleanEditor;
    }

    export class ProductLicenseDetailsForm extends Serenity.PrefixedContext {
        static formKey = 'Masters.ProductLicenseDetails';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!ProductLicenseDetailsForm.init)  {
                ProductLicenseDetailsForm.init = true;

                var s = Serenity;
                var w0 = s.LookupEditor;
                var w1 = s.BooleanEditor;

                Q.initFormType(ProductLicenseDetailsForm, [
                    'LicenseTypeId', w0,
                    'IsActive', w1
                ]);
            }
        }
    }
}
