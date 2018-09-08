namespace Serene.Masters {
    export interface ProductLicenseDetailsRow {
        ProductLicenseDetailsId?: number;
        LicenseTypeId?: number;
        ProductId?: number;
        IsActive?: boolean;
        LicenseType?: string;
        LicenseTypeShortName?: string;
        LicenseTypeDescription?: string;
        LicenseTypeIsActive?: boolean;
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
    }

    export namespace ProductLicenseDetailsRow {
        export const idProperty = 'ProductLicenseDetailsId';
        export const localTextPrefix = 'Masters.ProductLicenseDetails';

        export declare const enum Fields {
            ProductLicenseDetailsId = "ProductLicenseDetailsId",
            LicenseTypeId = "LicenseTypeId",
            ProductId = "ProductId",
            IsActive = "IsActive",
            LicenseType = "LicenseType",
            LicenseTypeShortName = "LicenseTypeShortName",
            LicenseTypeDescription = "LicenseTypeDescription",
            LicenseTypeIsActive = "LicenseTypeIsActive",
            ProductHsnSacId = "ProductHsnSacId",
            ProductProductName = "ProductProductName",
            ProductProductTypeId = "ProductProductTypeId",
            ProductDescription = "ProductDescription",
            ProductIngredient = "ProductIngredient",
            ProductIgst = "ProductIgst",
            ProductCgst = "ProductCgst",
            ProductSgst = "ProductSgst",
            ProductComment = "ProductComment",
            ProductIsActive = "ProductIsActive"
        }
    }
}
