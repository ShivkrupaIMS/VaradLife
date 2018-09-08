/// <reference path="../../Common/Helpers/GridEditorDialog.ts" />

namespace Serene.Masters {

    @Serenity.Decorators.registerClass()
    export class PurchaseInvoiceDetailsEditDialog extends
        Common.GridEditorDialog<PurchaseInvoiceDetailsRow> {
        protected getFormKey() { return PurchaseInvoiceDetailsForm.formKey; }
        protected getNameProperty() { return PurchaseInvoiceDetailsRow.nameProperty; }
        protected getLocalTextPrefix() { return PurchaseInvoiceDetailsRow.localTextPrefix; }

        protected form: PurchaseInvoiceDetailsForm;

        constructor() {
            super();
            this.form = new PurchaseInvoiceDetailsForm(this.idPrefix);
        }
    }
}