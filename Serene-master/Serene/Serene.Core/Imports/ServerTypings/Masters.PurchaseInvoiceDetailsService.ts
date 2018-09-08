namespace Serene.Masters {
    export namespace PurchaseInvoiceDetailsService {
        export const baseUrl = 'Masters/PurchaseInvoiceDetails';

        export declare function Create(request: Serenity.SaveRequest<PurchaseInvoiceDetailsRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Update(request: Serenity.SaveRequest<PurchaseInvoiceDetailsRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<PurchaseInvoiceDetailsRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<PurchaseInvoiceDetailsRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;

        export declare const enum Methods {
            Create = "Masters/PurchaseInvoiceDetails/Create",
            Update = "Masters/PurchaseInvoiceDetails/Update",
            Delete = "Masters/PurchaseInvoiceDetails/Delete",
            Retrieve = "Masters/PurchaseInvoiceDetails/Retrieve",
            List = "Masters/PurchaseInvoiceDetails/List"
        }

        [
            'Create', 
            'Update', 
            'Delete', 
            'Retrieve', 
            'List'
        ].forEach(x => {
            (<any>PurchaseInvoiceDetailsService)[x] = function (r, s, o) {
                return Q.serviceRequest(baseUrl + '/' + x, r, s, o);
            };
        });
    }
}
