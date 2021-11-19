import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { AccountantRoutingModule } from './accountant-routing.module';
import { DashboardComponent } from './dashboard/dashboard.component';
import { SalesComponent } from './sales/sales.component';
import { SideBarComponent } from './side-bar/side-bar.component';
import { SharedModule } from '../shared/shared.module';
import { CourserefundComponent } from './courserefund/courserefund.component';
import { PurchaseComponent } from './purchase/purchase.component';


@NgModule({
  declarations: [
    DashboardComponent,
    SalesComponent,
    SideBarComponent,
    CourserefundComponent,
    PurchaseComponent
  ],
  imports: [
    CommonModule,
    AccountantRoutingModule,
    SharedModule
  ]
})
export class AccountantModule { }
