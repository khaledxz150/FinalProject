import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AdminDashboardComponent } from './admin-dashboard/admin-dashboard.component';
import { CategoryComponent } from './category/category.component';
import { CourseComponent } from './course/course.component';
import { SectionComponent } from './section/section.component';
import { TrainerInfoComponent } from './trainer-info/trainer-info.component';

const routes: Routes = [
  {
    path:'dash',
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
    path:'category',
    component:CategoryComponent
  },
  {
    path:'course-section',
    component:SectionComponent
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class AdminRoutingModule { }
