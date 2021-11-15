import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { TrainerRoutingModule } from './trainer-routing.module';
import { SectionComponent } from './section/section.component';
import { UnitComponent } from './unit/unit.component';
import { ExamComponent } from './exam/exam.component';
import { SharedModule } from '../shared/shared.module';
import { TrainerSideBarComponent } from './trainer-side-bar/trainer-side-bar.component';
import { CreateUnitComponent } from './unit/create-unit/create-unit.component';
import { TrainerComponent } from './trainer.component';
import { EditUnitComponent } from './unit/edit-unit/edit-unit.component';
import { CreateExamComponent } from './exam/create-exam/create-exam.component';
import { MatTimepickerModule } from 'mat-timepicker';
import { EditExamComponent } from './exam/edit-exam/edit-exam.component';
import { StudentsComponent } from './students/students.component';
import { AttendanceComponent } from './attendance/attendance.component';
import { CreateLectureComponent } from './create-lecture/create-lecture.component';

@NgModule({
  declarations: [
    SectionComponent,
    UnitComponent,
    ExamComponent,
    TrainerSideBarComponent,
    CreateUnitComponent,
    TrainerComponent,
    EditUnitComponent,
    CreateExamComponent,
    ],
  imports: [
    CommonModule,
    TrainerRoutingModule,
    SharedModule,
    MatTimepickerModule
  ]
})
export class TrainerModule { }
