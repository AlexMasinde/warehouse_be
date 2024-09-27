import { Injectable, OnInit, Inject } from '@angular/core';
import { environment } from "src/environments/environment";
import { HttpClient, HttpErrorResponse, HttpParams } from '@angular/common/http';
import { catchError, retry, tap } from 'rxjs/operators';
import { Observable, throwError } from 'rxjs';

@Injectable({
  providedIn: 'root'
})

export class LookupService implements OnInit {
  url = environment.apiBaseUrl;
 
 
    constructor(private http: HttpClient) {
     
    };

  ngOnInit() {
   
  
  };  
  getRegions() :Observable<any>{
    return this.http.get<any>(this.url+ 'lookup/regions',{responseType:'json'})
    
      .pipe(
         tap( // Log the result or error
          () => console.log('Region lookup found and returned successfully!' ),
         // error =>{console.log(error)} ,
        ),
       retry(2), //retry a failed request upto 2 attempts
     
        catchError(this.handleError) //handle the error
      );
  };
  getLocations() :Observable<any>{
    return this.http.get<any>(this.url+ 'lookup/locations',{responseType:'json'})
    
      .pipe(
         tap( // Log the result or error
          () => console.log('Location Lookup found and returned successfully!' ),
         // error =>{console.log(error)} ,
        ),
       retry(2), //retry a failed request upto 2 attempts
     
        catchError(this.handleError) //handle the error
      );
  };
  getCountries() :Observable<any>{
    return this.http.get<any>(this.url+ 'lookup/countries',{responseType:'json'})
    
      .pipe(
         tap( // Log the result or error
          () => console.log('Country Lookup found and returned successfully!' ),
         // error =>{console.log(error)} ,
        ),
       retry(2), //retry a failed request upto 2 attempts
     
        catchError(this.handleError) //handle the error
      );
  };
  getCurrencies() :Observable<any>{
    return this.http.get<any>(this.url+ 'lookup/currencies',{responseType:'json'})
    
      .pipe(
         tap( // Log the result or error
          () => console.log('Currencies Lookup found and returned successfully!' ),
         // error =>{console.log(error)} ,
        ),
       retry(2), //retry a failed request upto 2 attempts
     
        catchError(this.handleError) //handle the error
      );
  };
  getEmployees() :Observable<any>{
    return this.http.get<any>(this.url+ 'lookup/employees',{responseType:'json'})
    
      .pipe(
         tap( // Log the result or error
          () => console.log('Employees Lookup found and returned successfully!' ),
         // error =>{console.log(error)} ,
        ),
       retry(2), //retry a failed request upto 2 attempts
     
        catchError(this.handleError) //handle the error
      );
  };
  getCustomers() :Observable<any>{
    return this.http.get<any>(this.url+ 'lookup/customers',{responseType:'json'})
    
      .pipe(
         tap( // Log the result or error
          () => console.log('Customers Lookup found and returned successfully!' ),
         // error =>{console.log(error)} ,
        ),
       retry(2), //retry a failed request upto 2 attempts
     
        catchError(this.handleError) //handle the error
      );
  };
  getWarehouses() :Observable<any>{
    return this.http.get<any>(this.url+ 'lookup/warehouses',{responseType:'json'})
    
      .pipe(
         tap( // Log the result or error
          () => console.log('Warehouses Lookup found and returned successfully!' ),
         // error =>{console.log(error)} ,
        ),
       retry(2), //retry a failed request upto 2 attempts
     
        catchError(this.handleError) //handle the error
      );
  };
  private handleError(error: HttpErrorResponse) {
    if (error.error instanceof ErrorEvent) {
      // A client-side or network error occurred. Handle it accordingly.
     // console.error('An error occurred:', error.message);
     return throwError(error);
    }
    else
    {
      // The backend returned an unsuccessful response code.
      // The response body may contain clues as to what went wrong,
      //console.error( `Backend returned code ${error.status}, ` + 'body was: ' + JSON.stringify(error.error));
     return throwError(error);
    }
    // return an observable with a user-facing error message
    return throwError( 'Something bad happened; please try again later.');
  };
}
