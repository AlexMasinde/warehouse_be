import {Component, OnInit,AfterViewInit} from '@angular/core';
import {NavigationEnd, Router} from '@angular/router';
import * as Feather from 'feather-icons';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent implements OnInit, AfterViewInit {

  constructor(private router: Router) { }

  ngOnInit() {
    this.router.events.subscribe((evt) => {
    
      if (!(evt instanceof NavigationEnd)) {
        return;
      }

      if (!localStorage['authToken']) {
        this.router.navigate(['login']);
      }
     
      window.scrollTo(0, 0);
    });
  };

  ngAfterViewInit() {
    Feather.replace();
  }
}


