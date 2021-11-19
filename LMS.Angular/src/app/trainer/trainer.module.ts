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
import { ExamQuestionsAnswersComponent } from './exam/exam-questions-answers/exam-questions-answers.component';
import { ExamInfoComponent } from './exam/exam-info/exam-info.component';
import { TaskComponent } from './task/task.component';
import { CreateTaskComponent } from './task/create-task/create-task.component';
import { EditTaskComponent } from './task/edit-task/edit-task.component';
import { TaskSoultionsComponent } from './task/task-soultions/task-soultions.component';
import { DeleteExamComponent } from './exam/delete-exam/delete-exam.component';
import { TraineeMarkComponent } from './exam/trainee-mark/trainee-mark.component';

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
    EditExamComponent,
    StudentsComponent,
    AttendanceComponent,
    CreateLectureComponent,
    ExamQuestionsAnswersComponent,
    ExamInfoComponent,
    TaskComponent,
    CreateTaskComponent,
    EditTaskComponent,
    TaskSoultionsComponent,
    DeleteExamComponent,
    TraineeMarkComponent,

    ],
  imports: [
    CommonModule,
    TrainerRoutingModule,
    SharedModule,
    MatTimepickerModule
  ]
})
export class TrainerModule { }
