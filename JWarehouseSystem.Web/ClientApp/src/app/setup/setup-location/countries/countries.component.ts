import {ChangeDetectionStrategy, Component, ElementRef, OnInit, ViewChild} from '@angular/core';
import { NgbModal ,ModalDismissReasons, NgbModalOptions, NgbDate } from '@ng-bootstrap/ng-bootstrap';
import {CountryService} from './countries.service'
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import Swal from 'sweetalert2';
@Component({
  changeDetection: ChangeDetectionStrategy.Default,
  selector: 'app-countries',
  templateUrl: './countries.component.html',
  styleUrls: ['./countries.component.scss']
})
export class CountriesComponent implements OnInit {

   countryData: any[]=[];
   country:any={};
   countryId:number=0
  //Modal
   modalOptions: NgbModalOptions= {
    backdrop: 'static'
   // size: 'md'
  };  
   closeResult: string;
   modalHeader:string="New country...";
   isSubmitted: boolean = false;
//Form
   public countryForm = new FormGroup({});
   Name = new FormControl("", Validators.required);
   Code = new FormControl("", Validators.required);
   NumericCode = new FormControl("", Validators.required);
   
   constructor(fb: FormBuilder, private modalService: NgbModal,private countryService: CountryService) {
 
    fb = new FormBuilder();
    this.countryForm = fb.group(
      {
        "Name": this.Name,
        "Code": this.Code,
        "NumericCode": this.NumericCode,
   
      });

    }
 
  ngOnInit() {

   this.loadCountries();


  }
  private loadCountries() {
    //Initialize user object
    this.countryService.getCountries()
      .subscribe(
        (countries: any[]) => {
          this.countryData = countries;
          // Do this to get rid of "No data available in table" message
          setTimeout(function () {
            $(function () {
              $('#country-table').DataTable();
            });
          }, 3000);

        }, // success path
         //(error) => throwError(error);// error path
         );
  }
  private setFormValues()
  {
    this.countryForm.reset();
    this.modalHeader="New Country";

    this.countryService.getCountry(this.countryId)
      .subscribe(
        (country: any) => {
          this.country = country;
         if(this.country.id>0) 
         {
            this.countryForm.controls["Name"].patchValue(this.country.name);
            this.countryForm.controls["Code"].patchValue(this.country.code);
            this.countryForm.controls["NumericCode"].patchValue(this.country.numericCode);
           //  this.jobForm.controls["deadline"].patchValue(pipe.transform(this.job.deadline, 'yyyy-MM-dd'));
           }

           this.modalHeader= "Editing '" +this.country.name+ "'...";

        }, // success path
         //(error) => throwError(error);// error path
         );
  }

  private getFormValues() {
    
    this.country.name = this.countryForm.controls["Name"].value;
    this.country.code =this.countryForm.controls["Code"].value;
    this.country.numericCode =this.countryForm.controls["NumericCode"].value;
   
  }
  public submitForm(isValid: boolean) {

    if (isValid && !this.isSubmitted) {
      this.isSubmitted = true;
      this.getFormValues();
      if (this.countryId > 0) {
        this.update();
      }
      else {
        this.create();
      }

    }
  }
  private create() {
    this.countryService.create(this.country)
      .subscribe(
        (country: any) => {
          this.country = country;
          this.modalService.dismissAll('Saving');
          this.loadCountries();
          this.isSubmitted = false;
        }, // success path

        //error =>this.showError(error));// error path
        );
  }
  private update() {
    this.countryService.update(this.country, this.countryId)
      .subscribe(
        (country: any) => {
         // this.job = job;
          this.modalService.dismissAll('Saving');
           this.loadCountries();
          this.isSubmitted = false;
        }, // success path

         //(error) => throwError(error);// error path
         );
  }
  deleteJob(id: any, country:any) {
    if (id > 0) {

      Swal.fire({
        title: "Delete '" + country.name + "' from countries list?",
        text: 'Note: item once deleted cannot be recovered.',
        type:'warning',
        showCancelButton:true,
        showCloseButton:true,
        focusCancel:true,
        confirmButtonText:"yes, delete"
    }).then((result) => {
        if (result.value) {
          this.countryService.delete(id).subscribe(
            (country: any) => {
              Swal.fire(
                'Removed!',
                'Item has been removed.',
                'success'
            )

              this.loadCountries();
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
    this.countryId=Id;
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
