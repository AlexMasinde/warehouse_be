import { HttpClient, HttpErrorResponse } from "@angular/common/http";
import { Injectable, OnInit } from "@angular/core";
import { Observable, throwError } from "rxjs";
import { tap, retry, catchError } from "rxjs/operators";
import { environment } from "src/environments/environment";

@Injectable({
 providedIn:'root'
})

export class DockService implements OnInit{
    url = environment.apiBaseUrl;
  
    constructor(private http: HttpClient) {
     
    };

    ngOnInit(): void {
       
    };

 //Gets a paged list of countries
      getDocks() :Observable<any>{
        return this.http.get<any>(this.url+ 'docks',{responseType:'json'})
        
          .pipe(
             tap( // Log the result or error
              () => console.log('Docks found and returned successfully!'),
             // error =>{console.log(error)} ,
            ),
           retry(2), //retry a failed request upto 2 attempts
         
            catchError(this.handleError) //handle the error
          );
      };

      getDock(id:number) :Observable<any>{
        return this.http.get<any>(this.url+ 'docks/' + id,{responseType:'json'})
        
          .pipe(
             tap( // Log the result or error
              () => console.log('Dock found and returned successfully!' ),
             // error =>{console.log(error)} ,
            ),
           retry(2), //retry a failed request upto 2 attempts
         
            catchError(this.handleError) //handle the error
          );
      };
     
      create(dock:any) :Observable<any>{
        //console.log("Calling saving jobs...");
          return this.http.post<any>(this.url+ 'docks',dock)
        
          .pipe(
             tap( // Log the result or error
              () => console.log('Dock created and returned successfully!' ),
             // error =>{console.log(error)} ,
            ),
           retry(0), //retry a failed request upto 2 attempts
         
            catchError(this.handleError) //handle the error
          );
      };
    
      update(dock:any, id:any) :Observable<any>{
        return this.http.put<any>(this.url+ 'docks/'+ id,dock)
      
        .pipe(
           tap( // Log the result or error
            () => console.log('updated dock and returned successfully!' ),
           // error =>{console.log(error)} ,
          ),
         retry(0), //retry a failed request upto 2 attempts
       
          catchError(this.handleError) //handle the error
        );
    };
    delete(id:any) :Observable<any>{
        //console.log("Calling saving jobs...");
          return this.http.delete<any>(this.url+ 'docks/' + id)
        
          .pipe(
             tap( // Log the result or error
              () => console.log('deleted dock successfully!' ),
             // error =>{console.log(error)} ,
            ),
           retry(0), //retry a failed request upto 2 attempts
         
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

