import {ChangeDetectionStrategy, Component, OnInit} from '@angular/core';
import { FormGroup, FormControl, Validators, FormBuilder } from '@angular/forms';
import { NgbModalOptions, NgbModal, ModalDismissReasons } from '@ng-bootstrap/ng-bootstrap';
import Swal from 'sweetalert2';
import { RegionService } from '../regions/regions.service';

@Component({
  changeDetection: ChangeDetectionStrategy.Default,
  selector: 'app-regions',
  templateUrl: './regions.component.html',
  styleUrls: ['./regions.component.scss']
})
export class RegionsComponent implements OnInit {

  regionData: any[]=[];
  region:any={};
  regionId:number=0
 //Modal
  modalOptions: NgbModalOptions= {
   backdrop: 'static'
  // size: 'md'
 };  
  closeResult: string;
  modalHeader:string="New region...";
  isSubmitted: boolean = false;
//Form
  public regionForm = new FormGroup({});
  Name = new FormControl("", Validators.required);
  Description = new FormControl("");

  
  constructor(fb: FormBuilder, private modalService: NgbModal,private regionService: RegionService) {

   fb = new FormBuilder();
   this.regionForm = fb.group(
     {
       "Name": this.Name,
       "Description": this.Description,
   
     });

   }

 ngOnInit() {

  this.loadRegions();

 }
 private loadRegions() {
   //Initialize user object
   this.regionService.getRegions()
     .subscribe(
       (regions: any[]) => {
         this.regionData = regions;
           // Do this to get rid of "No data available in table" message
           setTimeout(function () {
            $(function () {
              $('#region-table').DataTable();
            });
          }, 3000);

       }, // success path
        //(error) => throwError(error);// error path
        );
 }
 private setFormValues()
 {
   this.regionForm.reset();
   this.modalHeader="New Region";

   this.regionService.getRegion(this.regionId)
     .subscribe(
       (region: any) => {
         this.region = region;
        if(this.region.id>0) 
        {
           this.regionForm.controls["Name"].patchValue(this.region.name);
           this.regionForm.controls["Description"].patchValue(this.region.description);
           this.modalHeader= "Editing '" +this.region.name+ "'...";
          //  this.jobForm.controls["deadline"].patchValue(pipe.transform(this.job.deadline, 'yyyy-MM-dd'));
          }

       }, // success path
        //(error) => throwError(error);// error path
        );
 }

 private getFormValues() {
   
   this.region.name = this.regionForm.controls["Name"].value;
   this.region.description =this.regionForm.controls["Description"].value;

 }
 public submitForm(isValid: boolean) {

   if (isValid && !this.isSubmitted) {
     this.isSubmitted = true;
     this.getFormValues();
     if (this.regionId > 0) {
       this.update();
     }
     else {
       this.create();
     }

   }
 }
 private create() {
   this.regionService.create(this.region)
     .subscribe(
       (region: any) => {
         this.region = region;
         this.modalService.dismissAll('Saving');
         this.loadRegions();
         this.isSubmitted = false;
       }, // success path

       //error =>this.showError(error));// error path
       );
 }
 private update() {
   this.regionService.update(this.region, this.regionId)
     .subscribe(
       (region: any) => {
        // this.job = job;
         this.modalService.dismissAll('Saving');
          this.loadRegions();
         this.isSubmitted = false;
       }, // success path

        //(error) => throwError(error);// error path
        );
 }
 deleteJob(id: any, region:any) {
   if (id > 0) {

     Swal.fire({
       title: "Delete '" + region.name + "' from regions list?",
       text: 'Note: item once deleted cannot be recovered.',
       type:'warning',
       showCancelButton:true,
       showCloseButton:true,
       focusCancel:true,
       confirmButtonText:"yes, delete"
   }).then((result) => {
       if (result.value) {
         this.regionService.delete(id).subscribe(
           (region: any) => {
             Swal.fire(
               'Removed!',
               'Item has been removed.',
               'success'
           )

             this.loadRegions();
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
   this.regionId=Id;
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
