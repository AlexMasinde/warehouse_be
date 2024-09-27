import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { SharedModule } from '../../../theme/shared/shared.module';
import { DataTablesModule } from 'angular-datatables';

import { MovementStatusesRoutingModule } from './movementstatuses-routing.module';
import { MovementStatusesComponent } from './MovementStatuses.component';
import { IconsModule } from '../../../icons/icons.module';
import { MovementStatusEditComponent } from './movementstatus-edit/movementstatus-edit.component';
import { NgbPopoverModule, NgbTooltipModule } from '@ng-bootstrap/ng-bootstrap';
import { CustomFormsModule } from 'ng2-validation';

@NgModule({
  imports: [
    CommonModule,
    MovementStatusesRoutingModule,
    SharedModule,
    FormsModule,
    DataTablesModule,
    IconsModule,
    NgbPopoverModule,
    NgbTooltipModule,
    CustomFormsModule
   ],
  declarations: [MovementStatusesComponent,  MovementStatusEditComponent]
})
export class MovementStatusesModule { }
