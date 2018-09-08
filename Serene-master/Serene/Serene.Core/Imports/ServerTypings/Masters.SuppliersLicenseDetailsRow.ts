namespace Serene.Masters {
    export interface SuppliersLicenseDetailsRow {
        SuppliersLicenseDetailsId?: number;
        LicenseTypeId?: number;
        SuppliersId?: number;
        LicenseNo?: string;
        ValidFrom?: string;
        ValidTo?: string;
        IsActive?: boolean;
        LicenseType?: string;
        LicenseTypeShortName?: string;
        LicenseTypeDescription?: string;
        LicenseTypeIsActive?: boolean;
        SuppliersSuppliersName?: string;
        SuppliersSupplierTypeId?: number;
        SuppliersGstNo?: string;
        SuppliersGstRegistrationTypeId?: number;
        SuppliersPhone?: string;
        SuppliersFax?: string;
        SuppliersEmail?: string;
        SuppliersAddress?: string;
        SuppliersCountryId?: number;
        SuppliersStateId?: number;
        SuppliersPinCode?: string;
        SuppliersPanNo?: string;
        SuppliersWebsite?: string;
        SuppliersContactPerson?: string;
        SuppliersMobileNo?: string;
        SuppliersCinNo?: string;
        SuppliersIsActive?: boolean;
        SuppliersOpeningBalance?: number;
    }

    export namespace SuppliersLicenseDetailsRow {
        export const idProperty = 'SuppliersLicenseDetailsId';
        export const nameProperty = 'LicenseNo';
        export const localTextPrefix = 'Masters.SuppliersLicenseDetails';

        export declare const enum Fields {
            SuppliersLicenseDetailsId = "SuppliersLicenseDetailsId",
            LicenseTypeId = "LicenseTypeId",
            SuppliersId = "SuppliersId",
            LicenseNo = "LicenseNo",
            ValidFrom = "ValidFrom",
            ValidTo = "ValidTo",
            IsActive = "IsActive",
            LicenseType = "LicenseType",
            LicenseTypeShortName = "LicenseTypeShortName",
            LicenseTypeDescription = "LicenseTypeDescription",
            LicenseTypeIsActive = "LicenseTypeIsActive",
            SuppliersSuppliersName = "SuppliersSuppliersName",
            SuppliersSupplierTypeId = "SuppliersSupplierTypeId",
            SuppliersGstNo = "SuppliersGstNo",
            SuppliersGstRegistrationTypeId = "SuppliersGstRegistrationTypeId",
            SuppliersPhone = "SuppliersPhone",
            SuppliersFax = "SuppliersFax",
            SuppliersEmail = "SuppliersEmail",
            SuppliersAddress = "SuppliersAddress",
            SuppliersCountryId = "SuppliersCountryId",
            SuppliersStateId = "SuppliersStateId",
            SuppliersPinCode = "SuppliersPinCode",
            SuppliersPanNo = "SuppliersPanNo",
            SuppliersWebsite = "SuppliersWebsite",
            SuppliersContactPerson = "SuppliersContactPerson",
            SuppliersMobileNo = "SuppliersMobileNo",
            SuppliersCinNo = "SuppliersCinNo",
            SuppliersIsActive = "SuppliersIsActive",
            SuppliersOpeningBalance = "SuppliersOpeningBalance"
        }
    }
}
