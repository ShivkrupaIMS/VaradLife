/// <reference path="../../Common/Helpers/GridEditorBase.ts" />

namespace Serene.Masters {
    @Serenity.Decorators.registerEditor()
    export class SuppliersLicenseDetailsEditor
        extends Common.GridEditorBase<SuppliersLicenseDetailsRow> {
        protected getColumnsKey() { return "Masters.SuppliersLicenseDetails"; }
        protected getLocalTextPrefix() { return SuppliersLicenseDetailsRow.localTextPrefix; }
        protected getDialogType() { return SuppliersLicenseDetailsEditDialog; }

        constructor(container: JQuery) {
            super(container);
        }

        protected getAddButtonCaption() {
            return "Add";
        }
        protected validateEntity(row: SuppliersLicenseDetailsRow, id: number) {
            if (!super.validateEntity(row, id))
                return false;

            row.LicenseType = LicenseTypeRow.getLookup()
                .itemById[row.LicenseTypeId].LicenseType;

            return true;
        }
    }
}