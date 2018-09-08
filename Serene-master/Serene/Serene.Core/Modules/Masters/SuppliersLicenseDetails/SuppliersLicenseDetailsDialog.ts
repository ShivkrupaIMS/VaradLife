
namespace Serene.Masters {

    @Serenity.Decorators.registerClass()
    export class SuppliersLicenseDetailsDialog extends Serenity.EntityDialog<SuppliersLicenseDetailsRow, any> {
        protected getFormKey() { return SuppliersLicenseDetailsForm.formKey; }
        protected getIdProperty() { return SuppliersLicenseDetailsRow.idProperty; }
        protected getLocalTextPrefix() { return SuppliersLicenseDetailsRow.localTextPrefix; }
        protected getNameProperty() { return SuppliersLicenseDetailsRow.nameProperty; }
        protected getService() { return SuppliersLicenseDetailsService.baseUrl; }

        protected form = new SuppliersLicenseDetailsForm(this.idPrefix);

    }
}