namespace Serene.Masters {
    export interface CompanyLicenseDetailsRow {
        CompanyLicenseDetailsId?: number;
        LicenseTypeId?: number;
        CompanyId?: number;
        LicenseNo?: string;
        ValidFrom?: string;
        ValidTo?: string;
        IsActive?: boolean;
        LicenseType?: string;
        LicenseTypeShortName?: string;
        LicenseTypeDescription?: string;
        LicenseTypeIsActive?: boolean;
        CompanyCompanyName?: string;
        CompanyCompanyTypeId?: number;
        CompanyGstNo?: string;
        CompanyGstRegistrationTypeId?: number;
        CompanyPhone?: string;
        CompanyFax?: string;
        CompanyEmail?: string;
        CompanyAddress?: string;
        CompanyCountryId?: number;
        CompanyStateId?: number;
        CompanyCityId?: number;
        CompanyPinCode?: string;
        CompanyPanNo?: string;
        CompanyWebsite?: string;
        CompanyContactPerson?: string;
        CompanyMobileNo?: string;
        CompanyCinNo?: string;
        CompanyFyStartDate?: string;
        CompanyBookStartDate?: string;
        CompanyBranch?: string;
        CompanyIsActive?: boolean;
    }

    export namespace CompanyLicenseDetailsRow {
        export const idProperty = 'CompanyLicenseDetailsId';
        export const nameProperty = 'LicenseNo';
        export const localTextPrefix = 'Masters.CompanyLicenseDetails';

        export declare const enum Fields {
            CompanyLicenseDetailsId = "CompanyLicenseDetailsId",
            LicenseTypeId = "LicenseTypeId",
            CompanyId = "CompanyId",
            LicenseNo = "LicenseNo",
            ValidFrom = "ValidFrom",
            ValidTo = "ValidTo",
            IsActive = "IsActive",
            LicenseType = "LicenseType",
            LicenseTypeShortName = "LicenseTypeShortName",
            LicenseTypeDescription = "LicenseTypeDescription",
            LicenseTypeIsActive = "LicenseTypeIsActive",
            CompanyCompanyName = "CompanyCompanyName",
            CompanyCompanyTypeId = "CompanyCompanyTypeId",
            CompanyGstNo = "CompanyGstNo",
            CompanyGstRegistrationTypeId = "CompanyGstRegistrationTypeId",
            CompanyPhone = "CompanyPhone",
            CompanyFax = "CompanyFax",
            CompanyEmail = "CompanyEmail",
            CompanyAddress = "CompanyAddress",
            CompanyCountryId = "CompanyCountryId",
            CompanyStateId = "CompanyStateId",
            CompanyCityId = "CompanyCityId",
            CompanyPinCode = "CompanyPinCode",
            CompanyPanNo = "CompanyPanNo",
            CompanyWebsite = "CompanyWebsite",
            CompanyContactPerson = "CompanyContactPerson",
            CompanyMobileNo = "CompanyMobileNo",
            CompanyCinNo = "CompanyCinNo",
            CompanyFyStartDate = "CompanyFyStartDate",
            CompanyBookStartDate = "CompanyBookStartDate",
            CompanyBranch = "CompanyBranch",
            CompanyIsActive = "CompanyIsActive"
        }
    }
}
