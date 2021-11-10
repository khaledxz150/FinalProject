import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { TrainerRoutingModule } from './trainer-routing.module';
import { SectionComponent } from './section/section.component';
import { UnitComponent } from './unit/unit.component';
import { ExamComponent } from './exam/exam.component';
import { SharedModule } from '../shared/shared.module';
import { TrainerSideBarComponent } from './trainer-side-bar/trainer-side-bar.component';
import { CreateUnitComponent } from './unit/create-unit/create-unit.component';
import { EditUnitComponent } from './unit/edit-unit/edit-unit.component';
import { UnitTableComponent } from './unit/unit-table/unit-table.component';
import { ExamTableComponent } from './exam/exam-table/exam-table.component';


@NgModule({
  declarations: [
    SectionComponent,
    UnitComponent,
    ExamComponent,
    TrainerSideBarComponent,
    CreateUnitComponent,
    EditUnitComponent,
    UnitTableComponent,
    ExamTableComponent,
    ],
  imports: [
    CommonModule,
    TrainerRoutingModule,
    SharedModule,
  ]
})
export class TrainerModule { }
