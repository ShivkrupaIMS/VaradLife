namespace Serene.Masters {
    export interface SupplierTypeRow {
        SupplierTypeId?: number;
        SupplierType?: string;
        IsActive?: boolean;
    }

    export namespace SupplierTypeRow {
        export const idProperty = 'SupplierTypeId';
        export const nameProperty = 'SupplierType';
        export const localTextPrefix = 'Masters.SupplierType';
        export const lookupKey = 'Masters.SupplierType';

        export function getLookup(): Q.Lookup<SupplierTypeRow> {
            return Q.getLookup<SupplierTypeRow>('Masters.SupplierType');
        }

        export declare const enum Fields {
            SupplierTypeId = "SupplierTypeId",
            SupplierType = "SupplierType",
            IsActive = "IsActive"
        }
    }
}
