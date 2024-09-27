import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { SharedModule } from '../../../theme/shared/shared.module';
import { DataTablesModule } from 'angular-datatables';

import { ProductSKUsRoutingModule } from './productskus-routing.module';
import { ProductSKUsComponent } from './productskus.component';
import { IconsModule } from '../../../icons/icons.module';
import { ProductSKUEditComponent } from './productsku-edit/productsku-edit.component';
import { NgbPopoverModule, NgbTooltipModule } from '@ng-bootstrap/ng-bootstrap';
import { CustomFormsModule } from 'ng2-validation';

@NgModule({
  imports: [
    CommonModule,
    ProductSKUsRoutingModule,
    SharedModule,
    FormsModule,
    DataTablesModule,
    IconsModule,
    NgbPopoverModule,
    NgbTooltipModule,
    CustomFormsModule
   ],
  declarations: [ProductSKUsComponent, ProductSKUEditComponent]
})
export class ProductSKUsModule { }
