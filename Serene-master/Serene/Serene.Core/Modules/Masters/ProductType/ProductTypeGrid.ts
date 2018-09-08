
namespace Serene.Masters {

    @Serenity.Decorators.registerClass()
    export class ProductTypeGrid extends Serenity.EntityGrid<ProductTypeRow, any> {
        protected getColumnsKey() { return 'Masters.ProductType'; }
        protected getDialogType() { return ProductTypeDialog; }
        protected getIdProperty() { return ProductTypeRow.idProperty; }
        protected getLocalTextPrefix() { return ProductTypeRow.localTextPrefix; }
        protected getService() { return ProductTypeService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}