import {Component, OnInit} from '@angular/core';
import { data } from '../../../fake-data/datatable-data.json';
import { countries } from '../../../fake-data/countrieslist.json';
import '../../../../node_modules/tinymce/tinymce.min.js';
import { Order } from './order-edit/order';
import { OrderService} from '../trans-orders/order.service';
import { FormGroup } from '@angular/forms';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { OrderEditComponent } from './order-edit/order-edit.component';

@Component({
  selector: 'app-orders',
  templateUrl: './orders.component.html',
  styleUrls: ['./orders.component.scss']
})
export class OrdersComponent implements OnInit {
  editForm: FormGroup;
  sampleData = data;
  addressTo = countries;

  status: any[] = [ 'Initiated', 'In Progress', 'Completed', 'Suspended', 'UnKnown','Delayed' ];
  statuses: any[]=[];
  items = ['Html', 'Css', 'Javascript', 'Angular', 'React'];

  Title: string = '';
  Title2: string = '';

  newItem: any;
  selectedItem: any;
  editItem: any;
   

  constructor(private orderService: OrderService, private modalService: NgbModal) 
  {

  }

  onSelect(item: Order): void {
    this.selectedItem = item;
    //this.Title = (this.selectedItem.id === 0 ? 'New Order...' : 'Editing Order [' + this.selectedItem.id + ']...');
  }

  getstatus(index) {
     return this.statuses[index];
  }

  setForm(frm) {

    this.editForm = frm;
  }

  ngOnInit() {

    this.newItem = this.orderService.getOrder(null);
    this.editItem = this.orderService.getOrder(0);
    this.selectedItem = this.orderService.getOrder(1);

    let orderlist = this.orderService.getOrders();

    let i: number = 0;
    while (i < 100) {
      let min = 0; let max = 4;
      let rand = Math.random();
      let x = Math.floor(rand * (max - min + 1)) + 1;
      this.statuses.push(this.status[x]);
      i++;
    }

  }

  openEditModal(id:number) {
    const modalEditOrder = this.modalService.open(OrderEditComponent);
    modalEditOrder.componentInstance.id = id;

    modalEditOrder.result.then((result) => {
      console.log(result);

    }).catch((error) => {

      console.log(error);
    });
  }

}
