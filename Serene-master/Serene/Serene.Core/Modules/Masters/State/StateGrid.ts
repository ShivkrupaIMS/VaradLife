
namespace Serene.Masters {

    @Serenity.Decorators.registerClass()
    export class StateGrid extends Serenity.EntityGrid<StateRow, any> {
        protected getColumnsKey() { return 'Masters.State'; }
        protected getDialogType() { return StateDialog; }
        protected getIdProperty() { return StateRow.idProperty; }
        protected getLocalTextPrefix() { return StateRow.localTextPrefix; }
        protected getService() { return StateService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}