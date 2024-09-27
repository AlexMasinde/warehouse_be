import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { SharedModule } from '../../theme/shared/shared.module';
import { DataTablesModule } from 'angular-datatables';

import { PackingsRoutingModule } from './packings-routing.module';
import { PackingsComponent } from './packings.component';
import { IconsModule } from '../../icons/icons.module';
import { PackingEditComponent } from './packing-edit/packing-edit.component';
import { NgbPopoverModule, NgbTooltipModule } from '@ng-bootstrap/ng-bootstrap';
import { CustomFormsModule } from 'ng2-validation';
import { TinymceModule } from 'angular2-tinymce';
import { TagInputModule } from 'ngx-chips';

@NgModule({
  imports: [
    CommonModule,
    PackingsRoutingModule,
    SharedModule,
    FormsModule,
    DataTablesModule,
    IconsModule,
    NgbPopoverModule,
    NgbTooltipModule,
    CustomFormsModule,
    TinymceModule,
    TagInputModule
   ],
  declarations: [PackingsComponent, PackingEditComponent]
})
export class PackingsModule { }
