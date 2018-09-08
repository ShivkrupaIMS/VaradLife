namespace Serene.Masters {
    export interface CompanyTypeForm {
        CompanyType: Serenity.StringEditor;
        IsActive: Serenity.BooleanEditor;
    }

    export class CompanyTypeForm extends Serenity.PrefixedContext {
        static formKey = 'Masters.CompanyType';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!CompanyTypeForm.init)  {
                CompanyTypeForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.BooleanEditor;

                Q.initFormType(CompanyTypeForm, [
                    'CompanyType', w0,
                    'IsActive', w1
                ]);
            }
        }
    }
}
