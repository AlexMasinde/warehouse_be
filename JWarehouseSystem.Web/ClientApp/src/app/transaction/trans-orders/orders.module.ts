import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { SharedModule } from '../../theme/shared/shared.module';
import { DataTablesModule } from 'angular-datatables';

import {OrdersRoutingModule } from './orders-routing.module';
import { OrdersComponent } from './orders.component';
import { IconsModule } from '../../icons/icons.module';
import { OrderEditComponent } from './order-edit/order-edit.component';
import { NgbPopoverModule, NgbTooltipModule, NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { NgbTabsetModule } from '@ng-bootstrap/ng-bootstrap';
import { CustomFormsModule } from 'ng2-validation';
import { TinymceModule } from 'angular2-tinymce';
import { TagInputModule } from 'ngx-chips';


@NgModule({
  imports: [
    CommonModule,
    OrdersRoutingModule,
    SharedModule,
    FormsModule,
    DataTablesModule,
    IconsModule,
    NgbPopoverModule,
    NgbTooltipModule,
    CustomFormsModule,
    NgbTabsetModule,
    TinymceModule,
    TagInputModule,
    NgbModule
  ], 
  declarations: [OrdersComponent, OrderEditComponent],
  entryComponents: [OrderEditComponent]

})
export class OrdersModule { }
