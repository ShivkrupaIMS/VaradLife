
namespace Serene.Masters {

    @Serenity.Decorators.registerClass()
    export class PurchaseInvoiceDetailsDialog extends Serenity.EntityDialog<PurchaseInvoiceDetailsRow, any> {
        protected getFormKey() { return PurchaseInvoiceDetailsForm.formKey; }
        protected getIdProperty() { return PurchaseInvoiceDetailsRow.idProperty; }
        protected getLocalTextPrefix() { return PurchaseInvoiceDetailsRow.localTextPrefix; }
        protected getNameProperty() { return PurchaseInvoiceDetailsRow.nameProperty; }
        protected getService() { return PurchaseInvoiceDetailsService.baseUrl; }

        protected form : PurchaseInvoiceDetailsForm;

        constructor() {
            super();

            this.form = new PurchaseInvoiceDetailsForm(this.idPrefix);

            this.form.ProductId.changeSelect2(e => {
                var productID = Q.toId(this.form.ProductId.value);
                if (productID != null) {
                    this.form.IgstRate.value = ProductRow.getLookup().itemById[productID].Igst;
                    this.form.CgstRate.value = ProductRow.getLookup().itemById[productID].Cgst;
                    this.form.SgstRate.value = ProductRow.getLookup().itemById[productID].Sgst;
                }
            });

            this.form.ProductDetailsId.changeSelect2(e => {
                var productDetailsId = Q.toId(this.form.ProductDetailsId.value);
                 if (productDetailsId != null) {
                     this.form.PackageSize.value = ProductDetailsRow.getLookup().itemById[productDetailsId].PackageWeight.toString() + ' ' + ProductDetailsRow.getLookup().itemById[productDetailsId].ProductUnit.toString();
                     this.form.ProductValue.value = ProductDetailsRow.getLookup().itemById[productDetailsId].PurchasePrice;
                     this.form.DiscountValue.value = ProductDetailsRow.getLookup().itemById[productDetailsId].Discount;
                     
                 }
            });

            this.form.Quantity.change(e => {
                var quantity = Q.toId(this.form.Quantity.value);
                var productValue = Q.toId(this.form.ProductValue.value);
                var discountPercent = Q.toId(this.form.DiscountPercent.value);
                if (quantity != null && productValue != null && discountPercent != null) {
                    var discountValue = (productValue *  discountPercent / 100) * quantity;
                    this.form.DiscountValue.value = discountValue;
                    this.form.TaxableValue.value = productValue * quantity - discountValue;
                }
            });

            this.form.DiscountPercent.change(e => {
                var quantity = Q.toId(this.form.Quantity.value);
                var productValue = Q.toId(this.form.ProductValue.value);
                var discountPercent = Q.toId(this.form.DiscountPercent.value);
                 if (quantity != null && productValue != null && discountPercent != null) {
                     var discountValue = (productValue * discountPercent / 100) * quantity;
                     this.form.DiscountValue.value = discountValue;
                     this.form.TaxableValue.value = productValue * quantity- discountValue;
                }
            });

            this.form.ProductValue.change(e => {
                var quantity = Q.toId(this.form.Quantity.value);
                var productValue = Q.toId(this.form.ProductValue.value);
                var discountPercent = Q.toId(this.form.DiscountPercent.value);
                 if (quantity != null && productValue != null && discountPercent != null) {
                     var discountValue = (productValue * discountPercent / 100) * quantity;
                    this.form.DiscountValue.value = discountValue;
                     this.form.TaxableValue.value = productValue * quantity - discountValue;
                }
            });
            //this.form.Discount.addValidationRule(this.uniqueName, e => {
            //    var price = this.form.UnitPrice.value;
            //    var quantity = this.form.Quantity.value;
            //    var discount = this.form.Discount.value;
            //    if (price != null && quantity != null && discount != null &&
            //        discount > 0 && discount >= price * quantity) {
            //        return "Discount can't be higher than total price!";
            //    }
            //});
        }
    }
}