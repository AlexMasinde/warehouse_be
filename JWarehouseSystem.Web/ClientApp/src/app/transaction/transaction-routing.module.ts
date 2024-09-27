import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

const routes: Routes = [
  {
    path: '',
    children: [
      {
        path: 'orders',
        loadChildren: () => import('./trans-orders/orders.module').then(module => module.OrdersModule)
      },
      {
        path: 'purchases',
        loadChildren: () => import('./trans-purchases/purchases.module').then(module => module.PurchasesModule)
      },
      {
        path: 'deliveries',
        loadChildren: () => import('./trans-deliveries/deliveries.module').then(module => module.DeliveriesModule)
      },
      {
        path: 'receipts',
        loadChildren: () => import('./trans-receipts/receipts.module').then(module => module.ReceiptsModule)
      },
      {
        path: 'inventories',
        loadChildren: () => import('./trans-inventories/inventories.module').then(module => module.InventoriesModule)
      }
    ]
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class TransactionRoutingModule { }
