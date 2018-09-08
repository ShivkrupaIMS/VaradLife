namespace Serene.Masters {
    export interface CustomersRow {
        CustomersId?: number;
        CustomersName?: string;
        CustomerTypeId?: number;
        GstNo?: string;
        GstRegistrationTypeId?: number;
        Phone?: string;
        Fax?: string;
        Email?: string;
        Address?: string;
        CountryId?: number;
        StateId?: number;
        PinCode?: string;
        PanNo?: string;
        Website?: string;
        ContactPerson?: string;
        MobileNo?: string;
        CinNo?: string;
        Branch?: string;
        IsActive?: boolean;
        OpeningBalance?: number;
        CustomerType?: string;
        CustomerTypeIsActive?: boolean;
        GstRegistrationType?: string;
        GstRegistrationTypeIsActive?: boolean;
        CountryCountryCode?: string;
        CountryCountryName?: string;
        CountryIsActive?: boolean;
        StateStateCode?: string;
        StateStateName?: string;
        StateCountryId?: number;
        StateIsActive?: boolean;
        LicenseList?: CustomersLicenseDetailsRow[];
    }

    export namespace CustomersRow {
        export const idProperty = 'CustomersId';
        export const nameProperty = 'CustomersName';
        export const localTextPrefix = 'Masters.Customers';

        export declare const enum Fields {
            CustomersId = "CustomersId",
            CustomersName = "CustomersName",
            CustomerTypeId = "CustomerTypeId",
            GstNo = "GstNo",
            GstRegistrationTypeId = "GstRegistrationTypeId",
            Phone = "Phone",
            Fax = "Fax",
            Email = "Email",
            Address = "Address",
            CountryId = "CountryId",
            StateId = "StateId",
            PinCode = "PinCode",
            PanNo = "PanNo",
            Website = "Website",
            ContactPerson = "ContactPerson",
            MobileNo = "MobileNo",
            CinNo = "CinNo",
            Branch = "Branch",
            IsActive = "IsActive",
            OpeningBalance = "OpeningBalance",
            CustomerType = "CustomerType",
            CustomerTypeIsActive = "CustomerTypeIsActive",
            GstRegistrationType = "GstRegistrationType",
            GstRegistrationTypeIsActive = "GstRegistrationTypeIsActive",
            CountryCountryCode = "CountryCountryCode",
            CountryCountryName = "CountryCountryName",
            CountryIsActive = "CountryIsActive",
            StateStateCode = "StateStateCode",
            StateStateName = "StateStateName",
            StateCountryId = "StateCountryId",
            StateIsActive = "StateIsActive",
            LicenseList = "LicenseList"
        }
    }
}
