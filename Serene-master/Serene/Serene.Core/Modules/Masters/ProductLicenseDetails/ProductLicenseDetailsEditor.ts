/// <reference path="../../Common/Helpers/GridEditorBase.ts" />

namespace Serene.Masters {
    @Serenity.Decorators.registerEditor()
    export class ProductLicenseDetailsEditor
        extends Common.GridEditorBase<ProductLicenseDetailsRow> {
        protected getColumnsKey() { return "Masters.ProductLicenseDetails"; }
        protected getLocalTextPrefix() { return ProductLicenseDetailsRow.localTextPrefix; }
        protected getDialogType() { return ProductLicenseDetailsEditDialog; }

        constructor(container: JQuery) {
            super(container);
        }

        protected getAddButtonCaption() {
            return "Add";
        }
        protected validateEntity(row: ProductLicenseDetailsRow, id: number) {
            if (!super.validateEntity(row, id))
                return false;

            row.LicenseType = LicenseTypeRow.getLookup()
                .itemById[row.LicenseTypeId].LicenseType;

            return true;
        }
    }
}