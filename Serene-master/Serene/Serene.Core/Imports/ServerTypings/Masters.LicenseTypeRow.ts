namespace Serene.Masters {
    export interface LicenseTypeRow {
        LicenseTypeId?: number;
        LicenseType?: string;
        ShortName?: string;
        Description?: string;
        IsActive?: boolean;
    }

    export namespace LicenseTypeRow {
        export const idProperty = 'LicenseTypeId';
        export const nameProperty = 'LicenseType';
        export const localTextPrefix = 'Masters.LicenseType';
        export const lookupKey = 'Masters.LicenseType';

        export function getLookup(): Q.Lookup<LicenseTypeRow> {
            return Q.getLookup<LicenseTypeRow>('Masters.LicenseType');
        }

        export declare const enum Fields {
            LicenseTypeId = "LicenseTypeId",
            LicenseType = "LicenseType",
            ShortName = "ShortName",
            Description = "Description",
            IsActive = "IsActive"
        }
    }
}
