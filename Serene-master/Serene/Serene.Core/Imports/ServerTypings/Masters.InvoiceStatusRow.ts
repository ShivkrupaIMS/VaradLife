namespace Serene.Masters {
    export interface InvoiceStatusRow {
        InvoiceStatusId?: number;
        InvoiceStatus?: string;
        IsActive?: boolean;
    }

    export namespace InvoiceStatusRow {
        export const idProperty = 'InvoiceStatusId';
        export const nameProperty = 'InvoiceStatus';
        export const localTextPrefix = 'Masters.InvoiceStatus';
        export const lookupKey = 'Masters.InvoiceStatus';

        export function getLookup(): Q.Lookup<InvoiceStatusRow> {
            return Q.getLookup<InvoiceStatusRow>('Masters.InvoiceStatus');
        }

        export declare const enum Fields {
            InvoiceStatusId = "InvoiceStatusId",
            InvoiceStatus = "InvoiceStatus",
            IsActive = "IsActive"
        }
    }
}
