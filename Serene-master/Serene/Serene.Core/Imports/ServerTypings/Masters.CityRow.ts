namespace Serene.Masters {
    export interface CityRow {
        CityId?: number;
        CityCode?: string;
        CityName?: string;
        IsActive?: boolean;
        StateId?: number;
        StateStateCode?: string;
        StateStateName?: string;
        StateCountryId?: number;
        StateIsActive?: boolean;
    }

    export namespace CityRow {
        export const idProperty = 'CityId';
        export const nameProperty = 'CityName';
        export const localTextPrefix = 'Masters.City';
        export const lookupKey = 'Masters.City';

        export function getLookup(): Q.Lookup<CityRow> {
            return Q.getLookup<CityRow>('Masters.City');
        }

        export declare const enum Fields {
            CityId = "CityId",
            CityCode = "CityCode",
            CityName = "CityName",
            IsActive = "IsActive",
            StateId = "StateId",
            StateStateCode = "StateStateCode",
            StateStateName = "StateStateName",
            StateCountryId = "StateCountryId",
            StateIsActive = "StateIsActive"
        }
    }
}
