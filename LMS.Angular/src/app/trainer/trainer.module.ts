import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { TrainerRoutingModule } from './trainer-routing.module';
import { SectionComponent } from './section/section.component';
import { UnitComponent } from './unit/unit.component';
import { ExamComponent } from './exam/exam.component';
import { SharedModule } from 'primeng/api';


@NgModule({
  declarations: [
    SectionComponent,
    UnitComponent,
    ExamComponent
  ],
  imports: [
    CommonModule,
    TrainerRoutingModule,
    SharedModule
  ]
})
export class TrainerModule { }
