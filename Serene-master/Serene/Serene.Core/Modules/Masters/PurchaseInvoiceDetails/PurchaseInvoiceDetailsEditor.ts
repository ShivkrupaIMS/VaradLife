/// <reference path="../../Common/Helpers/GridEditorBase.ts" />

namespace Serene.Masters {
    @Serenity.Decorators.registerEditor()
    export class PurchaseInvoiceDetailsEditor
        extends Common.GridEditorBase<PurchaseInvoiceDetailsRow> {
        protected getColumnsKey() { return "Masters.PurchaseInvoiceDetails"; }
        protected getLocalTextPrefix() { return PurchaseInvoiceDetailsRow.localTextPrefix; }
        protected getDialogType() { return PurchaseInvoiceDetailsEditDialog; }

        constructor(container: JQuery) {
            super(container);
        }

        protected getAddButtonCaption() {
            return "Add";
        }
        protected validateEntity(row: PurchaseInvoiceDetailsRow, id: number) {
            if (!super.validateEntity(row, id))
                return false;

            row.ProductProductName = ProductRow.getLookup()
                .itemById[row.ProductId].ProductName;

            row.ProductDetailsSku = ProductDetailsRow.getLookup()
                .itemById[row.ProductDetailsId].Sku;


            return true;
        }        
    }
}