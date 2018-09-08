namespace Serene.Masters {
    export interface ManufacturerRow {
        ManufacturerId?: number;
        ManufacturerName?: string;
        ShortName?: string;
        Description?: string;
        IsActive?: boolean;
    }

    export namespace ManufacturerRow {
        export const idProperty = 'ManufacturerId';
        export const nameProperty = 'ManufacturerName';
        export const localTextPrefix = 'Masters.Manufacturer';
        export const lookupKey = 'Masters.Manufacturer';

        export function getLookup(): Q.Lookup<ManufacturerRow> {
            return Q.getLookup<ManufacturerRow>('Masters.Manufacturer');
        }

        export declare const enum Fields {
            ManufacturerId = "ManufacturerId",
            ManufacturerName = "ManufacturerName",
            ShortName = "ShortName",
            Description = "Description",
            IsActive = "IsActive"
        }
    }
}
