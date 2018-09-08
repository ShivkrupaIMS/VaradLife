/// <reference path="../../Common/Helpers/GridEditorDialog.ts" />

namespace Serene.Masters {

    @Serenity.Decorators.registerClass()
    export class ProductLicenseDetailsEditDialog extends
        Common.GridEditorDialog<ProductLicenseDetailsRow> {
        protected getFormKey() { return ProductLicenseDetailsForm.formKey; }
        protected getNameProperty() { return ProductLicenseDetailsRow.nameProperty; }
        protected getLocalTextPrefix() { return ProductLicenseDetailsRow.localTextPrefix; }

        protected form: ProductLicenseDetailsForm;

        constructor() {
            super();
            this.form = new ProductLicenseDetailsForm(this.idPrefix);
        }
    }
}