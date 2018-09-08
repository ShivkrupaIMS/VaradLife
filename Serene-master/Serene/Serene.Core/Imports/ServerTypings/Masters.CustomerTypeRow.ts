namespace Serene.Masters {
    export interface CustomerTypeRow {
        CustomerTypeId?: number;
        CustomerType?: string;
        IsActive?: boolean;
    }

    export namespace CustomerTypeRow {
        export const idProperty = 'CustomerTypeId';
        export const nameProperty = 'CustomerType';
        export const localTextPrefix = 'Masters.CustomerType';
        export const lookupKey = 'Masters.CustomerType';

        export function getLookup(): Q.Lookup<CustomerTypeRow> {
            return Q.getLookup<CustomerTypeRow>('Masters.CustomerType');
        }

        export declare const enum Fields {
            CustomerTypeId = "CustomerTypeId",
            CustomerType = "CustomerType",
            IsActive = "IsActive"
        }
    }
}
