import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ExamInfoComponent } from './exam/exam-info/exam-info.component';

import { ExamComponent } from './exam/exam.component';
import { SectionComponent } from './section/section.component';

import { TaskSoultionsComponent } from './task/task-soultions/task-soultions.component';

import { StudentsComponent } from './students/students.component';

import { UnitComponent } from './unit/unit.component';
import { AttendanceComponent } from './attendance/attendance.component';

const routes: Routes = [
{
    path:'',
    component:SectionComponent
},
{
    path:'unit',
    component:UnitComponent
  }
  ,
  {
    path:'att',
    component:AttendanceComponent
  },
  {path:'exam',
component:ExamComponent},
{path:'examInfo',
 component:ExamInfoComponent},{
   path:'solution',
   component:TaskSoultionsComponent
 },
 {path:'students',
 component:StudentsComponent},{
   path:'attend',
   component:AttendanceComponent
 }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class TrainerRoutingModule { }
