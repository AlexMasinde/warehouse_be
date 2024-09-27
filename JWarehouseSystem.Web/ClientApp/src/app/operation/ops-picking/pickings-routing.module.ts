import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import {PickingsComponent} from './pickings.component';

const routes: Routes = [
  {
    path: '',
    component: PickingsComponent
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class PickingsRoutingModule { }
