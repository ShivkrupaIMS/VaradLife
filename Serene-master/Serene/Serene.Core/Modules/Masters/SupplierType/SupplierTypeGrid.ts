
namespace Serene.Masters {

    @Serenity.Decorators.registerClass()
    export class SupplierTypeGrid extends Serenity.EntityGrid<SupplierTypeRow, any> {
        protected getColumnsKey() { return 'Masters.SupplierType'; }
        protected getDialogType() { return SupplierTypeDialog; }
        protected getIdProperty() { return SupplierTypeRow.idProperty; }
        protected getLocalTextPrefix() { return SupplierTypeRow.localTextPrefix; }
        protected getService() { return SupplierTypeService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}