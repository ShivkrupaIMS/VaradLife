
namespace Serene.Masters {

    @Serenity.Decorators.registerClass()
    export class StateDialog extends Serenity.EntityDialog<StateRow, any> {
        protected getFormKey() { return StateForm.formKey; }
        protected getIdProperty() { return StateRow.idProperty; }
        protected getLocalTextPrefix() { return StateRow.localTextPrefix; }
        protected getNameProperty() { return StateRow.nameProperty; }
        protected getService() { return StateService.baseUrl; }

        protected form = new StateForm(this.idPrefix);

    }
}