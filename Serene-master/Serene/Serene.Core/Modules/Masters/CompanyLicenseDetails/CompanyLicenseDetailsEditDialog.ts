/// <reference path="../../Common/Helpers/GridEditorDialog.ts" />

namespace Serene.Masters {

    @Serenity.Decorators.registerClass()
    export class CompanyLicenseDetailsEditDialog extends
        Common.GridEditorDialog<CompanyLicenseDetailsRow> {
        protected getFormKey() { return CompanyLicenseDetailsForm.formKey; }
        protected getNameProperty() { return CompanyLicenseDetailsRow.nameProperty; }
        protected getLocalTextPrefix() { return CompanyLicenseDetailsRow.localTextPrefix; }

        protected form: CompanyLicenseDetailsForm;

        constructor() {
            super();
            this.form = new CompanyLicenseDetailsForm(this.idPrefix);
        }
    }
}