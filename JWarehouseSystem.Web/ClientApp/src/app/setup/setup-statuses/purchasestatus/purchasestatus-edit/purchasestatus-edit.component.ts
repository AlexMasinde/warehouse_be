import { Component, OnInit, ChangeDetectionStrategy } from '@angular/core';
import { FormGroup, FormControl } from '@angular/forms';
import { PurchaseStatus } from './purchasestatus';


@Component({
  changeDetection: ChangeDetectionStrategy.OnPush,
  selector: 'app-purchasestatus-edit',
  templateUrl: './purchasestatus-edit.component.html',
  styleUrls: ['./purchasestatus-edit.component.scss']
})
export class PurchaseStatusEditComponent implements OnInit {

  public langs: any[];
  public orderItem: PurchaseStatus;
  constructor() { }

  ngOnInit() {
     this.langs = [
      'English',
      'French',
      'German',
    ];

    let orderDate : Date =new Date();
    this.orderItem = new PurchaseStatus(1, "XX001", "", 1, "POXX001", 1, "James Mwaniki", orderDate, "Quote22334", "Cred9000", 1, 2, 1, "CUS001", 2000);
      
  }

}
