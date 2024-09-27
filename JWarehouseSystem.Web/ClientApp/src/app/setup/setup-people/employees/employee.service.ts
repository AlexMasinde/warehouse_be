import { Injectable, OnInit, Inject } from '@angular/core';
import { environment } from '../../../../environments/environment';
import { HttpClient, HttpErrorResponse, HttpParams } from '@angular/common/http';
import { catchError, retry, tap } from 'rxjs/operators';
import { Observable, throwError } from 'rxjs';

/* export const contentHeaders = new Headers();
contentHeaders.append('Accept', 'application/json');
contentHeaders.append('Content-Type', 'application/json'); */

@Injectable({
  providedIn: 'root'
})

export class EmployeeService implements OnInit {
  url = environment.apiBaseUrl;
 
 
    constructor(private http: HttpClient) {
     
    };

  ngOnInit() {
   
  
  };

    getEmployee(id: number) {
        let param:string =  id!=null?id.toString():'0';
            
        return this.http.get<any>(this.url+ 'employees/'+ id)
      .pipe(
        retry(2), //retry a failed request upto 2 attempts
        catchError(this.handleError) //handle the error
      );
  };
 
  //(this.url+ 'employees',{headers: new HttpHeaders({'Content-Type': 'application/json','Accept': 'application/json' })  })
  getEmployees() :Observable<any>{
    return this.http.get<any>(this.url+ 'employees',{responseType:'json'})
    
      .pipe(
         tap( // Log the result or error
          () => console.log('data found and returned successfully!'),
         // error =>{console.log(error)} ,
        ),
       retry(2), //retry a failed request upto 2 attempts
     
        catchError(this.handleError) //handle the error
      );
  };
  getAuthorizers() :Observable<any>{
    return this.http.get<any>(this.url+ 'lookup/authorizers',{responseType:'json'})
    
      .pipe(
         tap( // Log the result or error
          () => console.log('Lookup found and returned successfully!'),
         // error =>{console.log(error)} ,
        ),
       retry(2), //retry a failed request upto 2 attempts
     
        catchError(this.handleError) //handle the error
      );
  };


  private handleError(error: HttpErrorResponse) {
    if (error.error instanceof ErrorEvent) {
      // A client-side or network error occurred. Handle it accordingly.
      console.error('An error occurred:', error.message);
    }
    else
    {
      // The backend returned an unsuccessful response code.
      // The response body may contain clues as to what went wrong,
      console.error( `Backend returned code ${error.status}, ` + 'body was: ' + JSON.stringify(error.error));
    }
    // return an observable with a user-facing error message
    return throwError( 'Something bad happened; please try again later.');
  };
}
