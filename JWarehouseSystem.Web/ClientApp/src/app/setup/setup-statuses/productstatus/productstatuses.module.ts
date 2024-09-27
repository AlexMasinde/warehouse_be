import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { SharedModule } from '../../../theme/shared/shared.module';
import { DataTablesModule } from 'angular-datatables';

import { ProductStatusesRoutingModule } from './productstatuses-routing.module';
import {ProductStatusesComponent } from './productstatuses.component';
import { IconsModule } from '../../../icons/icons.module';
import { ProductStatusEditComponent } from './productstatus-edit/productstatus-edit.component';
import { NgbPopoverModule, NgbTooltipModule } from '@ng-bootstrap/ng-bootstrap';
import { CustomFormsModule } from 'ng2-validation';

@NgModule({
  imports: [
    CommonModule,
    ProductStatusesRoutingModule,
    SharedModule,
    FormsModule,
    DataTablesModule,
    IconsModule,
    NgbPopoverModule,
    NgbTooltipModule,
    CustomFormsModule
   ],
  declarations: [ProductStatusesComponent, ProductStatusEditComponent]
})
export class DeliveriesModule { }
