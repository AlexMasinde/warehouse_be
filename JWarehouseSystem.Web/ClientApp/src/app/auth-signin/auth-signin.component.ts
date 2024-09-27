import { Component, OnInit } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router';
import { FormControl, FormBuilder, FormGroup, Validators } from '@angular/forms';
import { first, window } from 'rxjs/operators';
import { CustomValidators } from 'ng2-validation';


//import { AuthenticationService } from '../_services';

@Component({
  selector: 'app-root',
  templateUrl: './auth-signin.component.html',
  styleUrls: ['./auth-signin.component.scss']
})
export class AuthSigninComponent implements OnInit {
  loginForm: FormGroup;
  form: any;
  loading = false;
  public isSubmit: boolean;
  returnUrl: string;
  error = '';

  constructor(
    private formBuilder: FormBuilder,
    private route: ActivatedRoute,
    private router: Router) {

    const password = new FormControl('', Validators.required);
    const email = new FormControl('', [Validators.required, Validators.email]);
    this.isSubmit = false;
    // const rpassword = new FormControl('', [Validators.required, CustomValidators.equalTo(password)]);
    this.loginForm = new FormGroup({

      email: email,
      password: password,
      //  rpassword: rpassword

    });

  }
  // private authenticationService: AuthenticationService)  { }

  ngOnInit() {
    document.querySelector('body').setAttribute('themebg-pattern', 'theme1');
    //this.loginForm = this.formBuilder.group({
    //  email: ['', Validators.required],
    //  password: ['', Validators.required]
    //});


    // reset login status
    //   this.authenticationService.logout();

    // get return url from route parameters or default to '/'
    this.returnUrl = this.route.snapshot.queryParams['returnUrl'] || '/';

  }

  // convenience getter for easy access to form fields
  get f() { return this.loginForm.controls; }

  onSubmit() {
    this.isSubmit = true;

    // stop here if form is invalid
    if (this.loginForm.invalid) {
      return;
    }

    this.loading = true;
    //this.authenticationService.login(this.f.username.value, this.f.password.value)
    //  .pipe(first())
    //  .subscribe(
    //    data => {
    //      this.router.navigate([this.returnUrl]);
    //    },
    //    error => {
    //      this.error = error;
    //      this.loading = false;
    //    });
  }

  save(form: any) {
    console.log('Login button clicked:' + form.valid);

    if (!form.valid) {
      this.isSubmit = true;
      return;
    }
    localStorage['authToken'] = true;
    this.router.navigate(['']);
  }

  loginClick() {
    console.log('Login button clicked');
  }

}
