
namespace Serene.Masters {

    @Serenity.Decorators.registerClass()
    export class CompanyTypeDialog extends Serenity.EntityDialog<CompanyTypeRow, any> {
        protected getFormKey() { return CompanyTypeForm.formKey; }
        protected getIdProperty() { return CompanyTypeRow.idProperty; }
        protected getLocalTextPrefix() { return CompanyTypeRow.localTextPrefix; }
        protected getNameProperty() { return CompanyTypeRow.nameProperty; }
        protected getService() { return CompanyTypeService.baseUrl; }

        protected form = new CompanyTypeForm(this.idPrefix);

    }
}