import {Component, OnInit} from '@angular/core';
import { data } from '../../../fake-data/datatable-data.json';
import { countries } from '../../../fake-data/countrieslist.json';
import '../../../../node_modules/tinymce/tinymce.min.js';

@Component({
  selector: 'app-pickings',
  templateUrl: './pickings.component.html',
  styleUrls: ['./pickings.component.scss']
})
export class PickingsComponent implements OnInit {
 
  sampleData = data;
  addressTo = countries;
  status: any[] = ['Initiated', 'In Progress', 'Completed', 'Suspended', 'UnKnown', 'Delayed'];
  statuses: any[] = [];
  items = ['Html', 'Css', 'Javascript', 'Angular', 'React'];
  public basicContent: string;

  constructor() { this.basicContent = '<p>Hello...</p>'; }

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
