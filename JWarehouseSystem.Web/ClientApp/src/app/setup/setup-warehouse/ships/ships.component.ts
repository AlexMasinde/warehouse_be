import {ChangeDetectionStrategy, Component, OnInit} from '@angular/core';
import { FormGroup, FormControl, Validators, FormBuilder } from '@angular/forms';
import { NgbModalOptions, NgbModal, ModalDismissReasons } from '@ng-bootstrap/ng-bootstrap';
import { LookupService } from 'src/app/lookup.service';
import Swal from 'sweetalert2';
import { ShipService } from '../ships/ships.service';



@Component({
  changeDetection: ChangeDetectionStrategy.Default,
  selector: 'app-ships',
  templateUrl: './ships.component.html',
  styleUrls: ['./ships.component.scss']
})
export class ShipsComponent implements OnInit {
  shipData: any[]=[];
  ship:any={};
  shipId:number=0;
  lookupLocations:any[]=[];
 //Modal
  modalOptions: NgbModalOptions= {
   backdrop: 'static'
  // size: 'md'
 };  
  closeResult: string;
  modalHeader:string="New ship...";
  isSubmitted: boolean = false;
//Form
  public shipForm = new FormGroup({});
  Name = new FormControl("", Validators.required);
  Code = new FormControl("",Validators.required);
  OtherDetails = new FormControl("");
  Capacity = new FormControl("");

  
  constructor(fb: FormBuilder, private modalService: NgbModal,private shipService: ShipService,private lookupService: LookupService) {

   fb = new FormBuilder();
   this.shipForm = fb.group(
     {
       "Name": this.Name,
       "Code": this.Code,
       "OtherDetails": this.OtherDetails,
       "Capacity": this.Capacity,
   
     });

   }

 ngOnInit() {

  this.loadShips();
 // this.loadLookUps();

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
 private loadShips() {
   //Initialize user object
   this.shipService.getShips()
     .subscribe(
       (ships: any[]) => {
         this.shipData = ships;
          // Do this to get rid of "No data available in table" message
          setTimeout(function () {
            $(function () {
              $('#ship-table').DataTable();
            });
          }, 3000);

       }, // success path
        //(error) => throwError(error);// error path
        );
 }
 private setFormValues()
 {
   this.shipForm.reset();
   this.modalHeader="New Ship";

   this.shipService.getShip(this.shipId)
     .subscribe(
       (ship: any) => {
         this.ship = ship;

         console.log(JSON.stringify(this.ship));

        if(this.ship.id>0) 
        {
           this.shipForm.controls["Name"].patchValue(this.ship.shipName);
           this.shipForm.controls["Code"].patchValue(this.ship.shipCode);
           this.shipForm.controls["OtherDetails"].patchValue(this.ship.otherDetails);
           this.shipForm.controls["Capacity"].patchValue(this.ship.capacity);
           this.modalHeader= "Editing '" +this.ship.shipName+ "'...";
         
          //  this.jobForm.controls["deadline"].patchValue(pipe.transform(this.job.deadline, 'yyyy-MM-dd'));
          }

       }, // success path
        //(error) => throwError(error);// error path
        );
 }

 private getFormValues() {
   
   this.ship.shipName = this.shipForm.controls["Name"].value;
   this.ship.shipCode =this.shipForm.controls["Code"].value;
   this.ship.otherDetails =this.shipForm.controls["OtherDetails"].value;
   this.ship.capacity =this.shipForm.controls["Capacity"].value;

 }
 public submitForm(isValid: boolean) {

   if (isValid && !this.isSubmitted) {
     this.isSubmitted = true;
     this.getFormValues();
     if (this.shipId > 0) {
       this.update();
     }
     else {
       this.create();
     }

   }
 }
 private create() {
   this.shipService.create(this.ship)
     .subscribe(
       (ship: any) => {
         this.ship = ship;
         this.modalService.dismissAll('Saving');
         this.loadShips();
         this.isSubmitted = false;
       }, // success path

       //error =>this.showError(error));// error path
       );
 }
 private update() {
   this.shipService.update(this.ship, this.shipId)
     .subscribe(
       (ship: any) => {
        // this.job = job;
         this.modalService.dismissAll('Saving');
          this.loadShips();
         this.isSubmitted = false;
       }, // success path

        //(error) => throwError(error);// error path
        );
 }
 deleteShip(id: any, ship:any) {
   if (id > 0) {

     Swal.fire({
       title: "Delete '" + ship.name + "' from ships list?",
       text: 'Note: item once deleted cannot be recovered.',
       type:'warning',
       showCancelButton:true,
       showCloseButton:true,
       focusCancel:true,
       confirmButtonText:"yes, delete"
   }).then((result) => {
       if (result.value) {
         this.shipService.delete(id).subscribe(
           (ship: any) => {
             Swal.fire(
               'Removed!',
               'Item has been removed.',
               'success'
           )

             this.loadShips();
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
   this.shipId=Id;
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
