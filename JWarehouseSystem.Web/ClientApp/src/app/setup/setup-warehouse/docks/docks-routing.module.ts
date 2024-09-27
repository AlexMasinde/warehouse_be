import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import {DocksComponent} from './docks.component';

const routes: Routes = [
  {
    path: '',
    component: DocksComponent
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class DocksRoutingModule { }
