"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var Order = /** @class */ (function () {
    function Order() {
        this.id = 0;
        this.Number = '';
        this.OrderType = '';
        this.AuthorizedByID = 0;
        this.CustomerPO = '';
        this.CustomerID = 0;
        this.SalesPerson = '';
        this.OrderDate = new Date();
        this.QuoteNumber = '';
        this.CreditCardNumber = '';
        this.ShipToAddressID = 0;
        this.InvoiceToAddressID = 0;
        this.StatusID = 0;
        this.CustomerNumber = '';
        this.Price = 0;
    }
    return Order;
}());
exports.Order = Order;
//# sourceMappingURL=order.js.map