import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { TraineeRoutingModule } from './trainee-routing.module';
import { TraineeNavComponent } from './trainee-nav/trainee-nav.component';
import { SharedModule } from '../shared/shared.module';
import { ProfileComponent } from './profile/profile.component';
import { MyLeaningComponent } from './my-leaning/my-leaning.component';
import { SectionInfoComponent } from './section-info/section-info.component';
import { MySectionsComponent } from './my-sections/my-sections.component';
import { AddCommentComponent } from './add-comment/add-comment.component';
import { CertificationComponent } from './certification/certification.component';
import { ExamInfoComponent } from './exam-info/exam-info.component';
import { PurchaseComponent } from './purchase/purchase.component';
import { QuestionsComponent } from './questions/questions.component';
import { RateBoxComponent } from './rate-box/rate-box.component';
import { RatesComponent } from './rates/rates.component';
import { TaskInfoComponent } from './task-info/task-info.component';
import { VideosComponent } from './videos/videos.component';
import { InsertRefundComponent } from './purchase/insert-refund/insert-refund.component';
import { CourseInfoComponent } from './course-info/course-info.component';

@NgModule({
  declarations: [
    TraineeNavComponent,
    ProfileComponent,
    MyLeaningComponent,
    SectionInfoComponent,
    MySectionsComponent,
    AddCommentComponent,
    CertificationComponent,
    ExamInfoComponent,
    PurchaseComponent,
    QuestionsComponent,
    RateBoxComponent,
    RatesComponent,
    TaskInfoComponent,
    VideosComponent,
    InsertRefundComponent,
    CourseInfoComponent,
  ],
  imports: [
    CommonModule,
    TraineeRoutingModule,
    SharedModule
  ],exports:[
    TraineeNavComponent
  ]
})
export class TraineeModule { }
