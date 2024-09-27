import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { SharedModule } from '../../../theme/shared/shared.module';
import { DataTablesModule } from 'angular-datatables';

import { PurchaseStatusesRoutingModule } from './purchasestatuses-routing.module';
import { PurchaseStatusesComponent } from './purchasestatuses.component';
import { IconsModule } from '../../../icons/icons.module';
import { PurchaseStatusEditComponent } from './purchasestatus-edit/purchasestatus-edit.component';
import { NgbPopoverModule, NgbTooltipModule } from '@ng-bootstrap/ng-bootstrap';
import { CustomFormsModule } from 'ng2-validation';

@NgModule({
  imports: [
    CommonModule,
    PurchaseStatusesRoutingModule,
    SharedModule,
    FormsModule,
    DataTablesModule,
    IconsModule,
    NgbPopoverModule,
    NgbTooltipModule,
    CustomFormsModule
   ],
  declarations: [PurchaseStatusesComponent, PurchaseStatusEditComponent]
})
export class PurchaseStatusesModule { }
