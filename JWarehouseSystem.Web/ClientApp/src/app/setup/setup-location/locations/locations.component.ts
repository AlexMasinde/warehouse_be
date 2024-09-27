import {ChangeDetectionStrategy, Component, OnInit} from '@angular/core';
import { FormGroup, FormControl, Validators, FormBuilder } from '@angular/forms';
import { NgbModalOptions, NgbModal, ModalDismissReasons } from '@ng-bootstrap/ng-bootstrap';
import { LookupService } from 'src/app/lookup.service';
import Swal from 'sweetalert2';
import { LocationService } from '../locations/locations.service';

@Component({
  changeDetection: ChangeDetectionStrategy.Default,
  selector: 'app-locations',
  templateUrl: './locations.component.html',
  styleUrls: ['./locations.component.scss']
})
export class LocationsComponent implements OnInit {
  locationData: any[]=[];
  location:any={};
  locationId:number=0;
  lookupRegions:any[]=[];
 //Modal
  modalOptions: NgbModalOptions= {
   backdrop: 'static'
  // size: 'md'
 };  
  closeResult: string;
  modalHeader:string="New location...";
  isSubmitted: boolean = false;
//Form
  public locationForm = new FormGroup({});
  Name = new FormControl("", Validators.required);
  Region = new FormControl("",Validators.required);
  Description = new FormControl("");

  
  constructor(fb: FormBuilder, private modalService: NgbModal,private locationService: LocationService,private lookupService: LookupService) {

   fb = new FormBuilder();
   this.locationForm = fb.group(
     {
       "Name": this.Name,
       "Region": this.Region,
       "Description": this.Description,
   
     });

   }

 ngOnInit() {

  this.loadLocations();
  this.loadLookUps();

 }
 private loadLookUps() {

  //Regions
  this.lookupService.getRegions()
    .subscribe(
      (regions: any) => {
        this.lookupRegions = regions;
        // console.log(this.job);

      }, // success path
     // error =>  this.showError(error));// error path
     );

}
 private loadLocations() {
   //Initialize user object
   this.locationService.getLocations()
     .subscribe(
       (locations: any[]) => {
         this.locationData = locations;
          // Do this to get rid of "No data available in table" message
          setTimeout(function () {
            $(function () {
              $('#location-table').DataTable();
            });
          }, 3000);

       }, // success path
        //(error) => throwError(error);// error path
        );
 }
 private setFormValues()
 {
   this.locationForm.reset();
   this.modalHeader="New Location";

   this.locationService.getLocation(this.locationId)
     .subscribe(
       (location: any) => {
         this.location = location;

        // console.log(JSON.stringify(this.location));

        if(this.location.id>0) 
        {
           this.locationForm.controls["Name"].patchValue(this.location.name);
           this.locationForm.controls["Region"].patchValue(this.location.regionID);
           this.locationForm.controls["Description"].patchValue(this.location.description);
           this.modalHeader= "Editing '" +this.location.name+ "'...";
         
          //  this.jobForm.controls["deadline"].patchValue(pipe.transform(this.job.deadline, 'yyyy-MM-dd'));
          }

       }, // success path
        //(error) => throwError(error);// error path
        );
 }

 private getFormValues() {
   
   this.location.name = this.locationForm.controls["Name"].value;
   this.location.regionID =this.locationForm.controls["Region"].value;
   this.location.description =this.locationForm.controls["Description"].value;

 }
 public submitForm(isValid: boolean) {

   if (isValid && !this.isSubmitted) {
     this.isSubmitted = true;
     this.getFormValues();
     if (this.locationId > 0) {
       this.update();
     }
     else {
       this.create();
     }

   }
 }
 private create() {
   this.locationService.create(this.location)
     .subscribe(
       (location: any) => {
         this.location = location;
         this.modalService.dismissAll('Saving');
         this.loadLocations();
         this.isSubmitted = false;
       }, // success path

       //error =>this.showError(error));// error path
       );
 }
 private update() {
   this.locationService.update(this.location, this.locationId)
     .subscribe(
       (location: any) => {
        // this.job = job;
         this.modalService.dismissAll('Saving');
          this.loadLocations();
         this.isSubmitted = false;
       }, // success path

        //(error) => throwError(error);// error path
        );
 }
 deleteLocation(id: any, location:any) {
   if (id > 0) {

     Swal.fire({
       title: "Delete '" + location.name + "' from locations list?",
       text: 'Note: item once deleted cannot be recovered.',
       type:'warning',
       showCancelButton:true,
       showCloseButton:true,
       focusCancel:true,
       confirmButtonText:"yes, delete"
   }).then((result) => {
       if (result.value) {
         this.locationService.delete(id).subscribe(
           (location: any) => {
             Swal.fire(
               'Removed!',
               'Item has been removed.',
               'success'
           )

             this.loadLocations();
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
   this.locationId=Id;
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
