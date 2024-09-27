import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { SharedModule } from '../../../theme/shared/shared.module';
import { DataTablesModule } from 'angular-datatables';

import { SuppliersRoutingModule } from './suppliers-routing.module';
import { SuppliersComponent } from './suppliers.component';
import { IconsModule } from '../../../icons/icons.module';
import { SupplierEditComponent } from './supplier-edit/supplier-edit.component';
import { NgbPopoverModule, NgbTooltipModule } from '@ng-bootstrap/ng-bootstrap';
import { CustomFormsModule } from 'ng2-validation';

@NgModule({
  imports: [
    CommonModule,
    SuppliersRoutingModule,
    SharedModule,
    FormsModule,
    DataTablesModule,
    IconsModule,
    NgbPopoverModule,
    NgbTooltipModule,
    CustomFormsModule
   ],
  declarations: [SuppliersComponent,  SupplierEditComponent]
})
export class SuppliersModule { }
