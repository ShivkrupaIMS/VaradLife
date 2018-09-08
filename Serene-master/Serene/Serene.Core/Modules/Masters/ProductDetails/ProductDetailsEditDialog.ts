/// <reference path="../../Common/Helpers/GridEditorDialog.ts" />

namespace Serene.Masters {

    @Serenity.Decorators.registerClass()
    export class ProductDetailsEditDialog extends
        Common.GridEditorDialog<ProductDetailsRow> {
        protected getFormKey() { return ProductDetailsForm.formKey; }
        protected getNameProperty() { return ProductDetailsRow.nameProperty; }
        protected getLocalTextPrefix() { return ProductDetailsRow.localTextPrefix; }

        protected form: ProductDetailsForm;

        constructor() {
            super();
            this.form = new ProductDetailsForm(this.idPrefix);
        }
    }
}