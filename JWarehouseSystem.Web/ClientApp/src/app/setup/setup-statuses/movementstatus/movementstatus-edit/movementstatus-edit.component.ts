import { Component, OnInit, ChangeDetectionStrategy } from '@angular/core';
import { FormGroup, FormControl } from '@angular/forms';
import { MovementStatus } from './movementstatus';


@Component({
  changeDetection: ChangeDetectionStrategy.OnPush,
  selector: 'app-movementstatus-edit',
  templateUrl: './movementstatus-edit.component.html',
  styleUrls: ['./movementstatus-edit.component.scss']
})
export class MovementStatusEditComponent implements OnInit {

  public langs: any[];
  public orderItem: MovementStatus;
  constructor() { }

  ngOnInit() {
     this.langs = [
      'English',
      'French',
      'German',
    ];

    let orderDate : Date =new Date();
    this.orderItem = new MovementStatus(1, "XX001", "", 1, "POXX001", 1, "James Mwaniki", orderDate, "Quote22334", "Cred9000", 1, 2, 1, "CUS001", 2000);
      
  }

}
