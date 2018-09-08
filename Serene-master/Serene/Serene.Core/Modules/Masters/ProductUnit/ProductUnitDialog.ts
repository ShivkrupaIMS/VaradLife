
namespace Serene.Masters {

    @Serenity.Decorators.registerClass()
    export class ProductUnitDialog extends Serenity.EntityDialog<ProductUnitRow, any> {
        protected getFormKey() { return ProductUnitForm.formKey; }
        protected getIdProperty() { return ProductUnitRow.idProperty; }
        protected getLocalTextPrefix() { return ProductUnitRow.localTextPrefix; }
        protected getNameProperty() { return ProductUnitRow.nameProperty; }
        protected getService() { return ProductUnitService.baseUrl; }

        protected form = new ProductUnitForm(this.idPrefix);

    }
}