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


@NgModule({
  declarations: [

    AdminDashboardComponent,
      CourseComponent,
      SidebarComponent,
      CreateCourseComponent,
      CategoryComponent,
      CreateCategoryComponent
  ],
  imports: [
    CommonModule,
    AdminRoutingModule,
    SharedModule
  ]
})
export class AdminModule { }
