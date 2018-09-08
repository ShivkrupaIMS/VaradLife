
namespace Serene.Masters {

    @Serenity.Decorators.registerClass()
    export class ProductLicenseDetailsGrid extends Serenity.EntityGrid<ProductLicenseDetailsRow, any> {
        protected getColumnsKey() { return 'Masters.ProductLicenseDetails'; }
        protected getDialogType() { return ProductLicenseDetailsDialog; }
        protected getIdProperty() { return ProductLicenseDetailsRow.idProperty; }
        protected getLocalTextPrefix() { return ProductLicenseDetailsRow.localTextPrefix; }
        protected getService() { return ProductLicenseDetailsService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}