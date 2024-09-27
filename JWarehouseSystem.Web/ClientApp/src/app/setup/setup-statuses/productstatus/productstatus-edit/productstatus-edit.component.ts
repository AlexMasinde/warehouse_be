import { Component, OnInit, ChangeDetectionStrategy } from '@angular/core';
import { FormGroup, FormControl } from '@angular/forms';
import { ProductStatus } from './productstatus';


@Component({
  changeDetection: ChangeDetectionStrategy.OnPush,
  selector: 'app-productstatus-edit',
  templateUrl: './productstatus-edit.component.html',
  styleUrls: ['./productstatus-edit.component.scss']
})
export class ProductStatusEditComponent implements OnInit {

  public langs: any[];
  public orderItem: ProductStatus;
  constructor() { }

  ngOnInit() {
     this.langs = [
      'English',
      'French',
      'German',
    ];

    let orderDate : Date =new Date();
    this.orderItem = new ProductStatus(1, "XX001", "", 1, "POXX001", 1, "James Mwaniki", orderDate, "Quote22334", "Cred9000", 1, 2, 1, "CUS001", 2000);
      
  }

}
