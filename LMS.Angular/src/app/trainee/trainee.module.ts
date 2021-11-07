import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { TraineeRoutingModule } from './trainee-routing.module';
import { TraineeNavComponent } from './trainee-nav/trainee-nav.component';
import { SharedModule } from '../shared/shared.module';
import { ProfileComponent } from './profile/profile.component';
import { MyLeaningComponent } from './my-leaning/my-leaning.component';

@NgModule({
  declarations: [
    TraineeNavComponent,
    ProfileComponent,
    MyLeaningComponent
  ],
  imports: [
    CommonModule,
    TraineeRoutingModule,
    SharedModule
  ]
})
export class TraineeModule { }
