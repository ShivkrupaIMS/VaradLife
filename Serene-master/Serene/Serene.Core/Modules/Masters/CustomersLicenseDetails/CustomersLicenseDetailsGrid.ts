
namespace Serene.Masters {

    @Serenity.Decorators.registerClass()
    export class CustomersLicenseDetailsGrid extends Serenity.EntityGrid<CustomersLicenseDetailsRow, any> {
        protected getColumnsKey() { return 'Masters.CustomersLicenseDetails'; }
        protected getDialogType() { return CustomersLicenseDetailsDialog; }
        protected getIdProperty() { return CustomersLicenseDetailsRow.idProperty; }
        protected getLocalTextPrefix() { return CustomersLicenseDetailsRow.localTextPrefix; }
        protected getService() { return CustomersLicenseDetailsService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}