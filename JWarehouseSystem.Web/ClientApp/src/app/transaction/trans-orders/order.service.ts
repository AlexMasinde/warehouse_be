import { Injectable, OnInit, Inject } from '@angular/core';
import { environment } from '../../../environments/environment';
import { HttpClient, HttpErrorResponse, HttpHeaders, HttpParams } from '@angular/common/http';
import { catchError, retry } from 'rxjs/operators';
import { throwError } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class OrderService implements OnInit {
  url = environment.apiBaseUrl;
 
    constructor(private http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
      //  this.url = baseUrl ;
    };

  ngOnInit() {
   
  
  };

    getOrder(id: number) {
        let param:string =  id!=null?id.toString():'0';
        const params = new HttpParams()
            .set('id', param);
           /*  var mheaders = new HttpHeaders();
            mheaders.append('Access-Control-Allow-Origin', 'https://localhost:44367/'); */
           // , {headers: mheaders}
            
        return this.http.get<any>(this.url+ 'orders/'+ id)
      .pipe(
        retry(2), //retry a failed request upto 2 attempts
        catchError(this.handleError) //handle the error
      );
  };
   
  getOrders() {
   
    return this.http.get<any>(this.url+ 'orders')
      .pipe(
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
      console.error( `Backend returned code ${error.status}, ` + `body was: ${error.error}`);
    }
    // return an observable with a user-facing error message
    return throwError( 'Something bad happened; please try again later.');
  };
}
