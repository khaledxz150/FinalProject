import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { PagesRoutingModule } from './pages-routing.module';
import { HomeComponent } from './home/home.component';
import { ContactusComponent } from './contactus/contactus.component';
import { AboutusComponent } from './aboutus/aboutus.component';
import { CoursesComponent } from './courses/courses.component';
import { SingleCourseComponent } from './single-course/single-course.component';


@NgModule({
  declarations: [
    HomeComponent,
    ContactusComponent,
    AboutusComponent,
    CoursesComponent,
    SingleCourseComponent
  ],
  imports: [
    CommonModule,
    PagesRoutingModule
  ]
})
export class PagesModule { }
