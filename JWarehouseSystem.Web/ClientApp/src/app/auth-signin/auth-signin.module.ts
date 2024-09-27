import { BrowserModule } from '@angular/platform-browser';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { SharedModule } from '../theme/shared/shared.module';

import { Routes, RouterModule } from '@angular/router';
import { AuthSigninRoutingModule } from './auth-signin-routing.module';
import { AuthSigninComponent } from './auth-signin.component';
import { AppModule } from 'src/app/app.module';

@NgModule({
  imports: [
    CommonModule,
    AuthSigninRoutingModule,
    BrowserModule,
    BrowserAnimationsModule,
    FormsModule,
    SharedModule,
    AppModule,
    RouterModule.forRoot([])
  ],
  declarations: [AuthSigninComponent],
  bootstrap: [AuthSigninComponent]
})
export class AuthSigninModule { }
