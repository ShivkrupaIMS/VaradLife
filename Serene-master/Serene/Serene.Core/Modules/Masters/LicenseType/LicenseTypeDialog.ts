
namespace Serene.Masters {

    @Serenity.Decorators.registerClass()
    export class LicenseTypeDialog extends Serenity.EntityDialog<LicenseTypeRow, any> {
        protected getFormKey() { return LicenseTypeForm.formKey; }
        protected getIdProperty() { return LicenseTypeRow.idProperty; }
        protected getLocalTextPrefix() { return LicenseTypeRow.localTextPrefix; }
        protected getNameProperty() { return LicenseTypeRow.nameProperty; }
        protected getService() { return LicenseTypeService.baseUrl; }

        protected form = new LicenseTypeForm(this.idPrefix);

    }
}