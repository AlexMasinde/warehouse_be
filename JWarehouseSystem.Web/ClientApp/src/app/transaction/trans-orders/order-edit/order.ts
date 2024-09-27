export class Order {
  id: number;
  Number: string;
  OrderType: string;
  AuthorizedByID: number;
  CustomerPO: string;
  CustomerID: number;
  SalesPerson: string;
  OrderDate: Date;
  QuoteNumber: string;
  CreditCardNumber: string;
  ShipToAddressID: number;
  InvoiceToAddressID: number;
  StatusID: number;
  CustomerNumber: string;
  Price: number;

  constructor() {
    this.id= 0;
    this. Number= '';
    this.OrderType= '';
    this.AuthorizedByID= 0;
    this. CustomerPO= '';
    this.CustomerID= 0;
    this. SalesPerson= '';
    this. OrderDate= new Date();
    this.QuoteNumber= '';
    this. CreditCardNumber= '';
    this. ShipToAddressID= 0;
    this.InvoiceToAddressID= 0;
    this.StatusID= 0;
    this. CustomerNumber= '';
    this.Price= 0;
  }
  
}
