import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AdminDashboardComponent } from './admin-dashboard/admin-dashboard.component';
import { CategoryComponent } from './category/category.component';
import { CouponComponent } from './coupon/coupon.component';
import { CourseComponent } from './course/course.component';
import { SectionComponent } from './section/section.component';
import { TopicComponent } from './topic/topic.component';
import { TraineeInfoComponent } from './trainee-info/trainee-info.component';
import { TrainerInfoComponent } from './trainer-info/trainer-info.component';

const routes: Routes = [
  {
    path:'',
    component:AdminDashboardComponent
  },
  {
    path:'course',
    component:CourseComponent
  },

  {
    path:'trainer-info',
    component:TrainerInfoComponent
  },
  {
    path:'trainee-info',
    component:TraineeInfoComponent
  },
  {
    path:'category',
    component:CategoryComponent
  },
  {
    path:'section',
    component:SectionComponent
  },
  {
    path:'topic',
    component:TopicComponent
  },
  {
    path:'coupon',
    component:CouponComponent
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class AdminRoutingModule { }
