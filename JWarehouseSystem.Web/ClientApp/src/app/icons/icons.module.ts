import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FeatherModule } from 'angular-feather';
import {
  Anchor, Award, Archive, BarChart2, Save, Settings, Trash, Trash2,
  Truck, BarChart, Edit2, Edit, Package, Paperclip, User, Globe
} from 'angular-feather/icons';

const icons = {
  Anchor, Award, Archive, BarChart2, Save, Settings, Trash, Trash2,
  Truck, BarChart, Edit2, Edit, Package, Paperclip, User, Globe
};

@NgModule({
  declarations: [],
  imports: [
    CommonModule,
    FeatherModule.pick(icons)
  ],
  exports: [
    FeatherModule
  ]
})
export class IconsModule { }
