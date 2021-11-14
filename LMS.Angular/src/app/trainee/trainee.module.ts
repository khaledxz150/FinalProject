import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { TraineeRoutingModule } from './trainee-routing.module';
import { TraineeNavComponent } from './trainee-nav/trainee-nav.component';
import { SharedModule } from '../shared/shared.module';
import { ProfileComponent } from './profile/profile.component';
import { MyLeaningComponent } from './my-leaning/my-leaning.component';
import { SectionInfoComponent } from './section-info/section-info.component';
import { MySectionsComponent } from './my-sections/my-sections.component';
import { CommentsComponent } from './comments/comments.component';
import { AddCommentComponent } from './add-comment/add-comment.component';
import { CertificationComponent } from './certification/certification.component';
import { ExamInfoComponent } from './exam-info/exam-info.component';

@NgModule({
  declarations: [
    TraineeNavComponent,
    ProfileComponent,
    MyLeaningComponent,
    SectionInfoComponent,
    MySectionsComponent,
    CommentsComponent,
    AddCommentComponent,
    CertificationComponent,
    ExamInfoComponent,
  ],
  imports: [
    CommonModule,
    TraineeRoutingModule,
    SharedModule
  ]
})
export class TraineeModule { }
