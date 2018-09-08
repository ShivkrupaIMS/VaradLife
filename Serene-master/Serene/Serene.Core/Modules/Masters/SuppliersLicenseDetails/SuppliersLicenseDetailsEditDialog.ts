/// <reference path="../../Common/Helpers/GridEditorDialog.ts" />

namespace Serene.Masters {

    @Serenity.Decorators.registerClass()
    export class SuppliersLicenseDetailsEditDialog extends
        Common.GridEditorDialog<SuppliersLicenseDetailsRow> {
        protected getFormKey() { return SuppliersLicenseDetailsForm.formKey; }
        protected getNameProperty() { return SuppliersLicenseDetailsRow.nameProperty; }
        protected getLocalTextPrefix() { return SuppliersLicenseDetailsRow.localTextPrefix; }

        protected form: SuppliersLicenseDetailsForm;

        constructor() {
            super();
            this.form = new SuppliersLicenseDetailsForm(this.idPrefix);
        }
    }
}