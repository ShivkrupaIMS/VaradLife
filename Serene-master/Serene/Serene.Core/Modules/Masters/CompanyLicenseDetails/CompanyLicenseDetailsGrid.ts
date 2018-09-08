
namespace Serene.Masters {

    @Serenity.Decorators.registerClass()
    export class CompanyLicenseDetailsGrid extends Serenity.EntityGrid<CompanyLicenseDetailsRow, any> {
        protected getColumnsKey() { return 'Masters.CompanyLicenseDetails'; }
        protected getDialogType() { return CompanyLicenseDetailsDialog; }
        protected getIdProperty() { return CompanyLicenseDetailsRow.idProperty; }
        protected getLocalTextPrefix() { return CompanyLicenseDetailsRow.localTextPrefix; }
        protected getService() { return CompanyLicenseDetailsService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}