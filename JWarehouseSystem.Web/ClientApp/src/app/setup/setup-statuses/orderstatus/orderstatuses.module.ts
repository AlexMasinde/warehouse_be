import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { SharedModule } from '../../../theme/shared/shared.module';
import { DataTablesModule } from 'angular-datatables';

import { OrderStatusesRoutingModule } from './orderstatuses-routing.module';
import {OrderStatusesComponent } from './orderstatuses.component';
import { IconsModule } from '../../../icons/icons.module';
import { OrderStatusEditComponent } from './orderstatus-edit/orderstatus-edit.component';
import { NgbPopoverModule, NgbTooltipModule } from '@ng-bootstrap/ng-bootstrap';
import { CustomFormsModule } from 'ng2-validation';

@NgModule({
  imports: [
    CommonModule,
    OrderStatusesRoutingModule,
    SharedModule,
    FormsModule,
    DataTablesModule,
    IconsModule,
    NgbPopoverModule,
    NgbTooltipModule,
    CustomFormsModule
   ],
  declarations: [OrderStatusesComponent, OrderStatusEditComponent]
})
export class OrderStatusesModule { }
