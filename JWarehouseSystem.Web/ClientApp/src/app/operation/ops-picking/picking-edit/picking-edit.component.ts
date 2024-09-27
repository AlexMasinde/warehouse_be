import { Component, OnInit, ChangeDetectionStrategy } from '@angular/core';
import { FormGroup, FormControl } from '@angular/forms';
import { Picking } from './picking';


@Component({
  changeDetection: ChangeDetectionStrategy.OnPush,
  selector: 'app-picking-edit',
  templateUrl: './picking-edit.component.html',
  styleUrls: ['./picking-edit.component.scss']
})
export class PickingEditComponent implements OnInit {

  public langs: any[];
  public orderItem: Picking;
  constructor() { }

  ngOnInit() {
     this.langs = [
      'English',
      'French',
      'German',
    ];

    let orderDate : Date =new Date();
    this.orderItem = new Picking(1, "XX001", "", 1, "POXX001", 1, "James Mwaniki", orderDate, "Quote22334", "Cred9000", 1, 2, 1, "CUS001", 2000);
      
  }

}
