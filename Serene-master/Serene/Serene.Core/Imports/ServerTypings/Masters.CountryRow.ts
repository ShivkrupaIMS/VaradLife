namespace Serene.Masters {
    export interface CountryRow {
        CountryId?: number;
        CountryCode?: string;
        CountryName?: string;
        IsActive?: boolean;
    }

    export namespace CountryRow {
        export const idProperty = 'CountryId';
        export const nameProperty = 'CountryName';
        export const localTextPrefix = 'Masters.Country';
        export const lookupKey = 'Masters.Country';

        export function getLookup(): Q.Lookup<CountryRow> {
            return Q.getLookup<CountryRow>('Masters.Country');
        }

        export declare const enum Fields {
            CountryId = "CountryId",
            CountryCode = "CountryCode",
            CountryName = "CountryName",
            IsActive = "IsActive"
        }
    }
}
