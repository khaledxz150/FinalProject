import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { AdminRoutingModule } from './admin-routing.module';
import { AdminDashboardComponent } from './admin-dashboard/admin-dashboard.component';
import { SharedModule } from '../shared/shared.module';
import { CourseComponent } from './course/course.component';
import { SidebarComponent } from './sidebar/sidebar.component';
import { CreateCourseComponent } from './course/create-course/create-course.component';
import { CategoryComponent } from './category/category.component';
import { CreateCategoryComponent } from './category/create-category/create-category.component';
import { SectionComponent } from './section/section.component';
import { MatSelectModule } from '@angular/material/select';
import {MatDialogModule} from '@angular/material/dialog';
import { ViewCourseComponent } from './course/view-course/view-course.component';
import { TrainerInfoComponent } from './trainer-info/trainer-info.component';
import { CreateSectionComponent } from './section/create-section/create-section.component';
import { UpdateCategoryComponent } from './category/update-category/update-category.component';
import { UpdateSectionComponent } from './section/update-section/update-section.component';
import { TopicComponent } from './topic/topic.component';
import { CreateTopicComponent } from './topic/create-topic/create-topic.component';
import { CouponComponent } from './coupon/coupon.component';
import { TraineeInfoComponent } from './trainee-info/trainee-info.component';
import { AddTraineeComponent } from './trainee-info/add-trainee/add-trainee.component';
import { EditTraineeComponent } from './trainee-info/edit-trainee/edit-trainee.component';
@NgModule({
  declarations: [

    AdminDashboardComponent,
      CourseComponent,
      SidebarComponent,
      CreateCourseComponent,
      CategoryComponent,
      CreateCategoryComponent,
      SectionComponent,
      ViewCourseComponent,
      TrainerInfoComponent,
      CreateSectionComponent,
      UpdateCategoryComponent,
      UpdateSectionComponent,
      TopicComponent,
      CreateTopicComponent,
      CouponComponent,
      TraineeInfoComponent,
      AddTraineeComponent,
      EditTraineeComponent
  ],
  imports: [
    CommonModule,
    AdminRoutingModule,
    SharedModule,
    MatSelectModule,
    MatDialogModule
  ],

})
export class AdminModule { }
