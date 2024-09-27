import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { SharedModule } from '../../theme/shared/shared.module';
import { DataTablesModule } from 'angular-datatables';

import { DeliveriesRoutingModule } from './deliveries-routing.module';
import { DeliveriesComponent } from './deliveries.component';
import { IconsModule } from '../../icons/icons.module';
import { DeliveryEditComponent } from './delivery-edit/delivery-edit.component';
import { NgbPopoverModule, NgbTooltipModule } from '@ng-bootstrap/ng-bootstrap';
import { CustomFormsModule } from 'ng2-validation';

@NgModule({
  imports: [
    CommonModule,
    DeliveriesRoutingModule,
    SharedModule,
    FormsModule,
    DataTablesModule,
    IconsModule,
    NgbPopoverModule,
    NgbTooltipModule,
    CustomFormsModule
   ],
  declarations: [DeliveriesComponent,  DeliveryEditComponent]
})
export class DeliveriesModule { }
