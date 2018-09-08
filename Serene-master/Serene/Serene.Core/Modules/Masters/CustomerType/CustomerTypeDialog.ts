
namespace Serene.Masters {

    @Serenity.Decorators.registerClass()
    export class CustomerTypeDialog extends Serenity.EntityDialog<CustomerTypeRow, any> {
        protected getFormKey() { return CustomerTypeForm.formKey; }
        protected getIdProperty() { return CustomerTypeRow.idProperty; }
        protected getLocalTextPrefix() { return CustomerTypeRow.localTextPrefix; }
        protected getNameProperty() { return CustomerTypeRow.nameProperty; }
        protected getService() { return CustomerTypeService.baseUrl; }

        protected form = new CustomerTypeForm(this.idPrefix);

    }
}