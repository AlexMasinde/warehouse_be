import {ChangeDetectionStrategy, Component, OnInit} from '@angular/core';
import { FormGroup, FormControl, Validators, FormBuilder } from '@angular/forms';
import { NgbModalOptions, NgbModal, ModalDismissReasons } from '@ng-bootstrap/ng-bootstrap';
import { LookupService } from 'src/app/lookup.service';
import Swal from 'sweetalert2';
import { WarehouseService } from '../warehouses/warehouses.service';

@Component({
  changeDetection: ChangeDetectionStrategy.Default,
  selector: 'app-warehouses',
  templateUrl: './warehouses.component.html',
  styleUrls: ['./warehouses.component.scss']
})
export class WarehousesComponent implements OnInit {
  warehouseData: any[]=[];
  warehouse:any={};
  warehouseId:number=0;
  lookupLocations:any[]=[];
 //Modal
  modalOptions: NgbModalOptions= {
   backdrop: 'static'
  // size: 'md'
 };  
  closeResult: string;
  modalHeader:string="New warehouse...";
  isSubmitted: boolean = false;
//Form
  public warehouseForm = new FormGroup({});
  Name = new FormControl("", Validators.required);
  Location = new FormControl("",Validators.required);
  Description = new FormControl("");

  
  constructor(fb: FormBuilder, private modalService: NgbModal,private warehouseService: WarehouseService,private lookupService: LookupService) {

   fb = new FormBuilder();
   this.warehouseForm = fb.group(
     {
       "Name": this.Name,
       "Location": this.Location,
       "Description": this.Description,
   
     });

   }

 ngOnInit() {

  this.loadWarehouses();
  this.loadLookUps();

 }
 private loadLookUps() {

  //Locations
  this.lookupService.getLocations()
    .subscribe(
      (locations: any) => {
        this.lookupLocations = locations;
        // console.log(this.job);

      }, // success path
     // error =>  this.showError(error));// error path
     );

}
 private loadWarehouses() {
   //Initialize user object
   this.warehouseService.getWarehouses()
     .subscribe(
       (warehouses: any[]) => {
         this.warehouseData = warehouses;
          // Do this to get rid of "No data available in table" message
          setTimeout(function () {
            $(function () {
              $('#warehouse-table').DataTable();
            });
          }, 3000);

       }, // success path
        //(error) => throwError(error);// error path
        );
 }
 private setFormValues()
 {
   this.warehouseForm.reset();
   this.modalHeader="New Warehouse";

   this.warehouseService.getWarehouse(this.warehouseId)
     .subscribe(
       (warehouse: any) => {
         this.warehouse = warehouse;

        // console.log(JSON.stringify(this.warehouse));

        if(this.warehouse.id>0) 
        {
           this.warehouseForm.controls["Name"].patchValue(this.warehouse.name);
           this.warehouseForm.controls["Location"].patchValue(this.warehouse.locationID);
           this.warehouseForm.controls["Description"].patchValue(this.warehouse.description);
           this.modalHeader= "Editing '" +this.warehouse.name+ "'...";
         
          //  this.jobForm.controls["deadline"].patchValue(pipe.transform(this.job.deadline, 'yyyy-MM-dd'));
          }

       }, // success path
        //(error) => throwError(error);// error path
        );
 }

 private getFormValues() {
   
   this.warehouse.name = this.warehouseForm.controls["Name"].value;
   this.warehouse.locationID =this.warehouseForm.controls["Location"].value;
   this.warehouse.description =this.warehouseForm.controls["Description"].value;

 }
 public submitForm(isValid: boolean) {

   if (isValid && !this.isSubmitted) {
     this.isSubmitted = true;
     this.getFormValues();
     if (this.warehouseId > 0) {
       this.update();
     }
     else {
       this.create();
     }

   }
 }
 private create() {
   this.warehouseService.create(this.warehouse)
     .subscribe(
       (warehouse: any) => {
         this.warehouse = warehouse;
         this.modalService.dismissAll('Saving');
         this.loadWarehouses();
         this.isSubmitted = false;
       }, // success path

       //error =>this.showError(error));// error path
       );
 }
 private update() {
   this.warehouseService.update(this.warehouse, this.warehouseId)
     .subscribe(
       (warehouse: any) => {
        // this.job = job;
         this.modalService.dismissAll('Saving');
          this.loadWarehouses();
         this.isSubmitted = false;
       }, // success path

        //(error) => throwError(error);// error path
        );
 }
 deleteWarehouse(id: any, warehouse:any) {
   if (id > 0) {

     Swal.fire({
       title: "Delete '" + warehouse.name + "' from warehouses list?",
       text: 'Note: item once deleted cannot be recovered.',
       type:'warning',
       showCancelButton:true,
       showCloseButton:true,
       focusCancel:true,
       confirmButtonText:"yes, delete"
   }).then((result) => {
       if (result.value) {
         this.warehouseService.delete(id).subscribe(
           (warehouse: any) => {
             Swal.fire(
               'Removed!',
               'Item has been removed.',
               'success'
           )

             this.loadWarehouses();
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
   this.warehouseId=Id;
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
