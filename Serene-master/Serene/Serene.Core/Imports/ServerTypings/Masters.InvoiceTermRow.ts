namespace Serene.Masters {
    export interface InvoiceTermRow {
        InvoiceTermId?: number;
        InvoiceTerm?: string;
        IsActive?: boolean;
    }

    export namespace InvoiceTermRow {
        export const idProperty = 'InvoiceTermId';
        export const nameProperty = 'InvoiceTerm';
        export const localTextPrefix = 'Masters.InvoiceTerm';
        export const lookupKey = 'Masters.InvoiceTerm';

        export function getLookup(): Q.Lookup<InvoiceTermRow> {
            return Q.getLookup<InvoiceTermRow>('Masters.InvoiceTerm');
        }

        export declare const enum Fields {
            InvoiceTermId = "InvoiceTermId",
            InvoiceTerm = "InvoiceTerm",
            IsActive = "IsActive"
        }
    }
}
