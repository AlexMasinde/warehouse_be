import { Component, OnInit, ChangeDetectionStrategy } from '@angular/core';
import { FormGroup, FormControl } from '@angular/forms';
import { DeliveryRoute } from './deliveryroute';


@Component({
  changeDetection: ChangeDetectionStrategy.OnPush,
  selector: 'app-deliveryroute-edit',
  templateUrl: './deliveryroute-edit.component.html',
  styleUrls: ['./deliveryroute-edit.component.scss']
})
export class DeliveryRouteEditComponent implements OnInit {

  public langs: any[];
  public orderItem: DeliveryRoute;
  constructor() { }

  ngOnInit() {
     this.langs = [
      'English',
      'French',
      'German',
    ];

    let orderDate : Date =new Date();
    this.orderItem = new DeliveryRoute(1, "XX001", "", 1, "POXX001", 1, "James Mwaniki", orderDate, "Quote22334", "Cred9000", 1, 2, 1, "CUS001", 2000);
      
  }

}
