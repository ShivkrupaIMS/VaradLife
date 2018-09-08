namespace Serene.Masters {
    export namespace SuppliersLicenseDetailsService {
        export const baseUrl = 'Masters/SuppliersLicenseDetails';

        export declare function Create(request: Serenity.SaveRequest<SuppliersLicenseDetailsRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Update(request: Serenity.SaveRequest<SuppliersLicenseDetailsRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<SuppliersLicenseDetailsRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<SuppliersLicenseDetailsRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;

        export declare const enum Methods {
            Create = "Masters/SuppliersLicenseDetails/Create",
            Update = "Masters/SuppliersLicenseDetails/Update",
            Delete = "Masters/SuppliersLicenseDetails/Delete",
            Retrieve = "Masters/SuppliersLicenseDetails/Retrieve",
            List = "Masters/SuppliersLicenseDetails/List"
        }

        [
            'Create', 
            'Update', 
            'Delete', 
            'Retrieve', 
            'List'
        ].forEach(x => {
            (<any>SuppliersLicenseDetailsService)[x] = function (r, s, o) {
                return Q.serviceRequest(baseUrl + '/' + x, r, s, o);
            };
        });
    }
}
