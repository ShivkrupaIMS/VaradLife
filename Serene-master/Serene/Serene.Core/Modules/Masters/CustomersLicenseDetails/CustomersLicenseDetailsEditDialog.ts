/// <reference path="../../Common/Helpers/GridEditorDialog.ts" />

namespace Serene.Masters {

    @Serenity.Decorators.registerClass()
    export class CustomersLicenseDetailsEditDialog extends
        Common.GridEditorDialog<CustomersLicenseDetailsRow> {
        protected getFormKey() { return CustomersLicenseDetailsForm.formKey; }
        protected getNameProperty() { return CustomersLicenseDetailsRow.nameProperty; }
        protected getLocalTextPrefix() { return CustomersLicenseDetailsRow.localTextPrefix; }

        protected form: CustomersLicenseDetailsForm;

        constructor() {
            super();
            this.form = new CustomersLicenseDetailsForm(this.idPrefix);
        }
    }
}