import {ChangeDetectionStrategy, Component, OnInit} from '@angular/core';
import { FormGroup, FormControl, Validators, FormBuilder } from '@angular/forms';
import { NgbModalOptions, NgbModal, ModalDismissReasons } from '@ng-bootstrap/ng-bootstrap';
import { LookupService } from 'src/app/lookup.service';
import Swal from 'sweetalert2';
import { DockService } from '../docks/docks.service';
//import {NgSelectModule, NgOption} from '@ng-select/ng-select';

@Component({
  changeDetection: ChangeDetectionStrategy.Default,
  selector: 'app-docks',
  templateUrl: './docks.component.html',
  styleUrls: ['./docks.component.scss']
})
export class DocksComponent implements OnInit {
  dockData: any[]=[];
  dock:any={};
  dockId:number=0;
  lookupWarehouses:any[]=[];
  selectedWarehouseId:any=null;
 //Modal
  modalOptions: NgbModalOptions= {
   backdrop: 'static'
  // size: 'md'
 };  
  closeResult: string;
  modalHeader:string="New dock...";
  isSubmitted: boolean = false;
//Form
  public dockForm = new FormGroup({});
  Name = new FormControl("", Validators.required);
  DockType = new FormControl("",Validators.required);
  Warehouse = new FormControl("",Validators.required);
  Location = new FormControl("");
  Position = new FormControl("");
  Size = new FormControl("");
  Description = new FormControl("");
  IsActive = new FormControl(true);
  
  constructor(fb: FormBuilder, private modalService: NgbModal,private dockService: DockService,private lookupService: LookupService) {

   fb = new FormBuilder();
   this.dockForm = fb.group(
     {
       "Name": this.Name,
       "DockType": this.DockType,
       "Warehouse": this.Warehouse,
       "Location": this.Location,
       "Position": this.Position,
       "Size": this.Size,
       "Description": this.Description,
       "IsActive": this.IsActive,

   
     });

   }

 ngOnInit() {

  this.loadDocks();
 this.loadLookUps();

 }
 private loadLookUps() {

  //Locations
  this.lookupService.getWarehouses()
    .subscribe(
      (warehouses: any) => {
        this.lookupWarehouses = warehouses;
        // console.log(this.job);

      }, // success path
     // error =>  this.showError(error));// error path
     );

}
 private loadDocks() {
   //Initialize user object
   this.dockService.getDocks()
     .subscribe(
       (docks: any[]) => {
         this.dockData = docks;
          // Do this to get rid of "No data available in table" message
          setTimeout(function () {
            $(function () {
              $('#dock-table').DataTable();
            });
          }, 3000);

       }, // success path
        //(error) => throwError(error);// error path
        );
 }
 private setFormValues()
 {
   this.dockForm.reset();
   this.modalHeader="New Dock";
   this.selectedWarehouseId=null;

   this.dockService.getDock(this.dockId)
     .subscribe(
       (dock: any) => {
         this.dock = dock;

         console.log(JSON.stringify(this.dock));

        if(this.dock.id>0) 
        {
           this.selectedWarehouseId=Number(this.dock.warehouseID);
           this.dockForm.controls["Name"].patchValue(this.dock.dockName);
           this.dockForm.controls["DockType"].patchValue(this.dock.dockType);
           this.dockForm.controls["Warehouse"].patchValue(this.selectedWarehouseId);
        
           this.dockForm.controls["Location"].patchValue(this.dock.location);
           this.dockForm.controls["Position"].patchValue(this.dock.position);
           this.dockForm.controls["Size"].patchValue(this.dock.size);
           this.dockForm.controls["Description"].patchValue(this.dock.description);
           this.dockForm.controls["IsActive"].patchValue(this.dock.isActive);
           this.modalHeader= "Editing '" +this.dock.dockName+ "'...";
         
          //  this.jobForm.controls["deadline"].patchValue(pipe.transform(this.job.deadline, 'yyyy-MM-dd'));
          }

       }, // success path
        //(error) => throwError(error);// error path
        );
 }

 private getFormValues() {
   
   this.dock.dockName = this.dockForm.controls["Name"].value;
   this.dock.dockType =this.dockForm.controls["DockType"].value;
 //  this.dock.warehouseID =this.dockForm.controls["Warehouse"].value;
   this.dock.warehouseID =this.selectedWarehouseId;
   this.dock.location =this.dockForm.controls["Location"].value;
   this.dock.position =this.dockForm.controls["Position"].value;
   this.dock.size =this.dockForm.controls["Size"].value;
   this.dock.description =this.dockForm.controls["Description"].value;
   this.dock.isActive =this.dockForm.controls["IsActive"].value;

 }
 public warehouseChanged(value){
     
  console.log('selected warehouse: ' + value);

 }
 public submitForm(isValid: boolean) {

   if (isValid && !this.isSubmitted) {
     this.isSubmitted = true;
     this.getFormValues();
     if (this.dockId > 0) {
       this.update();
     }
     else {
       this.create();
     }

   }
 }
 private create() {
   this.dockService.create(this.dock)
     .subscribe(
       (dock: any) => {
         this.dock = dock;
         this.modalService.dismissAll('Saving');
         this.loadDocks();
         this.isSubmitted = false;
       }, // success path

       //error =>this.showError(error));// error path
       );
 }
 private update() {
   this.dockService.update(this.dock, this.dockId)
     .subscribe(
       (dock: any) => {
        // this.job = job;
         this.modalService.dismissAll('Saving');
          this.loadDocks();
         this.isSubmitted = false;
       }, // success path

        //(error) => throwError(error);// error path
        );
 }
 deleteDock(id: any, dock:any) {
   if (id > 0) {

     Swal.fire({
       title: "Delete '" + dock.name + "' from docks list?",
       text: 'Note: item once deleted cannot be recovered.',
       type:'warning',
       showCancelButton:true,
       showCloseButton:true,
       focusCancel:true,
       confirmButtonText:"yes, delete"
   }).then((result) => {
       if (result.value) {
         this.dockService.delete(id).subscribe(
           (dock: any) => {
             Swal.fire(
               'Removed!',
               'Item has been removed.',
               'success'
           )

             this.loadDocks();
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
   this.dockId=Id;
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
