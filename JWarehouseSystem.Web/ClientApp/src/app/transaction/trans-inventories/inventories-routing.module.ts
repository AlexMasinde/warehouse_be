import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import {InventoriesComponent} from './inventories.component';

const routes: Routes = [
  {
    path: '',
    component: InventoriesComponent
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class InventoriesRoutingModule { }
