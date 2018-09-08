namespace Serene.Masters {
    export interface StateForm {
        StateCode: Serenity.StringEditor;
        StateName: Serenity.StringEditor;
        CountryId: Serenity.LookupEditor;
        IsActive: Serenity.BooleanEditor;
    }

    export class StateForm extends Serenity.PrefixedContext {
        static formKey = 'Masters.State';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!StateForm.init)  {
                StateForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.LookupEditor;
                var w2 = s.BooleanEditor;

                Q.initFormType(StateForm, [
                    'StateCode', w0,
                    'StateName', w0,
                    'CountryId', w1,
                    'IsActive', w2
                ]);
            }
        }
    }
}
