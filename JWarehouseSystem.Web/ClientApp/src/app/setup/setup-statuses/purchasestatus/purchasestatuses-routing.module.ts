import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import {PurchaseStatusesComponent} from './purchasestatuses.component';

const routes: Routes = [
  {
    path: '',
    component: PurchaseStatusesComponent
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class PurchaseStatusesRoutingModule { }
