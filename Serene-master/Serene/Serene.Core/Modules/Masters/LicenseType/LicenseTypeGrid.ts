
namespace Serene.Masters {

    @Serenity.Decorators.registerClass()
    export class LicenseTypeGrid extends Serenity.EntityGrid<LicenseTypeRow, any> {
        protected getColumnsKey() { return 'Masters.LicenseType'; }
        protected getDialogType() { return LicenseTypeDialog; }
        protected getIdProperty() { return LicenseTypeRow.idProperty; }
        protected getLocalTextPrefix() { return LicenseTypeRow.localTextPrefix; }
        protected getService() { return LicenseTypeService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}