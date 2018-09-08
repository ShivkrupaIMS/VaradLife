
namespace Serene.Masters {

    @Serenity.Decorators.registerClass()
    export class CustomersLicenseDetailsDialog extends Serenity.EntityDialog<CustomersLicenseDetailsRow, any> {
        protected getFormKey() { return CustomersLicenseDetailsForm.formKey; }
        protected getIdProperty() { return CustomersLicenseDetailsRow.idProperty; }
        protected getLocalTextPrefix() { return CustomersLicenseDetailsRow.localTextPrefix; }
        protected getNameProperty() { return CustomersLicenseDetailsRow.nameProperty; }
        protected getService() { return CustomersLicenseDetailsService.baseUrl; }

        protected form = new CustomersLicenseDetailsForm(this.idPrefix);

    }
}