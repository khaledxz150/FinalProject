import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AdminDashboardComponent } from './admin-dashboard/admin-dashboard.component';
import { CalenderComponent } from './calender/calender.component';
import { CategoryComponent } from './category/category.component';
import { CouponComponent } from './coupon/coupon.component';
import { CourseComponent } from './course/course.component';
import { EditComponent } from './profile/edit/edit.component';
import { ProfileComponent } from './profile/profile.component';
import { SectionComponent } from './section/section.component';
import { TestmonialComponent } from './testmonial/testmonial.component';
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
    path:'calender',
    component:CalenderComponent
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
  }
  ,
  {
    path:'test',
    component:TestmonialComponent
  },
  {
    path:'coupon',
    component:CouponComponent
  }
  ,
  {
    path:'profile',
    component:ProfileComponent
  },
  
  {
    path:'profile/edit',
    component:EditComponent
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class AdminRoutingModule { }
