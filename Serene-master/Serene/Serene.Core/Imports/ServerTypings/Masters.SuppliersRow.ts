namespace Serene.Masters {
    export interface SuppliersRow {
        SuppliersId?: number;
        SuppliersName?: string;
        SupplierTypeId?: number;
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
        IsActive?: boolean;
        OpeningBalance?: number;
        SupplierType?: string;
        SupplierTypeIsActive?: boolean;
        GstRegistrationType?: string;
        GstRegistrationTypeIsActive?: boolean;
        CountryCountryCode?: string;
        CountryCountryName?: string;
        CountryIsActive?: boolean;
        StateStateCode?: string;
        StateStateName?: string;
        StateCountryId?: number;
        StateIsActive?: boolean;
        LicenseList?: SuppliersLicenseDetailsRow[];
    }

    export namespace SuppliersRow {
        export const idProperty = 'SuppliersId';
        export const nameProperty = 'SuppliersName';
        export const localTextPrefix = 'Masters.Suppliers';
        export const lookupKey = 'Masters.Suppliers';

        export function getLookup(): Q.Lookup<SuppliersRow> {
            return Q.getLookup<SuppliersRow>('Masters.Suppliers');
        }

        export declare const enum Fields {
            SuppliersId = "SuppliersId",
            SuppliersName = "SuppliersName",
            SupplierTypeId = "SupplierTypeId",
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
            IsActive = "IsActive",
            OpeningBalance = "OpeningBalance",
            SupplierType = "SupplierType",
            SupplierTypeIsActive = "SupplierTypeIsActive",
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
