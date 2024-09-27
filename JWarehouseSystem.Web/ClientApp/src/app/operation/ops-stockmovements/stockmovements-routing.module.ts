import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import {StockMovementsComponent} from './stockmovements.component';

const routes: Routes = [
  {
    path: '',
    component: StockMovementsComponent
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class StockMovementsRoutingModule { }
