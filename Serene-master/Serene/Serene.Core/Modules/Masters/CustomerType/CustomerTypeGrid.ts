
namespace Serene.Masters {

    @Serenity.Decorators.registerClass()
    export class CustomerTypeGrid extends Serenity.EntityGrid<CustomerTypeRow, any> {
        protected getColumnsKey() { return 'Masters.CustomerType'; }
        protected getDialogType() { return CustomerTypeDialog; }
        protected getIdProperty() { return CustomerTypeRow.idProperty; }
        protected getLocalTextPrefix() { return CustomerTypeRow.localTextPrefix; }
        protected getService() { return CustomerTypeService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}