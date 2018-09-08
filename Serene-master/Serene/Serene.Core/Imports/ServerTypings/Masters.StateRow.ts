namespace Serene.Masters {
    export interface StateRow {
        StateId?: number;
        StateCode?: string;
        StateName?: string;
        CountryId?: number;
        IsActive?: boolean;
        CountryCountryCode?: string;
        CountryCountryName?: string;
        CountryIsActive?: boolean;
    }

    export namespace StateRow {
        export const idProperty = 'StateId';
        export const nameProperty = 'StateName';
        export const localTextPrefix = 'Masters.State';
        export const lookupKey = 'Masters.State';

        export function getLookup(): Q.Lookup<StateRow> {
            return Q.getLookup<StateRow>('Masters.State');
        }

        export declare const enum Fields {
            StateId = "StateId",
            StateCode = "StateCode",
            StateName = "StateName",
            CountryId = "CountryId",
            IsActive = "IsActive",
            CountryCountryCode = "CountryCountryCode",
            CountryCountryName = "CountryCountryName",
            CountryIsActive = "CountryIsActive"
        }
    }
}
