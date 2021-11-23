import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { AccountantRoutingModule } from './accountant-routing.module';
import { DashboardComponent } from './dashboard/dashboard.component';
import { SalesComponent } from './sales/sales.component';
import { SharedModule } from '../shared/shared.module';
import { CourserefundComponent } from './courserefund/courserefund.component';
import { PurchaseComponent } from './purchase/purchase.component';
import { SideBarComponent } from './side-bar/side-bar.component';



@NgModule({
  declarations: [
    DashboardComponent,
    SalesComponent,
    CourserefundComponent,
    PurchaseComponent,
    SideBarComponent,
 
    
  ],
  imports: [
    CommonModule,
    AccountantRoutingModule,
    SharedModule
  ],
  exports: [SideBarComponent]
})
export class AccountantModule { }
