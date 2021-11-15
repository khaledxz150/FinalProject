import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CertificationComponent } from './certification/certification.component';
import { ExamInfoComponent } from './exam-info/exam-info.component';
import { MyLeaningComponent } from './my-leaning/my-leaning.component';
import { MySectionsComponent } from './my-sections/my-sections.component';
import { ProfileComponent } from './profile/profile.component';
import { PurchaseComponent } from './purchase/purchase.component';
import { QuestionsComponent } from './questions/questions.component';
import { TaskInfoComponent } from './task-info/task-info.component';
import { TraineeNavComponent } from './trainee-nav/trainee-nav.component';
import { VideosComponent } from './videos/videos.component';

const routes: Routes = [
  {
    path:''
    ,component:TraineeNavComponent
  },
  {
    path:'profile',
    component:ProfileComponent
  },
  {
    path:'learning',
    component:MyLeaningComponent
  },{
    path:'sections'
    ,component:MySectionsComponent
  },{
    path:'questions',
    component:QuestionsComponent
  }
  ,{
    path:'purchase',
    component:PurchaseComponent
  },{
    path:'video',
    component:VideosComponent
  },{
    path:'info',
    component:ExamInfoComponent
  },{
    path:'task',
    component:TaskInfoComponent
  },{
    path:'certificate',
    component:CertificationComponent

  }

];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class TraineeRoutingModule { }
