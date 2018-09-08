namespace Serene.Masters {
    export interface ProductUnitRow {
        ProductUnitId?: number;
        ProductUnit?: string;
        IsActive?: boolean;
    }

    export namespace ProductUnitRow {
        export const idProperty = 'ProductUnitId';
        export const nameProperty = 'ProductUnit';
        export const localTextPrefix = 'Masters.ProductUnit';
        export const lookupKey = 'Masters.ProductUnit';

        export function getLookup(): Q.Lookup<ProductUnitRow> {
            return Q.getLookup<ProductUnitRow>('Masters.ProductUnit');
        }

        export declare const enum Fields {
            ProductUnitId = "ProductUnitId",
            ProductUnit = "ProductUnit",
            IsActive = "IsActive"
        }
    }
}
