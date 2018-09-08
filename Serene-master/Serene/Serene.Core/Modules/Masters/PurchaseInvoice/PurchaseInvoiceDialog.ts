
namespace Serene.Masters {

    @Serenity.Decorators.registerClass()
    export class PurchaseInvoiceDialog extends Serenity.EntityDialog<PurchaseInvoiceRow, any> {
        protected getFormKey() { return PurchaseInvoiceForm.formKey; }
        protected getIdProperty() { return PurchaseInvoiceRow.idProperty; }
        protected getLocalTextPrefix() { return PurchaseInvoiceRow.localTextPrefix; }
        protected getNameProperty() { return PurchaseInvoiceRow.nameProperty; }
        protected getService() { return PurchaseInvoiceService.baseUrl; }

        protected form = new PurchaseInvoiceForm(this.idPrefix);

    }
}