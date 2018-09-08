
namespace Serene.Masters {

    @Serenity.Decorators.registerClass()
    export class SupplierTypeDialog extends Serenity.EntityDialog<SupplierTypeRow, any> {
        protected getFormKey() { return SupplierTypeForm.formKey; }
        protected getIdProperty() { return SupplierTypeRow.idProperty; }
        protected getLocalTextPrefix() { return SupplierTypeRow.localTextPrefix; }
        protected getNameProperty() { return SupplierTypeRow.nameProperty; }
        protected getService() { return SupplierTypeService.baseUrl; }

        protected form = new SupplierTypeForm(this.idPrefix);

    }
}