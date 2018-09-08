namespace Serene.Masters {
    export interface CompanyRow {
        CompanyId?: number;
        CompanyName?: string;
        CompanyTypeId?: number;
        GstNo?: string;
        GstRegistrationTypeId?: number;
        Phone?: string;
        Fax?: string;
        Email?: string;
        Address?: string;
        CountryId?: number;
        StateId?: number;
        CityId?: number;
        PinCode?: string;
        PanNo?: string;
        Website?: string;
        ContactPerson?: string;
        MobileNo?: string;
        CinNo?: string;
        FyStartDate?: string;
        BookStartDate?: string;
        Branch?: string;
        IsActive?: boolean;
        CompanyType?: string;
        CompanyTypeIsActive?: boolean;
        GstRegistrationType?: string;
        GstRegistrationTypeIsActive?: boolean;
        CountryCountryCode?: string;
        CountryCountryName?: string;
        CountryIsActive?: boolean;
        StateStateCode?: string;
        StateStateName?: string;
        StateCountryId?: number;
        StateIsActive?: boolean;
        CityCityCode?: string;
        CityCityName?: string;
        CityIsActive?: boolean;
        CityStateId?: number;
        LicenseList?: CompanyLicenseDetailsRow[];
    }

    export namespace CompanyRow {
        export const idProperty = 'CompanyId';
        export const nameProperty = 'CompanyName';
        export const localTextPrefix = 'Masters.Company';

        export declare const enum Fields {
            CompanyId = "CompanyId",
            CompanyName = "CompanyName",
            CompanyTypeId = "CompanyTypeId",
            GstNo = "GstNo",
            GstRegistrationTypeId = "GstRegistrationTypeId",
            Phone = "Phone",
            Fax = "Fax",
            Email = "Email",
            Address = "Address",
            CountryId = "CountryId",
            StateId = "StateId",
            CityId = "CityId",
            PinCode = "PinCode",
            PanNo = "PanNo",
            Website = "Website",
            ContactPerson = "ContactPerson",
            MobileNo = "MobileNo",
            CinNo = "CinNo",
            FyStartDate = "FyStartDate",
            BookStartDate = "BookStartDate",
            Branch = "Branch",
            IsActive = "IsActive",
            CompanyType = "CompanyType",
            CompanyTypeIsActive = "CompanyTypeIsActive",
            GstRegistrationType = "GstRegistrationType",
            GstRegistrationTypeIsActive = "GstRegistrationTypeIsActive",
            CountryCountryCode = "CountryCountryCode",
            CountryCountryName = "CountryCountryName",
            CountryIsActive = "CountryIsActive",
            StateStateCode = "StateStateCode",
            StateStateName = "StateStateName",
            StateCountryId = "StateCountryId",
            StateIsActive = "StateIsActive",
            CityCityCode = "CityCityCode",
            CityCityName = "CityCityName",
            CityIsActive = "CityIsActive",
            CityStateId = "CityStateId",
            LicenseList = "LicenseList"
        }
    }
}
