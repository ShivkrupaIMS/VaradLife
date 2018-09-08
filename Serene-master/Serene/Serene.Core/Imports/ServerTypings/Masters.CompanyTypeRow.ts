namespace Serene.Masters {
    export interface CompanyTypeRow {
        CompanyTypeId?: number;
        CompanyType?: string;
        IsActive?: boolean;
    }

    export namespace CompanyTypeRow {
        export const idProperty = 'CompanyTypeId';
        export const nameProperty = 'CompanyType';
        export const localTextPrefix = 'Masters.CompanyType';
        export const lookupKey = 'Masters.CompanyType';

        export function getLookup(): Q.Lookup<CompanyTypeRow> {
            return Q.getLookup<CompanyTypeRow>('Masters.CompanyType');
        }

        export declare const enum Fields {
            CompanyTypeId = "CompanyTypeId",
            CompanyType = "CompanyType",
            IsActive = "IsActive"
        }
    }
}
