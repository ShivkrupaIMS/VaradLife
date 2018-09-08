
namespace Serene.Northwind {

    @Serenity.Decorators.registerClass()
    export class ProductsNewDialog extends Serenity.EntityDialog<ProductsNewRow, any> {
        protected getFormKey() { return ProductsNewForm.formKey; }
        protected getIdProperty() { return ProductsNewRow.idProperty; }
        protected getLocalTextPrefix() { return ProductsNewRow.localTextPrefix; }
        protected getNameProperty() { return ProductsNewRow.nameProperty; }
        protected getService() { return ProductsNewService.baseUrl; }

        protected form = new ProductsNewForm(this.idPrefix);

    }
}