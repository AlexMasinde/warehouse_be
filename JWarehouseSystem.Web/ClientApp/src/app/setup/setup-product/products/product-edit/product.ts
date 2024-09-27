export class Product {
  constructor(
    public id: number,
    public Number:string,
    public OrderType: string,
    public AuthorizedByID: number,
    public CustomerPO: string,
    public CustomerID: number,
    public SalesPerson: string,
    public OrderDate: Date,
    public QuoteNumber: string,
    public CreditCardNumber: string,
    public ShipToAddressID: number,
    public InvoiceToAddressID: number,
    public StatusID: number,
    public CustomerNumber: string,
    public Price: number,

  ) { }
}
