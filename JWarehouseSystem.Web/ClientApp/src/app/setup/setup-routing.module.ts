import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

const routes: Routes = [
  {
    path: '',
    children: [
      //{
      //  path: 'orders',
      //  loadChildren: () => import('./trans-orders/orders.module').then(module => module.OrdersModule)
      //},
      //{
      //  path: 'purchases',
      //  loadChildren: () => import('./trans-purchases/purchases.module').then(module => module.PurchasesModule)
      //},
      //{
      //  path: 'deliveries',
      //  loadChildren: () => import('./trans-deliveries/deliveries.module').then(module => module.DeliveriesModule)
      //},
      //{
      //  path: 'receipts',
      //  loadChildren: () => import('./trans-receipts/receipts.module').then(module => module.ReceiptsModule)
      //},
      {
        path: 'docks',
        loadChildren: () => import('./setup-warehouse/docks/docks.module').then(module => module.DocksModule)
      },
      {
        path: 'ships',
        loadChildren: () => import('./setup-warehouse/ships/ships.module').then(module => module.ShipsModule)
      },
      {
        path: 'warehouses',
        loadChildren: () => import('./setup-warehouse/warehouses/warehouses.module').then(module => module.WarehousesModule)
      },

      {
        path: 'currencies',
        loadChildren: () => import('./setup-location/currencies/currencies.module').then(module => module.CurrenciesModule)
      },
      {
        path: 'countries',
        loadChildren: () => import('./setup-location/countries/countries.module').then(module => module.CountriesModule)
      },
      {
        path: 'locations',
        loadChildren: () => import('./setup-location/locations/locations.module').then(module => module.LocationsModule)
      },
      {
        path: 'regions',
        loadChildren: () => import('./setup-location/regions/regions.module').then(module => module.RegionsModule)
      }
    ]
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class SetupRoutingModule { }
