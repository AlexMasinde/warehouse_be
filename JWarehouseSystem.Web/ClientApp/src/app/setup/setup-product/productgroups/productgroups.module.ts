import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { SharedModule } from '../../../theme/shared/shared.module';
import { DataTablesModule } from 'angular-datatables';

import { ProductGroupsRoutingModule } from './productgroups-routing.module';
import { ProductGroupsComponent } from './productgroups.component';
import { IconsModule } from '../../../icons/icons.module';
import { ProductGroupEditComponent } from './productgroup-edit/productgroup-edit.component';
import { NgbPopoverModule, NgbTooltipModule } from '@ng-bootstrap/ng-bootstrap';
import { CustomFormsModule } from 'ng2-validation';

@NgModule({
  imports: [
    CommonModule,
    ProductGroupsRoutingModule,
    SharedModule,
    FormsModule,
    DataTablesModule,
    IconsModule,
    NgbPopoverModule,
    NgbTooltipModule,
    CustomFormsModule
   ],
  declarations: [ProductGroupsComponent, ProductGroupEditComponent]
})
export class ProductGroupsModule { }
