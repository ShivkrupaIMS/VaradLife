
namespace Serene.Masters {

    @Serenity.Decorators.registerClass()
    export class InvoiceTermGrid extends Serenity.EntityGrid<InvoiceTermRow, any> {
        protected getColumnsKey() { return 'Masters.InvoiceTerm'; }
        protected getDialogType() { return InvoiceTermDialog; }
        protected getIdProperty() { return InvoiceTermRow.idProperty; }
        protected getLocalTextPrefix() { return InvoiceTermRow.localTextPrefix; }
        protected getService() { return InvoiceTermService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}