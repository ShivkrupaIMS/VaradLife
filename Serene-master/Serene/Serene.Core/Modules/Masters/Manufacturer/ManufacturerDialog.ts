
namespace Serene.Masters {

    @Serenity.Decorators.registerClass()
    export class ManufacturerDialog extends Serenity.EntityDialog<ManufacturerRow, any> {
        protected getFormKey() { return ManufacturerForm.formKey; }
        protected getIdProperty() { return ManufacturerRow.idProperty; }
        protected getLocalTextPrefix() { return ManufacturerRow.localTextPrefix; }
        protected getNameProperty() { return ManufacturerRow.nameProperty; }
        protected getService() { return ManufacturerService.baseUrl; }

        protected form = new ManufacturerForm(this.idPrefix);

    }
}