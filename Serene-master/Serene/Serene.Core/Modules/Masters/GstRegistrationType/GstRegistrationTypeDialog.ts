
namespace Serene.Masters {

    @Serenity.Decorators.registerClass()
    export class GstRegistrationTypeDialog extends Serenity.EntityDialog<GstRegistrationTypeRow, any> {
        protected getFormKey() { return GstRegistrationTypeForm.formKey; }
        protected getIdProperty() { return GstRegistrationTypeRow.idProperty; }
        protected getLocalTextPrefix() { return GstRegistrationTypeRow.localTextPrefix; }
        protected getNameProperty() { return GstRegistrationTypeRow.nameProperty; }
        protected getService() { return GstRegistrationTypeService.baseUrl; }

        protected form = new GstRegistrationTypeForm(this.idPrefix);

    }
}