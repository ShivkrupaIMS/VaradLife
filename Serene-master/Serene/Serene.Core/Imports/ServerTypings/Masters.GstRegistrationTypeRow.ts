namespace Serene.Masters {
    export interface GstRegistrationTypeRow {
        GstRegistrationTypeId?: number;
        GstRegistrationType?: string;
        IsActive?: boolean;
    }

    export namespace GstRegistrationTypeRow {
        export const idProperty = 'GstRegistrationTypeId';
        export const nameProperty = 'GstRegistrationType';
        export const localTextPrefix = 'Masters.GstRegistrationType';
        export const lookupKey = 'Masters.GstRegistrationType';

        export function getLookup(): Q.Lookup<GstRegistrationTypeRow> {
            return Q.getLookup<GstRegistrationTypeRow>('Masters.GstRegistrationType');
        }

        export declare const enum Fields {
            GstRegistrationTypeId = "GstRegistrationTypeId",
            GstRegistrationType = "GstRegistrationType",
            IsActive = "IsActive"
        }
    }
}
