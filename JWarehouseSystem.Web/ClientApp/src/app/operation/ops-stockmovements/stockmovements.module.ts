import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { SharedModule } from '../../theme/shared/shared.module';
import { DataTablesModule } from 'angular-datatables';

import { StockMovementsRoutingModule } from './stockmovements-routing.module';
import { StockMovementsComponent } from './stockmovements.component';
import { IconsModule } from '../../icons/icons.module';
import { StockMovementEditComponent } from './stockmovement-edit/stockmovement-edit.component';
import { NgbPopoverModule, NgbTooltipModule } from '@ng-bootstrap/ng-bootstrap';
import { CustomFormsModule } from 'ng2-validation';

@NgModule({
  imports: [
    CommonModule,
    StockMovementsRoutingModule,
    SharedModule,
    FormsModule,
    DataTablesModule,
    IconsModule,
    NgbPopoverModule,
    NgbTooltipModule,
    CustomFormsModule
   ],
  declarations: [StockMovementsComponent, StockMovementEditComponent]
})
export class StockMovementsModule { }
