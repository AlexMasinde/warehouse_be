import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { SharedModule } from '../../../theme/shared/shared.module';
import { DataTablesModule } from 'angular-datatables';

import {DocksRoutingModule } from './docks-routing.module';
import { DocksComponent } from './docks.component';
import { IconsModule } from '../../../icons/icons.module';
import { DockEditComponent } from './dock-edit/dock-edit.component';
import { NgbPopoverModule, NgbTooltipModule } from '@ng-bootstrap/ng-bootstrap';
import { CustomFormsModule } from 'ng2-validation';
//import { NgSelectModule } from '@ng-select/ng-select';

@NgModule({
  imports: [
    CommonModule,
    DocksRoutingModule,
    SharedModule,
    FormsModule,
    DataTablesModule,
    IconsModule,
    NgbPopoverModule,
    NgbTooltipModule,
    CustomFormsModule,
   // NgSelectModule
   ],
  declarations: [DocksComponent, DockEditComponent]
})
export class DocksModule { }
