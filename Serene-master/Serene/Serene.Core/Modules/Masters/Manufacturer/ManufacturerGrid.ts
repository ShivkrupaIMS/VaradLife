
namespace Serene.Masters {

    @Serenity.Decorators.registerClass()
    export class ManufacturerGrid extends Serenity.EntityGrid<ManufacturerRow, any> {
        protected getColumnsKey() { return 'Masters.Manufacturer'; }
        protected getDialogType() { return ManufacturerDialog; }
        protected getIdProperty() { return ManufacturerRow.idProperty; }
        protected getLocalTextPrefix() { return ManufacturerRow.localTextPrefix; }
        protected getService() { return ManufacturerService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}