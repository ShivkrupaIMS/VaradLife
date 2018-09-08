namespace Serene.Masters {
    export interface ManufacturerForm {
        ManufacturerName: Serenity.StringEditor;
        ShortName: Serenity.StringEditor;
        Description: Serenity.StringEditor;
        IsActive: Serenity.BooleanEditor;
    }

    export class ManufacturerForm extends Serenity.PrefixedContext {
        static formKey = 'Masters.Manufacturer';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!ManufacturerForm.init)  {
                ManufacturerForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.BooleanEditor;

                Q.initFormType(ManufacturerForm, [
                    'ManufacturerName', w0,
                    'ShortName', w0,
                    'Description', w0,
                    'IsActive', w1
                ]);
            }
        }
    }
}
