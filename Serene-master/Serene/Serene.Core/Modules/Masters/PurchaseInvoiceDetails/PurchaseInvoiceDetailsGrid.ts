
namespace Serene.Masters {

    @Serenity.Decorators.registerClass()
    export class PurchaseInvoiceDetailsGrid extends Serenity.EntityGrid<PurchaseInvoiceDetailsRow, any> {
        protected getColumnsKey() { return 'Masters.PurchaseInvoiceDetails'; }
        protected getDialogType() { return PurchaseInvoiceDetailsDialog; }
        protected getIdProperty() { return PurchaseInvoiceDetailsRow.idProperty; }
        protected getLocalTextPrefix() { return PurchaseInvoiceDetailsRow.localTextPrefix; }
        protected getService() { return PurchaseInvoiceDetailsService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}