
namespace Serene.Masters {

    @Serenity.Decorators.registerClass()
    export class PurchaseInvoiceGrid extends Serenity.EntityGrid<PurchaseInvoiceRow, any> {
        protected getColumnsKey() { return 'Masters.PurchaseInvoice'; }
        protected getDialogType() { return PurchaseInvoiceDialog; }
        protected getIdProperty() { return PurchaseInvoiceRow.idProperty; }
        protected getLocalTextPrefix() { return PurchaseInvoiceRow.localTextPrefix; }
        protected getService() { return PurchaseInvoiceService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}