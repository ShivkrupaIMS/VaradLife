namespace Serene.Masters {
    export interface SuppliersForm {
        SuppliersName: Serenity.StringEditor;
        SupplierTypeId: Serenity.LookupEditor;
        GstNo: Serenity.StringEditor;
        GstRegistrationTypeId: Serenity.LookupEditor;
        Phone: Serenity.StringEditor;
        Fax: Serenity.StringEditor;
        Email: Serenity.StringEditor;
        Address: Serenity.StringEditor;
        CountryId: Serenity.LookupEditor;
        StateId: Serenity.LookupEditor;
        PinCode: Serenity.StringEditor;
        PanNo: Serenity.StringEditor;
        Website: Serenity.StringEditor;
        ContactPerson: Serenity.StringEditor;
        MobileNo: Serenity.StringEditor;
        CinNo: Serenity.StringEditor;
        IsActive: Serenity.BooleanEditor;
        OpeningBalance: Serenity.DecimalEditor;
        LicenseList: SuppliersLicenseDetailsEditor;
    }

    export class SuppliersForm extends Serenity.PrefixedContext {
        static formKey = 'Masters.Suppliers';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!SuppliersForm.init)  {
                SuppliersForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.LookupEditor;
                var w2 = s.BooleanEditor;
                var w3 = s.DecimalEditor;
                var w4 = SuppliersLicenseDetailsEditor;

                Q.initFormType(SuppliersForm, [
                    'SuppliersName', w0,
                    'SupplierTypeId', w1,
                    'GstNo', w0,
                    'GstRegistrationTypeId', w1,
                    'Phone', w0,
                    'Fax', w0,
                    'Email', w0,
                    'Address', w0,
                    'CountryId', w1,
                    'StateId', w1,
                    'PinCode', w0,
                    'PanNo', w0,
                    'Website', w0,
                    'ContactPerson', w0,
                    'MobileNo', w0,
                    'CinNo', w0,
                    'IsActive', w2,
                    'OpeningBalance', w3,
                    'LicenseList', w4
                ]);
            }
        }
    }
}
