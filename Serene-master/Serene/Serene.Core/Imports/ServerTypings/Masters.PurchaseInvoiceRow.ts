namespace Serene.Masters {
    export interface PurchaseInvoiceRow {
        PurchaseInvoiceId?: number;
        InvoiceStatusId?: number;
        InvoiceTermId?: number;
        SuppliersId?: number;
        InvoiceDate?: string;
        PaymentDueDate?: string;
        PurchaseInvoiceNumber?: string;
        TotalTaxableAmount?: number;
        TotalTax?: number;
        TotalAmount?: number;
        IsReverseCharge?: boolean;
        IsActive?: boolean;
        InvoiceStatus?: string;
        InvoiceStatusIsActive?: boolean;
        InvoiceTerm?: string;
        InvoiceTermIsActive?: boolean;
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
        PurchaseInvoiceDetailsList?: PurchaseInvoiceDetailsRow[];
    }

    export namespace PurchaseInvoiceRow {
        export const idProperty = 'PurchaseInvoiceId';
        export const nameProperty = 'PurchaseInvoiceNumber';
        export const localTextPrefix = 'Masters.PurchaseInvoice';

        export declare const enum Fields {
            PurchaseInvoiceId = "PurchaseInvoiceId",
            InvoiceStatusId = "InvoiceStatusId",
            InvoiceTermId = "InvoiceTermId",
            SuppliersId = "SuppliersId",
            InvoiceDate = "InvoiceDate",
            PaymentDueDate = "PaymentDueDate",
            PurchaseInvoiceNumber = "PurchaseInvoiceNumber",
            TotalTaxableAmount = "TotalTaxableAmount",
            TotalTax = "TotalTax",
            TotalAmount = "TotalAmount",
            IsReverseCharge = "IsReverseCharge",
            IsActive = "IsActive",
            InvoiceStatus = "InvoiceStatus",
            InvoiceStatusIsActive = "InvoiceStatusIsActive",
            InvoiceTerm = "InvoiceTerm",
            InvoiceTermIsActive = "InvoiceTermIsActive",
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
            SuppliersOpeningBalance = "SuppliersOpeningBalance",
            PurchaseInvoiceDetailsList = "PurchaseInvoiceDetailsList"
        }
    }
}
