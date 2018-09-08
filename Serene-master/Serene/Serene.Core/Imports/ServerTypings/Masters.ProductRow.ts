namespace Serene.Masters {
    export interface ProductRow {
        ProductId?: number;
        HsnSacId?: number;
        ProductName?: string;
        ProductTypeId?: number;
        Description?: string;
        Ingredient?: string;
        Igst?: number;
        Cgst?: number;
        Sgst?: number;
        Comment?: string;
        IsActive?: boolean;
        HsnSacHsnsacNo?: string;
        HsnSacTaxRate?: number;
        HsnSacIsActive?: boolean;
        ProductType?: string;
        ProductTypeIsActive?: boolean;
        ProductDetailsList?: ProductDetailsRow[];
        LicenseList?: ProductLicenseDetailsRow[];
    }

    export namespace ProductRow {
        export const idProperty = 'ProductId';
        export const nameProperty = 'ProductName';
        export const localTextPrefix = 'Masters.Product';
        export const lookupKey = 'Masters.Product';

        export function getLookup(): Q.Lookup<ProductRow> {
            return Q.getLookup<ProductRow>('Masters.Product');
        }

        export declare const enum Fields {
            ProductId = "ProductId",
            HsnSacId = "HsnSacId",
            ProductName = "ProductName",
            ProductTypeId = "ProductTypeId",
            Description = "Description",
            Ingredient = "Ingredient",
            Igst = "Igst",
            Cgst = "Cgst",
            Sgst = "Sgst",
            Comment = "Comment",
            IsActive = "IsActive",
            HsnSacHsnsacNo = "HsnSacHsnsacNo",
            HsnSacTaxRate = "HsnSacTaxRate",
            HsnSacIsActive = "HsnSacIsActive",
            ProductType = "ProductType",
            ProductTypeIsActive = "ProductTypeIsActive",
            ProductDetailsList = "ProductDetailsList",
            LicenseList = "LicenseList"
        }
    }
}
