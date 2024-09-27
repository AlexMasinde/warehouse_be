import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import {MovementStatusesComponent} from './movementstatuses.component';

const routes: Routes = [
  {
    path: '',
    component: MovementStatusesComponent
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class MovementStatusesRoutingModule { }
