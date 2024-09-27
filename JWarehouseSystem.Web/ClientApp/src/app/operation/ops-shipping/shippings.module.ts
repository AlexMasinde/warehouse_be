import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { SharedModule } from '../../theme/shared/shared.module';
import { DataTablesModule } from 'angular-datatables';

import { ShippingsRoutingModule } from './shippings-routing.module';
import { ShippingsComponent } from './shippings.component';
import { IconsModule } from '../../icons/icons.module';
import { ShippingEditComponent } from './shipping-edit/shipping-edit.component';
import { NgbPopoverModule, NgbTooltipModule } from '@ng-bootstrap/ng-bootstrap';
import { CustomFormsModule } from 'ng2-validation';

@NgModule({
  imports: [
    CommonModule,
    ShippingsRoutingModule,
    SharedModule,
    FormsModule,
    DataTablesModule,
    IconsModule,
    NgbPopoverModule,
    NgbTooltipModule,
    CustomFormsModule
   ],
  declarations: [ShippingsComponent, ShippingEditComponent]
})
export class ShippingsModule { }
