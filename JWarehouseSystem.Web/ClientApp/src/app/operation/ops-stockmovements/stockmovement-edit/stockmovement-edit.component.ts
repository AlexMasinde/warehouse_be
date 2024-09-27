import { Component, OnInit, ChangeDetectionStrategy } from '@angular/core';
import { FormGroup, FormControl } from '@angular/forms';
import { StockMovement } from './stockmovement';


@Component({
  changeDetection: ChangeDetectionStrategy.OnPush,
  selector: 'app-stockmovement-edit',
  templateUrl: './stockmovement-edit.component.html',
  styleUrls: ['./stockmovement-edit.component.scss']
})
export class StockMovementEditComponent implements OnInit {

  public langs: any[];
  public orderItem: StockMovement;
  constructor() { }

  ngOnInit() {
     this.langs = [
      'English',
      'French',
      'German',
    ];

    let orderDate : Date =new Date();
    this.orderItem = new StockMovement(1, "XX001", "", 1, "POXX001", 1, "James Mwaniki", orderDate, "Quote22334", "Cred9000", 1, 2, 1, "CUS001", 2000);
      
  }

}
