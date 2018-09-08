
namespace Serene.Masters {

    @Serenity.Decorators.registerClass()
    export class ProductUnitGrid extends Serenity.EntityGrid<ProductUnitRow, any> {
        protected getColumnsKey() { return 'Masters.ProductUnit'; }
        protected getDialogType() { return ProductUnitDialog; }
        protected getIdProperty() { return ProductUnitRow.idProperty; }
        protected getLocalTextPrefix() { return ProductUnitRow.localTextPrefix; }
        protected getService() { return ProductUnitService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}