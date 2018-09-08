
namespace Serene.Masters {

    @Serenity.Decorators.registerClass()
    export class ProductDetailsDialog extends Serenity.EntityDialog<ProductDetailsRow, any> {
        protected getFormKey() { return ProductDetailsForm.formKey; }
        protected getIdProperty() { return ProductDetailsRow.idProperty; }
        protected getLocalTextPrefix() { return ProductDetailsRow.localTextPrefix; }
        protected getNameProperty() { return ProductDetailsRow.nameProperty; }
        protected getService() { return ProductDetailsService.baseUrl; }

        protected form = new ProductDetailsForm(this.idPrefix);

    }
}