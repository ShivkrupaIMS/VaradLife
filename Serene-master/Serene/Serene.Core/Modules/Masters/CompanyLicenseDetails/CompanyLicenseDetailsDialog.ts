
namespace Serene.Masters {

    @Serenity.Decorators.registerClass()
    export class CompanyLicenseDetailsDialog extends Serenity.EntityDialog<CompanyLicenseDetailsRow, any> {
        protected getFormKey() { return CompanyLicenseDetailsForm.formKey; }
        protected getIdProperty() { return CompanyLicenseDetailsRow.idProperty; }
        protected getLocalTextPrefix() { return CompanyLicenseDetailsRow.localTextPrefix; }
        protected getNameProperty() { return CompanyLicenseDetailsRow.nameProperty; }
        protected getService() { return CompanyLicenseDetailsService.baseUrl; }

        protected form = new CompanyLicenseDetailsForm(this.idPrefix);

    }
}