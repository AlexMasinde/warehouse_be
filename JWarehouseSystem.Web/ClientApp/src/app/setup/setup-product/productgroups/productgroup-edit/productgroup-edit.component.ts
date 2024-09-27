import { Component, OnInit, ChangeDetectionStrategy } from '@angular/core';
import { FormGroup, FormControl } from '@angular/forms';
import { ProductGroup } from './productgroup';


@Component({
  changeDetection: ChangeDetectionStrategy.OnPush,
  selector: 'app-productgroup-edit',
  templateUrl: './productgroup-edit.component.html',
  styleUrls: ['./productgroup-edit.component.scss']
})
export class ProductGroupEditComponent implements OnInit {

  public langs: any[];
  public orderItem: ProductGroup;
  constructor() { }

  ngOnInit() {
     this.langs = [
      'English',
      'French',
      'German',
    ];

    let orderDate : Date =new Date();
    this.orderItem = new ProductGroup(1, "XX001", "", 1, "POXX001", 1, "James Mwaniki", orderDate, "Quote22334", "Cred9000", 1, 2, 1, "CUS001", 2000);
      
  }

}
