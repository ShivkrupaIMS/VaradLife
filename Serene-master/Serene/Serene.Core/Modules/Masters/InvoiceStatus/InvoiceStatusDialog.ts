
namespace Serene.Masters {

    @Serenity.Decorators.registerClass()
    export class InvoiceStatusDialog extends Serenity.EntityDialog<InvoiceStatusRow, any> {
        protected getFormKey() { return InvoiceStatusForm.formKey; }
        protected getIdProperty() { return InvoiceStatusRow.idProperty; }
        protected getLocalTextPrefix() { return InvoiceStatusRow.localTextPrefix; }
        protected getNameProperty() { return InvoiceStatusRow.nameProperty; }
        protected getService() { return InvoiceStatusService.baseUrl; }

        protected form = new InvoiceStatusForm(this.idPrefix);

    }
}