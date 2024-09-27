import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { SharedModule } from '../../theme/shared/shared.module';
import { DataTablesModule } from 'angular-datatables';

import { PickingsRoutingModule } from './pickings-routing.module';
import { PickingsComponent } from './pickings.component';
import { IconsModule } from '../../icons/icons.module';
import { PickingEditComponent } from './picking-edit/picking-edit.component';
import { NgbPopoverModule, NgbTooltipModule } from '@ng-bootstrap/ng-bootstrap';
import { CustomFormsModule } from 'ng2-validation';
import { TinymceModule } from 'angular2-tinymce';
import { TagInputModule } from 'ngx-chips';

@NgModule({
  imports: [
    CommonModule,
    PickingsRoutingModule,
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
  declarations: [PickingsComponent, PickingEditComponent]
})
export class PickingsModule { }
