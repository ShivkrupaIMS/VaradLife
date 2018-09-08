/// <reference path="../../Common/Helpers/GridEditorBase.ts" />

namespace Serene.Masters {
    @Serenity.Decorators.registerEditor()
    export class CompanyLicenseDetailsEditor
        extends Common.GridEditorBase<CompanyLicenseDetailsRow> {
        protected getColumnsKey() { return "Masters.CompanyLicenseDetails"; }
        protected getLocalTextPrefix() { return CompanyLicenseDetailsRow.localTextPrefix; }
        protected getDialogType() { return CompanyLicenseDetailsEditDialog; }

        constructor(container: JQuery) {
            super(container);
        }

        protected getAddButtonCaption() {
            return "Add";
        }
        protected validateEntity(row: CompanyLicenseDetailsRow, id: number) {
            if (!super.validateEntity(row, id))
                return false;

            row.LicenseType = LicenseTypeRow.getLookup()
                .itemById[row.LicenseTypeId].LicenseType;

            return true;
        }        
    }
}