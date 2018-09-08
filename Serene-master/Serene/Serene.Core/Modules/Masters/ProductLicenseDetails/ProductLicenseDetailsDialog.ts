
namespace Serene.Masters {

    @Serenity.Decorators.registerClass()
    export class ProductLicenseDetailsDialog extends Serenity.EntityDialog<ProductLicenseDetailsRow, any> {
        protected getFormKey() { return ProductLicenseDetailsForm.formKey; }
        protected getIdProperty() { return ProductLicenseDetailsRow.idProperty; }
        protected getLocalTextPrefix() { return ProductLicenseDetailsRow.localTextPrefix; }
        protected getService() { return ProductLicenseDetailsService.baseUrl; }

        protected form = new ProductLicenseDetailsForm(this.idPrefix);

    }
}