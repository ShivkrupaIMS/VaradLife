
namespace Serene.Masters {

    @Serenity.Decorators.registerClass()
    export class InvoiceStatusGrid extends Serenity.EntityGrid<InvoiceStatusRow, any> {
        protected getColumnsKey() { return 'Masters.InvoiceStatus'; }
        protected getDialogType() { return InvoiceStatusDialog; }
        protected getIdProperty() { return InvoiceStatusRow.idProperty; }
        protected getLocalTextPrefix() { return InvoiceStatusRow.localTextPrefix; }
        protected getService() { return InvoiceStatusService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}