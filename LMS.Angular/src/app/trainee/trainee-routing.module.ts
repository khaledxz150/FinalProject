import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CertificationComponent } from './certification/certification.component';
import { CourseInfoComponent } from './course-info/course-info.component';
import { ExamInfoComponent } from './exam-info/exam-info.component';
import { MyLeaningComponent } from './my-leaning/my-leaning.component';
import { MySectionsComponent } from './my-sections/my-sections.component';
import { ProfileComponent } from './profile/profile.component';
import { PurchaseComponent } from './purchase/purchase.component';
import { QuestionsComponent } from './questions/questions.component';
import { SectionInfoComponent } from './section-info/section-info.component';
import { TaskInfoComponent } from './task-info/task-info.component';
import { TraineeNavComponent } from './trainee-nav/trainee-nav.component';
import { VideosComponent } from './videos/videos.component';

const routes: Routes = [
  {
    path:''
    ,component:MyLeaningComponent
  },
  {
    path:'profile',
    component:ProfileComponent
  },
  {
    path:'learning',
    component:MyLeaningComponent
  },{
    path:'sections/:id'
    ,component:MySectionsComponent
  },{
    path:'questions',
    component:QuestionsComponent
  }
  ,{
    path:'courseInfo/:id',
    component:CourseInfoComponent
  }
  ,{
    path:'purchase',
    component:PurchaseComponent
  },{
    path:'info',
    component:ExamInfoComponent
  },{
    path:'task',
    component:TaskInfoComponent
  },{
    path:'certificate',
    component:CertificationComponent

  },{
    path:'sectionInfo/:id',
    component:SectionInfoComponent
  }

];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class TraineeRoutingModule { }
