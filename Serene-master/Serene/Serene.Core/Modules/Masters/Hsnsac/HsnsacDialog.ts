
namespace Serene.Masters {

    @Serenity.Decorators.registerClass()
    export class HsnsacDialog extends Serenity.EntityDialog<HsnsacRow, any> {
        protected getFormKey() { return HsnsacForm.formKey; }
        protected getIdProperty() { return HsnsacRow.idProperty; }
        protected getLocalTextPrefix() { return HsnsacRow.localTextPrefix; }
        protected getNameProperty() { return HsnsacRow.nameProperty; }
        protected getService() { return HsnsacService.baseUrl; }

        protected form = new HsnsacForm(this.idPrefix);

    }
}