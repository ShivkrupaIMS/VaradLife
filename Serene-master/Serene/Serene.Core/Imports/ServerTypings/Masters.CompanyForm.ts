namespace Serene.Masters {
    export interface CompanyForm {
        CompanyName: Serenity.StringEditor;
        CompanyTypeId: Serenity.LookupEditor;
        GstNo: Serenity.StringEditor;
        GstRegistrationTypeId: Serenity.LookupEditor;
        Phone: Serenity.StringEditor;
        Fax: Serenity.StringEditor;
        Email: Serenity.StringEditor;
        Address: Serenity.StringEditor;
        CountryId: Serenity.LookupEditor;
        StateId: Serenity.LookupEditor;
        CityId: Serenity.LookupEditor;
        PinCode: Serenity.StringEditor;
        PanNo: Serenity.StringEditor;
        Website: Serenity.StringEditor;
        ContactPerson: Serenity.StringEditor;
        MobileNo: Serenity.StringEditor;
        CinNo: Serenity.StringEditor;
        FyStartDate: Serenity.DateEditor;
        BookStartDate: Serenity.DateEditor;
        Branch: Serenity.StringEditor;
        IsActive: Serenity.BooleanEditor;
        LicenseList: CompanyLicenseDetailsEditor;
    }

    export class CompanyForm extends Serenity.PrefixedContext {
        static formKey = 'Masters.Company';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!CompanyForm.init)  {
                CompanyForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.LookupEditor;
                var w2 = s.DateEditor;
                var w3 = s.BooleanEditor;
                var w4 = CompanyLicenseDetailsEditor;

                Q.initFormType(CompanyForm, [
                    'CompanyName', w0,
                    'CompanyTypeId', w1,
                    'GstNo', w0,
                    'GstRegistrationTypeId', w1,
                    'Phone', w0,
                    'Fax', w0,
                    'Email', w0,
                    'Address', w0,
                    'CountryId', w1,
                    'StateId', w1,
                    'CityId', w1,
                    'PinCode', w0,
                    'PanNo', w0,
                    'Website', w0,
                    'ContactPerson', w0,
                    'MobileNo', w0,
                    'CinNo', w0,
                    'FyStartDate', w2,
                    'BookStartDate', w2,
                    'Branch', w0,
                    'IsActive', w3,
                    'LicenseList', w4
                ]);
            }
        }
    }
}
