
namespace Serene.Masters {

    @Serenity.Decorators.registerClass()
    export class GstRegistrationTypeGrid extends Serenity.EntityGrid<GstRegistrationTypeRow, any> {
        protected getColumnsKey() { return 'Masters.GstRegistrationType'; }
        protected getDialogType() { return GstRegistrationTypeDialog; }
        protected getIdProperty() { return GstRegistrationTypeRow.idProperty; }
        protected getLocalTextPrefix() { return GstRegistrationTypeRow.localTextPrefix; }
        protected getService() { return GstRegistrationTypeService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}