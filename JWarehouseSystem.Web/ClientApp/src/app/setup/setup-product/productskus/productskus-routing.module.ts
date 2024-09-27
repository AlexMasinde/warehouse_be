import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import {ProductSKUsComponent} from './productskus.component';

const routes: Routes = [
  {
    path: '',
    component: ProductSKUsComponent
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class ProductSKUsRoutingModule { }
