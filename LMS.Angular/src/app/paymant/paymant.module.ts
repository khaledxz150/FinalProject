import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { PaymantRoutingModule } from './paymant-routing.module';
import { PaypalComponent } from './paypal/paypal.component';
import { TestComponent } from './test/test.component';
import { NgxPayPalModule } from 'ngx-paypal';


@NgModule({
  declarations: [
    PaypalComponent,
    
    TestComponent
  ],
  imports: [
    CommonModule,
    PaymantRoutingModule,
    
  ]
})
export class PaymantModule { }
