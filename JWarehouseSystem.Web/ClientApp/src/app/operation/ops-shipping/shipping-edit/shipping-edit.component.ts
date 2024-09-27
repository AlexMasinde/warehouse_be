import { Component, OnInit, ChangeDetectionStrategy } from '@angular/core';
import { FormGroup, FormControl } from '@angular/forms';
import { Shipping } from './shipping';


@Component({
  changeDetection: ChangeDetectionStrategy.OnPush,
  selector: 'app-shipping-edit',
  templateUrl: './shipping-edit.component.html',
  styleUrls: ['./shipping-edit.component.scss']
})
export class ShippingEditComponent implements OnInit {

  public langs: any[];
  public orderItem: Shipping;
  constructor() { }

  ngOnInit() {
     this.langs = [
      'English',
      'French',
      'German',
    ];

    let orderDate : Date =new Date();
     this.orderItem = new Shipping(1, "XX001", "", 1, "POXX001", 1, "James Mwaniki", orderDate, "Quote22334", "Cred9000", 1, 2, 1, "CUS001", 2000);
      
  }

}
