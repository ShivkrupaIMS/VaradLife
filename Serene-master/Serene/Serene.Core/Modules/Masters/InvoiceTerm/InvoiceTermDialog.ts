
namespace Serene.Masters {

    @Serenity.Decorators.registerClass()
    export class InvoiceTermDialog extends Serenity.EntityDialog<InvoiceTermRow, any> {
        protected getFormKey() { return InvoiceTermForm.formKey; }
        protected getIdProperty() { return InvoiceTermRow.idProperty; }
        protected getLocalTextPrefix() { return InvoiceTermRow.localTextPrefix; }
        protected getNameProperty() { return InvoiceTermRow.nameProperty; }
        protected getService() { return InvoiceTermService.baseUrl; }

        protected form = new InvoiceTermForm(this.idPrefix);

    }
}