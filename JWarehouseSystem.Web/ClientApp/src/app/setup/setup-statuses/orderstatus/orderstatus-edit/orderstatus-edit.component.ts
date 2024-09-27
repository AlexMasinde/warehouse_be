import { Component, OnInit, ChangeDetectionStrategy } from '@angular/core';
import { FormGroup, FormControl } from '@angular/forms';
import { OrderStatus } from './orderstatus';


@Component({
  changeDetection: ChangeDetectionStrategy.OnPush,
  selector: 'app-orderstatus-edit',
  templateUrl: './orderstatus-edit.component.html',
  styleUrls: ['./orderstatus-edit.component.scss']
})
export class OrderStatusEditComponent implements OnInit {

  public langs: any[];
  public orderItem: OrderStatus;
  constructor() { }

  ngOnInit() {
     this.langs = [
      'English',
      'French',
      'German',
    ];

    let orderDate : Date =new Date();
    this.orderItem = new OrderStatus(1, "XX001", "", 1, "POXX001", 1, "James Mwaniki", orderDate, "Quote22334", "Cred9000", 1, 2, 1, "CUS001", 2000);
      
  }

}
