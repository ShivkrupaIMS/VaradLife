namespace Serene.Masters {
    export interface ProductDetailsRow {
        ProductDetailsId?: number;
        ProductId?: number;
        Sku?: string;
        ProductUnitId?: number;
        PackageSize?: number;
        PurchasePrice?: number;
        SalePrice?: number;
        Mrp?: number;
        PackageWeight?: string;
        ManufacturerId?: number;
        MinQuantity?: number;
        Discount?: number;
        Description?: string;
        IsActive?: boolean;
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
        ProductUnit?: string;
        ProductUnitIsActive?: boolean;
        ManufacturerManufacturerName?: string;
        ManufacturerShortName?: string;
        ManufacturerDescription?: string;
        ManufacturerIsActive?: boolean;
    }

    export namespace ProductDetailsRow {
        export const idProperty = 'ProductDetailsId';
        export const nameProperty = 'Sku';
        export const localTextPrefix = 'Masters.ProductDetails';
        export const lookupKey = 'Masters.ProductDetails';

        export function getLookup(): Q.Lookup<ProductDetailsRow> {
            return Q.getLookup<ProductDetailsRow>('Masters.ProductDetails');
        }

        export declare const enum Fields {
            ProductDetailsId = "ProductDetailsId",
            ProductId = "ProductId",
            Sku = "Sku",
            ProductUnitId = "ProductUnitId",
            PackageSize = "PackageSize",
            PurchasePrice = "PurchasePrice",
            SalePrice = "SalePrice",
            Mrp = "Mrp",
            PackageWeight = "PackageWeight",
            ManufacturerId = "ManufacturerId",
            MinQuantity = "MinQuantity",
            Discount = "Discount",
            Description = "Description",
            IsActive = "IsActive",
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
            ProductUnit = "ProductUnit",
            ProductUnitIsActive = "ProductUnitIsActive",
            ManufacturerManufacturerName = "ManufacturerManufacturerName",
            ManufacturerShortName = "ManufacturerShortName",
            ManufacturerDescription = "ManufacturerDescription",
            ManufacturerIsActive = "ManufacturerIsActive"
        }
    }
}
