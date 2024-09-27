import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import {ProductStatusesComponent} from './productstatuses.component';

const routes: Routes = [
  {
    path: '',
    component: ProductStatusesComponent
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class ProductStatusesRoutingModule { }
