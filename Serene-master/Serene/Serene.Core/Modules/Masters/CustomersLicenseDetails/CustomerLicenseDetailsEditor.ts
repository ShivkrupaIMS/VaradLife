/// <reference path="../../Common/Helpers/GridEditorBase.ts" />

namespace Serene.Masters {
    @Serenity.Decorators.registerEditor()
    export class CustomersLicenseDetailsEditor
        extends Common.GridEditorBase<CustomersLicenseDetailsRow> {
        protected getColumnsKey() { return "Masters.CustomersLicenseDetails"; }
        protected getLocalTextPrefix() { return CustomersLicenseDetailsRow.localTextPrefix; }
        protected getDialogType() { return CustomersLicenseDetailsEditDialog; }

        constructor(container: JQuery) {
            super(container);
        }

        protected getAddButtonCaption() {
            return "Add";
        }
        protected validateEntity(row: CustomersLicenseDetailsRow, id: number) {
            if (!super.validateEntity(row, id))
                return false;

            row.LicenseType = LicenseTypeRow.getLookup()
                .itemById[row.LicenseTypeId].LicenseType;

            return true;
        }
    }
}