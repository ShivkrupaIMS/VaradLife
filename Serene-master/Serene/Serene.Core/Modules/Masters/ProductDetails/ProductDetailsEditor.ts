/// <reference path="../../Common/Helpers/GridEditorBase.ts" />

namespace Serene.Masters {
    @Serenity.Decorators.registerEditor()
    export class ProductDetailsEditor
        extends Common.GridEditorBase<ProductDetailsRow> {
        protected getColumnsKey() { return "Masters.ProductDetails"; }
        protected getLocalTextPrefix() { return ProductDetailsRow.localTextPrefix; }
        protected getDialogType() { return ProductDetailsEditDialog; }

        constructor(container: JQuery) {
            super(container);
        }

        protected getAddButtonCaption() {
            return "Add";
        }
        protected validateEntity(row: ProductDetailsRow, id: number) {
            if (!super.validateEntity(row, id))
                return false;

            row.ManufacturerManufacturerName = ManufacturerRow.getLookup()
                .itemById[row.ManufacturerId].ShortName;

            row.ProductUnit = ProductUnitRow.getLookup()
                .itemById[row.ProductUnitId].ProductUnit;

            return true;
        }
    }
}