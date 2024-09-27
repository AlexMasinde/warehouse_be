import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { AdminComponent } from './theme/layout/admin/admin.component';
import {CoreChartModule} from './demo/pages/core-chart/core-chart.module';
import {AuthComponent} from './theme/layout/auth/auth.component';
import { AuthSigninComponent } from './auth-signin/auth-signin.component';

const routes: Routes = [
  {
    path: '',
    component: AdminComponent,
    children: [
      {
        path: '',
        redirectTo: 'dashboard/default',
        pathMatch: 'full'
      },
      {
        path: 'dashboard',
        loadChildren: () => import('./demo/dashboard/dashboard.module').then(module => module.DashboardModule)
      },
      {
        path: 'transaction',
        loadChildren: () => import('../app/transaction/transaction.module').then(module => module.TransactionModule)
      },
      {
        path: 'operation',
        loadChildren: () => import('../app/operation/operation.module').then(module => module.OperationModule)
      },
      {
        path: 'setup',
        loadChildren: () => import('../app/setup/setup.module').then(module => module.SetupModule)
      }

    ]
  },
  {
    path: 'login',
    component: AuthSigninComponent,
    children: [
      {
        path: 'auth',
        loadChildren: () => import('./auth-signin/auth-signin.module').then(module => module.AuthSigninModule)
      },
      {
        path: 'maintenance',
        loadChildren: () => import('./demo/pages/maintenance/maintenance.module').then(module => module.MaintenanceModule)
      }
    ]
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
