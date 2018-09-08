namespace Serene.Masters {
    export interface CustomersLicenseDetailsRow {
        CustomersLicenseDetailsId?: number;
        LicenseTypeId?: number;
        CustomersId?: number;
        LicenseNo?: string;
        ValidFrom?: string;
        ValidTo?: string;
        IsActive?: boolean;
        LicenseType?: string;
        LicenseTypeShortName?: string;
        LicenseTypeDescription?: string;
        LicenseTypeIsActive?: boolean;
        CustomersCustomersName?: string;
        CustomersCustomerTypeId?: number;
        CustomersGstNo?: string;
        CustomersGstRegistrationTypeId?: number;
        CustomersPhone?: string;
        CustomersFax?: string;
        CustomersEmail?: string;
        CustomersAddress?: string;
        CustomersCountryId?: number;
        CustomersStateId?: number;
        CustomersPinCode?: string;
        CustomersPanNo?: string;
        CustomersWebsite?: string;
        CustomersContactPerson?: string;
        CustomersMobileNo?: string;
        CustomersCinNo?: string;
        CustomersBranch?: string;
        CustomersIsActive?: boolean;
        CustomersOpeningBalance?: number;
    }

    export namespace CustomersLicenseDetailsRow {
        export const idProperty = 'CustomersLicenseDetailsId';
        export const nameProperty = 'LicenseNo';
        export const localTextPrefix = 'Masters.CustomersLicenseDetails';

        export declare const enum Fields {
            CustomersLicenseDetailsId = "CustomersLicenseDetailsId",
            LicenseTypeId = "LicenseTypeId",
            CustomersId = "CustomersId",
            LicenseNo = "LicenseNo",
            ValidFrom = "ValidFrom",
            ValidTo = "ValidTo",
            IsActive = "IsActive",
            LicenseType = "LicenseType",
            LicenseTypeShortName = "LicenseTypeShortName",
            LicenseTypeDescription = "LicenseTypeDescription",
            LicenseTypeIsActive = "LicenseTypeIsActive",
            CustomersCustomersName = "CustomersCustomersName",
            CustomersCustomerTypeId = "CustomersCustomerTypeId",
            CustomersGstNo = "CustomersGstNo",
            CustomersGstRegistrationTypeId = "CustomersGstRegistrationTypeId",
            CustomersPhone = "CustomersPhone",
            CustomersFax = "CustomersFax",
            CustomersEmail = "CustomersEmail",
            CustomersAddress = "CustomersAddress",
            CustomersCountryId = "CustomersCountryId",
            CustomersStateId = "CustomersStateId",
            CustomersPinCode = "CustomersPinCode",
            CustomersPanNo = "CustomersPanNo",
            CustomersWebsite = "CustomersWebsite",
            CustomersContactPerson = "CustomersContactPerson",
            CustomersMobileNo = "CustomersMobileNo",
            CustomersCinNo = "CustomersCinNo",
            CustomersBranch = "CustomersBranch",
            CustomersIsActive = "CustomersIsActive",
            CustomersOpeningBalance = "CustomersOpeningBalance"
        }
    }
}
