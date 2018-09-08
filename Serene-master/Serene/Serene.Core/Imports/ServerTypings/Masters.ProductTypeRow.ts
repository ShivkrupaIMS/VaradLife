namespace Serene.Masters {
    export interface ProductTypeRow {
        ProductTypeId?: number;
        ProductType?: string;
        IsActive?: boolean;
    }

    export namespace ProductTypeRow {
        export const idProperty = 'ProductTypeId';
        export const nameProperty = 'ProductType';
        export const localTextPrefix = 'Masters.ProductType';
        export const lookupKey = 'Masters.ProductType';

        export function getLookup(): Q.Lookup<ProductTypeRow> {
            return Q.getLookup<ProductTypeRow>('Masters.ProductType');
        }

        export declare const enum Fields {
            ProductTypeId = "ProductTypeId",
            ProductType = "ProductType",
            IsActive = "IsActive"
        }
    }
}
