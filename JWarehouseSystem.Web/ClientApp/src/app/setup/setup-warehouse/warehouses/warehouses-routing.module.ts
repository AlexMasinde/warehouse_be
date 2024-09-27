import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import {WarehousesComponent} from './warehouses.component';

const routes: Routes = [
  {
    path: '',
    component: WarehousesComponent
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class WarehousesRoutingModule { }
