
namespace Serene.Masters {

    @Serenity.Decorators.registerClass()
    export class SuppliersLicenseDetailsGrid extends Serenity.EntityGrid<SuppliersLicenseDetailsRow, any> {
        protected getColumnsKey() { return 'Masters.SuppliersLicenseDetails'; }
        protected getDialogType() { return SuppliersLicenseDetailsDialog; }
        protected getIdProperty() { return SuppliersLicenseDetailsRow.idProperty; }
        protected getLocalTextPrefix() { return SuppliersLicenseDetailsRow.localTextPrefix; }
        protected getService() { return SuppliersLicenseDetailsService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}