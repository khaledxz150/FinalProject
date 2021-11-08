import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AdminDashboardComponent } from './admin-dashboard/admin-dashboard.component';
import { CategoryComponent } from './category/category.component';
import { CourseComponent } from './course/course.component';

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
    path:'category',
    component:CategoryComponent
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class AdminRoutingModule { }
