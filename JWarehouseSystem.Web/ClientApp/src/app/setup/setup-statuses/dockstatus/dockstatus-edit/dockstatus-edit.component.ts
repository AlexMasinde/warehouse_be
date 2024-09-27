import { Component, OnInit, ChangeDetectionStrategy } from '@angular/core';
import { FormGroup, FormControl } from '@angular/forms';
import { DockStatus } from './dockstatus';


@Component({
  changeDetection: ChangeDetectionStrategy.OnPush,
  selector: 'app-dockstatus-edit',
  templateUrl: './dockstatus-edit.component.html',
  styleUrls: ['./dockstatus-edit.component.scss']
})
export class DockStatusEditComponent implements OnInit {

  public langs: any[];
  public orderItem: DockStatus;
  constructor() { }

  ngOnInit() {
     this.langs = [
      'English',
      'French',
      'German',
    ];

    let orderDate : Date =new Date();
    this.orderItem = new DockStatus(1, "XX001", "", 1, "POXX001", 1, "James Mwaniki", orderDate, "Quote22334", "Cred9000", 1, 2, 1, "CUS001", 2000);
      
  }

}
