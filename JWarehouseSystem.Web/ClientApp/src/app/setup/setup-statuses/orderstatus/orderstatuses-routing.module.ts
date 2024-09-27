import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import {OrderStatusesComponent} from './orderstatuses.component';

const routes: Routes = [
  {
    path: '',
    component: OrderStatusesComponent
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class OrderStatusesRoutingModule { }
