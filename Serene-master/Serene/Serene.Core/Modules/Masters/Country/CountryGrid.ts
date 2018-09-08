
namespace Serene.Masters {

    @Serenity.Decorators.registerClass()
    export class CountryGrid extends Serenity.EntityGrid<CountryRow, any> {
        protected getColumnsKey() { return 'Masters.Country'; }
        protected getDialogType() { return CountryDialog; }
        protected getIdProperty() { return CountryRow.idProperty; }
        protected getLocalTextPrefix() { return CountryRow.localTextPrefix; }
        protected getService() { return CountryService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}