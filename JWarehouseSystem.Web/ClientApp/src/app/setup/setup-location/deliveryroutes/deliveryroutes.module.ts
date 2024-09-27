import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { SharedModule } from '../../../theme/shared/shared.module';
import { DataTablesModule } from 'angular-datatables';

import { DeliveryRoutesRoutingModule } from './deliveryroutes-routing.module';
import { DeliveryRoutesComponent } from './deliveryroutes.component';
import { IconsModule } from '../../../icons/icons.module';
import { DeliveryRouteEditComponent } from './deliveryroute-edit/deliveryroute-edit.component';
import { NgbPopoverModule, NgbTooltipModule } from '@ng-bootstrap/ng-bootstrap';
import { CustomFormsModule } from 'ng2-validation';

@NgModule({
  imports: [
    CommonModule,
    DeliveryRoutesRoutingModule,
    SharedModule,
    FormsModule,
    DataTablesModule,
    IconsModule,
    NgbPopoverModule,
    NgbTooltipModule,
    CustomFormsModule
   ],
  declarations: [DeliveryRoutesComponent,  DeliveryRouteEditComponent]
})
export class DeliveryRoutesModule { }
