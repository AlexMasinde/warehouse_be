import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import {PackingsComponent} from './packings.component';

const routes: Routes = [
  {
    path: '',
    component: PackingsComponent
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class PackingsRoutingModule { }
