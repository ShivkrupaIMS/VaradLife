
namespace Serene.Masters {

    @Serenity.Decorators.registerClass()
    export class CompanyTypeGrid extends Serenity.EntityGrid<CompanyTypeRow, any> {
        protected getColumnsKey() { return 'Masters.CompanyType'; }
        protected getDialogType() { return CompanyTypeDialog; }
        protected getIdProperty() { return CompanyTypeRow.idProperty; }
        protected getLocalTextPrefix() { return CompanyTypeRow.localTextPrefix; }
        protected getService() { return CompanyTypeService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}