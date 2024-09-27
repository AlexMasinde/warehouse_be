import { Component, OnInit, ChangeDetectionStrategy } from '@angular/core';
import { FormGroup, FormControl } from '@angular/forms';
import { Dock } from './dock';


@Component({
  changeDetection: ChangeDetectionStrategy.OnPush,
  selector: 'app-dock-edit',
  templateUrl: './dock-edit.component.html',
  styleUrls: ['./dock-edit.component.scss']
})
export class DockEditComponent implements OnInit {

  public langs: any[];
  public orderItem: Dock;
  constructor() { }

  ngOnInit() {
     this.langs = [
      'English',
      'French',
      'German',
    ];

    let orderDate : Date =new Date();
    this.orderItem = new Dock(1, "XX001", "", 1, "POXX001", 1, "James Mwaniki", orderDate, "Quote22334", "Cred9000", 1, 2, 1, "CUS001", 2000);
      
  }

}
