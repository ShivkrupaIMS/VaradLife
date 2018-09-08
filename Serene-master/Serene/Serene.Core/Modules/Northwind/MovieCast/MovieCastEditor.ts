/// <reference path="../../Common/Helpers/GridEditorBase.ts" />

namespace Serene.Northwind
{
    @Serenity.Decorators.registerEditor()
    export class MovieCastEditor
        extends Common.GridEditorBase<Serene.Northwind.MovieCastRow> {
        protected getColumnsKey() { return "Northwind.MovieCast"; }
        protected getLocalTextPrefix() { return Serene.Northwind.MovieCastRow.localTextPrefix; }
        protected getDialogType() { return MovieCastEditDialog; }

        constructor(container: JQuery) {
            super(container);
        }

        protected getAddButtonCaption() {
            return "Add";
        }

        protected validateEntity(row: MovieCastRow, id: number) {
            if (!super.validateEntity(row, id))
                return false;

            row.PersonFullname = PersonRow.getLookup()
                .itemById[row.PersonId].Fullname;

            return true;
        }        
    }
}
