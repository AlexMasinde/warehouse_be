import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { SetupRoutingModule } from './setup-routing.module';
import {SharedModule} from '../theme/shared/shared.module';

@NgModule({
  imports: [
    CommonModule,
   SetupRoutingModule,
    SharedModule
  ]
})
export class SetupModule { }
