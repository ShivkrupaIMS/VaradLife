
namespace Serene.Northwind {

    @Serenity.Decorators.registerClass()
    export class ProductsNewGrid extends Serenity.EntityGrid<ProductsNewRow, any> {
        protected getColumnsKey() { return 'Northwind.ProductsNew'; }
        protected getDialogType() { return ProductsNewDialog; }
        protected getIdProperty() { return ProductsNewRow.idProperty; }
        protected getLocalTextPrefix() { return ProductsNewRow.localTextPrefix; }
        protected getService() { return ProductsNewService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}