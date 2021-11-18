import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ExamInfoComponent } from './exam/exam-info/exam-info.component';
import { ExamComponent } from './exam/exam.component';
import { SectionComponent } from './section/section.component';
import { StudentsComponent } from './students/students.component';
import { UnitComponent } from './unit/unit.component';

const routes: Routes = [
{
    path:'',
    component:SectionComponent
},
{
    path:'unit',
    component:UnitComponent
},
{path:'exam',
component:ExamComponent},
{path:'examInfo',
 component:ExamInfoComponent},
 {path:'students',
 component:StudentsComponent}
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class TrainerRoutingModule { }
