namespace Serene.Masters {
    export interface PurchaseInvoiceDetailsRow {
        PurchaseInvoiceDetailsId?: number;
        PurchaseInvoiceId?: number;
        ProductId?: number;
        ProductDetailsId?: number;
        PackageSize?: string;
        BatchNumber?: string;
        ExpiryDate?: string;
        Quantity?: number;
        DiscountPercent?: number;
        ProductValue?: number;
        DiscountValue?: number;
        TaxableValue?: number;
        IgstRate?: number;
        IgstAmount?: number;
        CgstRate?: number;
        CgstAmount?: number;
        SgstRate?: number;
        SgstAmount?: number;
        CessRate?: number;
        CessAmount?: number;
        TotalTaxPlusCess?: number;
        TotalTransactionAmount?: number;
        IsActive?: boolean;
        PurchaseInvoiceInvoiceStatusId?: number;
        PurchaseInvoiceInvoiceTermId?: number;
        PurchaseInvoiceSuppliersId?: number;
        PurchaseInvoiceInvoiceDate?: string;
        PurchaseInvoicePaymentDueDate?: string;
        PurchaseInvoicePurchaseInvoiceNumber?: string;
        PurchaseInvoiceTotalTaxableAmount?: number;
        PurchaseInvoiceTotalTax?: number;
        PurchaseInvoiceTotalAmount?: number;
        PurchaseInvoiceIsReverseCharge?: boolean;
        PurchaseInvoiceIsActive?: boolean;
        ProductHsnSacId?: number;
        ProductProductName?: string;
        ProductProductTypeId?: number;
        ProductDescription?: string;
        ProductIngredient?: string;
        ProductIgst?: number;
        ProductCgst?: number;
        ProductSgst?: number;
        ProductComment?: string;
        ProductIsActive?: boolean;
        ProductDetailsProductId?: number;
        ProductDetailsSku?: string;
        ProductDetailsProductUnitId?: number;
        ProductDetailsPackageSize?: number;
        ProductDetailsPurchasePrice?: number;
        ProductDetailsSalePrice?: number;
        ProductDetailsMrp?: number;
        ProductDetailsPackageWeight?: string;
        ProductDetailsManufacturerId?: number;
        ProductDetailsMinQuantity?: number;
        ProductDetailsDiscount?: number;
        ProductDetailsDescription?: string;
        ProductDetailsIsActive?: boolean;
    }

    export namespace PurchaseInvoiceDetailsRow {
        export const idProperty = 'PurchaseInvoiceDetailsId';
        export const nameProperty = 'PackageSize';
        export const localTextPrefix = 'Masters.PurchaseInvoiceDetails';

        export declare const enum Fields {
            PurchaseInvoiceDetailsId = "PurchaseInvoiceDetailsId",
            PurchaseInvoiceId = "PurchaseInvoiceId",
            ProductId = "ProductId",
            ProductDetailsId = "ProductDetailsId",
            PackageSize = "PackageSize",
            BatchNumber = "BatchNumber",
            ExpiryDate = "ExpiryDate",
            Quantity = "Quantity",
            DiscountPercent = "DiscountPercent",
            ProductValue = "ProductValue",
            DiscountValue = "DiscountValue",
            TaxableValue = "TaxableValue",
            IgstRate = "IgstRate",
            IgstAmount = "IgstAmount",
            CgstRate = "CgstRate",
            CgstAmount = "CgstAmount",
            SgstRate = "SgstRate",
            SgstAmount = "SgstAmount",
            CessRate = "CessRate",
            CessAmount = "CessAmount",
            TotalTaxPlusCess = "TotalTaxPlusCess",
            TotalTransactionAmount = "TotalTransactionAmount",
            IsActive = "IsActive",
            PurchaseInvoiceInvoiceStatusId = "PurchaseInvoiceInvoiceStatusId",
            PurchaseInvoiceInvoiceTermId = "PurchaseInvoiceInvoiceTermId",
            PurchaseInvoiceSuppliersId = "PurchaseInvoiceSuppliersId",
            PurchaseInvoiceInvoiceDate = "PurchaseInvoiceInvoiceDate",
            PurchaseInvoicePaymentDueDate = "PurchaseInvoicePaymentDueDate",
            PurchaseInvoicePurchaseInvoiceNumber = "PurchaseInvoicePurchaseInvoiceNumber",
            PurchaseInvoiceTotalTaxableAmount = "PurchaseInvoiceTotalTaxableAmount",
            PurchaseInvoiceTotalTax = "PurchaseInvoiceTotalTax",
            PurchaseInvoiceTotalAmount = "PurchaseInvoiceTotalAmount",
            PurchaseInvoiceIsReverseCharge = "PurchaseInvoiceIsReverseCharge",
            PurchaseInvoiceIsActive = "PurchaseInvoiceIsActive",
            ProductHsnSacId = "ProductHsnSacId",
            ProductProductName = "ProductProductName",
            ProductProductTypeId = "ProductProductTypeId",
            ProductDescription = "ProductDescription",
            ProductIngredient = "ProductIngredient",
            ProductIgst = "ProductIgst",
            ProductCgst = "ProductCgst",
            ProductSgst = "ProductSgst",
            ProductComment = "ProductComment",
            ProductIsActive = "ProductIsActive",
            ProductDetailsProductId = "ProductDetailsProductId",
            ProductDetailsSku = "ProductDetailsSku",
            ProductDetailsProductUnitId = "ProductDetailsProductUnitId",
            ProductDetailsPackageSize = "ProductDetailsPackageSize",
            ProductDetailsPurchasePrice = "ProductDetailsPurchasePrice",
            ProductDetailsSalePrice = "ProductDetailsSalePrice",
            ProductDetailsMrp = "ProductDetailsMrp",
            ProductDetailsPackageWeight = "ProductDetailsPackageWeight",
            ProductDetailsManufacturerId = "ProductDetailsManufacturerId",
            ProductDetailsMinQuantity = "ProductDetailsMinQuantity",
            ProductDetailsDiscount = "ProductDetailsDiscount",
            ProductDetailsDescription = "ProductDetailsDescription",
            ProductDetailsIsActive = "ProductDetailsIsActive"
        }
    }
}
