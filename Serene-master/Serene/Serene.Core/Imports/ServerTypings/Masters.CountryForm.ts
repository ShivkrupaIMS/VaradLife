namespace Serene.Masters {
    export interface CountryForm {
        CountryCode: Serenity.StringEditor;
        CountryName: Serenity.StringEditor;
        IsActive: Serenity.BooleanEditor;
    }

    export class CountryForm extends Serenity.PrefixedContext {
        static formKey = 'Masters.Country';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!CountryForm.init)  {
                CountryForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.BooleanEditor;

                Q.initFormType(CountryForm, [
                    'CountryCode', w0,
                    'CountryName', w0,
                    'IsActive', w1
                ]);
            }
        }
    }
}
