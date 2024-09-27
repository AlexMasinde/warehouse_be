import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import {DockStatusesComponent} from './dockstatuses.component';

const routes: Routes = [
  {
    path: '',
    component: DockStatusesComponent
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class DockStatusesRoutingModule { }
