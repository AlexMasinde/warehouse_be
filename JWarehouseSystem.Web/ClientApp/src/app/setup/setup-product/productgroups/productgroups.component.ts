import {Component, OnInit} from '@angular/core';
import { data } from '../../../fake-data/datatable-data.json';
import { countries } from '../../../fake-data/countrieslist.json';


@Component({
  selector: 'app-productgroups',
  templateUrl: './productgroups.component.html',
  styleUrls: ['./productgroups.component.scss']
})
export class ProductGroupsComponent implements OnInit {
 
  sampleData = data;
  addressTo = countries;
  status: any[] = ['Initiated', 'In Progress', 'Completed', 'Suspended', 'UnKnown', 'Delayed'];
  statuses: any[] = [];
  constructor() { }
  getstatus(index) {
    return this.statuses[index];
  }

  ngOnInit() {

    let i: number = 0;
    while (i < 100) {
      let min = 0; let max = 4;
      let rand = Math.random();
      let x = Math.floor(rand * (max - min + 1)) + 1;
      this.statuses.push(this.status[x]);
      i++;
    }

  }

}
