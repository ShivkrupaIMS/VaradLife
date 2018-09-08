namespace Serene.Masters {
    export interface HsnsacRow {
        HsnsacId?: number;
        HsnsacNo?: string;
        TaxRate?: number;
        IsActive?: boolean;
    }

    export namespace HsnsacRow {
        export const idProperty = 'HsnsacId';
        export const nameProperty = 'HsnsacNo';
        export const localTextPrefix = 'Masters.Hsnsac';
        export const lookupKey = 'Masters.Hsnsac';

        export function getLookup(): Q.Lookup<HsnsacRow> {
            return Q.getLookup<HsnsacRow>('Masters.Hsnsac');
        }

        export declare const enum Fields {
            HsnsacId = "HsnsacId",
            HsnsacNo = "HsnsacNo",
            TaxRate = "TaxRate",
            IsActive = "IsActive"
        }
    }
}
