import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { DashboardComponent } from './dashboard/dashboard.component';
import { ProfileComponent } from './profile copy/profile.component';
import { PurchaseComponent } from './purchase/purchase.component';
import { SalesComponent } from './sales/sales.component';

const routes: Routes = [
  {
    path:'',
    component:DashboardComponent
  },
  {
    path:'sales',
    component:SalesComponent
  },
  {
    path:'purchase',
    component:PurchaseComponent
  },
  {
    path:'profile',
    component:ProfileComponent
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class AccountantRoutingModule { }
