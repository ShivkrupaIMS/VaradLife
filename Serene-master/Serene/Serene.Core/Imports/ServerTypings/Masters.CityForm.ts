namespace Serene.Masters {
    export interface CityForm {
        CityCode: Serenity.StringEditor;
        CityName: Serenity.StringEditor;
        IsActive: Serenity.BooleanEditor;
        StateId: Serenity.LookupEditor;
    }

    export class CityForm extends Serenity.PrefixedContext {
        static formKey = 'Masters.City';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!CityForm.init)  {
                CityForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.BooleanEditor;
                var w2 = s.LookupEditor;

                Q.initFormType(CityForm, [
                    'CityCode', w0,
                    'CityName', w0,
                    'IsActive', w1,
                    'StateId', w2
                ]);
            }
        }
    }
}
