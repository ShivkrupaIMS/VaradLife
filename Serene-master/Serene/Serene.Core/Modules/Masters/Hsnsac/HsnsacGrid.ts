
namespace Serene.Masters {

    @Serenity.Decorators.registerClass()
    export class HsnsacGrid extends Serenity.EntityGrid<HsnsacRow, any> {
        protected getColumnsKey() { return 'Masters.Hsnsac'; }
        protected getDialogType() { return HsnsacDialog; }
        protected getIdProperty() { return HsnsacRow.idProperty; }
        protected getLocalTextPrefix() { return HsnsacRow.localTextPrefix; }
        protected getService() { return HsnsacService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}