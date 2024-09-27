import {ChangeDetectionStrategy, Component, OnInit} from '@angular/core';
import { FormGroup, FormControl, Validators, FormBuilder } from '@angular/forms';
import { NgbModalOptions, NgbModal, ModalDismissReasons } from '@ng-bootstrap/ng-bootstrap';
import Swal from 'sweetalert2';
import { CurrencyService } from './currencies.service';

@Component({
  changeDetection: ChangeDetectionStrategy.Default,
  selector: 'app-currencies',
  templateUrl: './currencies.component.html',
  styleUrls: ['./currencies.component.scss']
})
export class CurrenciesComponent implements OnInit {
  currencyData: any[]=[];
  currency:any={};
  currencyId:number=0
 //Modal
  modalOptions: NgbModalOptions= {
   backdrop: 'static'
  // size: 'md'
 };  
  closeResult: string;
  modalHeader:string="New currency...";
  isSubmitted: boolean = false;
//Form
  public currencyForm = new FormGroup({});
  Name = new FormControl("", Validators.required);
  Code = new FormControl("",Validators.required);
  Number = new FormControl("",Validators.required);

  
  constructor(fb: FormBuilder, private modalService: NgbModal,private currencyService: CurrencyService) {

   fb = new FormBuilder();
   this.currencyForm = fb.group(
     {
       "Name": this.Name,
       "Code": this.Code,
       "Number": this.Number,
   
     });

   }

 ngOnInit() {

  this.loadCurrencies();

 }
 private loadCurrencies() {
   //Initialize user object
   this.currencyService.getCurrencies()
     .subscribe(
       (currencies: any[]) => {
         this.currencyData = currencies;
          // Do this to get rid of "No data available in table" message
          setTimeout(function () {
            $(function () {
              $('#currency-table').DataTable();
            });
          }, 3000);

       }, // success path
        //(error) => throwError(error);// error path
        );
 }
 private setFormValues()
 {
   this.currencyForm.reset();
   this.modalHeader="New Currency";

   this.currencyService.getCurrency(this.currencyId)
     .subscribe(
       (currency: any) => {
         this.currency = currency;
        if(this.currency.id>0) 
        {
           this.currencyForm.controls["Name"].patchValue(this.currency.name);
           this.currencyForm.controls["Code"].patchValue(this.currency.code);
           this.currencyForm.controls["Number"].patchValue(this.currency.number);
           this.modalHeader= "Editing '" +this.currency.name+ "'...";
          //  this.jobForm.controls["deadline"].patchValue(pipe.transform(this.job.deadline, 'yyyy-MM-dd'));
          }

       }, // success path
        //(error) => throwError(error);// error path
        );
 }

 private getFormValues() {
   
   this.currency.name = this.currencyForm.controls["Name"].value;
   this.currency.code =this.currencyForm.controls["Code"].value;
   this.currency.number =this.currencyForm.controls["Number"].value;

 }
 public submitForm(isValid: boolean) {

   if (isValid && !this.isSubmitted) {
     this.isSubmitted = true;
     this.getFormValues();
     if (this.currencyId > 0) {
       this.update();
     }
     else {
       this.create();
     }

   }
 }
 private create() {
   this.currencyService.create(this.currency)
     .subscribe(
       (currency: any) => {
         this.currency = currency;
         this.modalService.dismissAll('Saving');
         this.loadCurrencies();
         this.isSubmitted = false;
       }, // success path

       //error =>this.showError(error));// error path
       );
 }
 private update() {
   this.currencyService.update(this.currency, this.currencyId)
     .subscribe(
       (currency: any) => {
        // this.job = job;
         this.modalService.dismissAll('Saving');
          this.loadCurrencies();
         this.isSubmitted = false;
       }, // success path

        //(error) => throwError(error);// error path
        );
 }
 deleteCurrency(id: any, currency:any) {
   if (id > 0) {

     Swal.fire({
       title: "Delete '" + currency.name + "' from currencies list?",
       text: 'Note: item once deleted cannot be recovered.',
       type:'warning',
       showCancelButton:true,
       showCloseButton:true,
       focusCancel:true,
       confirmButtonText:"yes, delete"
   }).then((result) => {
       if (result.value) {
         this.currencyService.delete(id).subscribe(
           (currency: any) => {
             Swal.fire(
               'Removed!',
               'Item has been removed.',
               'success'
           )

             this.loadCurrencies();
           }, // success path
   
         //  (error) => this.showError(error));// error path
         );
    
       } else if (result.dismiss === Swal.DismissReason.cancel) {
          return;
          /*  Swal.fire(
               'Cancelled',
               'Sorry to see you go.)',
               'error'
           ) */
       }
   })

   }
 }
 open(content, Id: any) {
   this.currencyId=Id;
    this.setFormValues();

   this.modalService.open(content, this.modalOptions).result.then((result) => {
     this.closeResult = 'Closed with: ${result}';
   }, (reason) => {
     this.closeResult = 'Dismissed ${this.getDismissReason(reason)}';
   });
 };

 private getDismissReason(reason: any): string {
   if (reason === ModalDismissReasons.ESC) {
     return 'by pressing ESC';
   } else if (reason === ModalDismissReasons.BACKDROP_CLICK) {
     return 'by clicking on a backdrop';
   } else {
     return `with: ${reason}`;
   }
 }
 

}
