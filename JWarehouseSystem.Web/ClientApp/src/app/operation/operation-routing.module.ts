import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

const routes: Routes = [
  {
    path: '',
    children: [
      {
        path: 'stockmovement',
        loadChildren: () => import('./ops-stockmovements/stockmovements.module').then(module => module.StockMovementsModule)
      },
      {
        path: 'packing',
        loadChildren: () => import('./ops-packing/packings.module').then(module => module.PackingsModule)
      },
      {
        path: 'picking',
        loadChildren: () => import('./ops-picking/pickings.module').then(module => module.PickingsModule)
      },
      {
        path: 'shipping',
        loadChildren: () => import('./ops-shipping/shippings.module').then(module =>module.ShippingsModule)
      }
    ]
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class OperationRoutingModule { }
