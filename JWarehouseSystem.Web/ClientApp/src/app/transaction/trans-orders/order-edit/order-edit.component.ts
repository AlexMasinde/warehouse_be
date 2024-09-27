import { Component, OnInit, ChangeDetectionStrategy,Input, Output, EventEmitter, AfterViewInit } from '@angular/core';
import { FormGroup, FormControl, FormBuilder, Validators } from '@angular/forms';
import { Order } from './order';
import { NgbActiveModal } from '@ng-bootstrap/ng-bootstrap';
import { OrderService } from '../order.service';
import { EmployeeService } from '../../../setup/setup-people/employees/employee.service';
import { LookupService } from 'src/app/lookup.service';
@Component({
  changeDetection: ChangeDetectionStrategy.OnPush,
  selector: 'app-order-edit',
  templateUrl: './order-edit.component.html',
  styleUrls: ['./order-edit.component.scss']
})
export class OrderEditComponent implements OnInit, AfterViewInit {
 
  myform: FormGroup;
  public langs: any[];
  public authorizers:any[];
  public customers:any[];
  @Input() order: Order = new Order();
  @Input() id: number;
  @Output() myForm: EventEmitter<FormGroup> = new EventEmitter();

  Title='';
  number = new FormControl("", Validators.required);
  orderType=new FormControl("", Validators.required);
  authorizedBy=new FormControl("", Validators.required);
  customerPO=new FormControl("", Validators.required);
  customer=new FormControl("", Validators.required);
  salesPerson=new FormControl("", Validators.required);
  orderDate=new FormControl("", Validators.required);
  quoteNumber=new FormControl("", Validators.required);
  creditCardNumber=new FormControl("", Validators.required);
  shipToAddress=new FormControl("", Validators.required);
  invoiceToAddress=new FormControl("", Validators.required);
  orderStatus=new FormControl("", Validators.required);
  customerNumber=new FormControl("", Validators.required);
  price=new FormControl("", Validators.required);
  
 

  constructor(fb: FormBuilder, public activeModal: NgbActiveModal, private orderService: OrderService, private employeeService:EmployeeService,private lookupService:LookupService) {
    fb = new FormBuilder();
    this.myform = fb.group({
  "number" : this.number,
  "orderType" :this.orderType,
  "authorizedBy" :this.authorizedBy,
  "customerPO":this.customerPO,
  "customer":this.customer,
  "salesPerson":this.salesPerson,
  "orderDate":this.orderDate,
  "quoteNumber":this.quoteNumber,
  "creditCardNumber":this.creditCardNumber,
  "shipToAddress":this.shipToAddress,
  "invoiceToAddress":this.invoiceToAddress,
  "orderStatus":this.orderStatus,
  "customerNumber":this.customerNumber,
  "price":this.price,
    });
 
  }

  ngOnInit() {

    
    this.lookupService.getEmployees()
     .subscribe(
      (employees: any) => {
        this.authorizers=JSON.parse(JSON.stringify(employees));
       //  console.log(this.authorizers);
       
        }, // success path
       error => this.showError(JSON.stringify(error)) // error path
    );

    this.lookupService.getCustomers()
    .subscribe(
     (customers: any) => {
       this.customers=JSON.parse( JSON.stringify(customers));
      //  console.log(this.authorizers);
      
       }, // success path
      error => this.showError(JSON.stringify(error)) // error path
   );
      

  }
  private submitForm() {

    this.activeModal.close(this.myform.value);
    console.log("form submitted with:" + this.myform.value);
  }

  ngAfterViewInit() {
    if (this.id == 0) {
  this.Title='New Order...' ;
  this.number.setValue('');
  this.orderType.setValue('');
  this.authorizedBy.setValue('');
  this.customerPO.setValue('');
  this.customer.setValue('');
  this.salesPerson.setValue('');
  this.orderDate.setValue('');
  this.quoteNumber.setValue('');
  this.creditCardNumber.setValue('');
  this.shipToAddress.setValue('');
  this.invoiceToAddress.setValue('');
  this.orderStatus.setValue('');
  this.customerNumber.setValue('');
  this.price.setValue('');
    }
    else {
      this.Title= 'Editing Order [' + this.id + ']...';
      this.OrderInit();
    }
    
    this.myForm.emit(this.myform);
    //console.log('This is the title:' + this.Title + ' and the id:' + this.id);
  };

  OrderInit() {
    this.orderService.getOrder(this.id)
      // clone the data object, using its known Config shape
      .subscribe(
        (order: any) => {
         // this.orderItem = { ...data };
          this.number.setValue(order.number);
          this.orderType.setValue(order.orderType);
          this.authorizedBy.setValue(order.AuthorizedByID);
          this.customerPO.setValue(order.customerPO);
          this.customer.setValue(order.CustomerID);
          this.salesPerson.setValue(order.salesPerson);
          this.orderDate.setValue(order.orderDate);
          this.quoteNumber.setValue(order.quoteNumber);
          this.creditCardNumber.setValue(order.creditCardNumber);
          this.shipToAddress.setValue(order.shipToAddress);
          this.invoiceToAddress.setValue(order.invoiceToAddress);
          this.orderStatus.setValue(order.orderStatus);
          this.customerNumber.setValue(order.customerNumber);
          this.price.setValue(order.price);
         

          }, // success path
         error => this.showError( error) // error path
      );
  };

  private showError(error) {
    console.error('Show this error: '+ error);
  }

}
