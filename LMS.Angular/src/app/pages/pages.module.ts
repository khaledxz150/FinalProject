import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { PagesRoutingModule } from './pages-routing.module';
import { HomeComponent } from './home/home.component';
import { ContactusComponent } from './contactus/contactus.component';
import { AboutusComponent } from './aboutus/aboutus.component';
import { CoursesComponent } from './courses/courses.component';
import { SingleCourseComponent } from './single-course/single-course.component';
import { SharedModule } from '../shared/shared.module';
import { CategoryCardComponent } from './home/category-card/category-card.component';
import { NavbarComponent } from '../navbar/navbar.component';
import { FooterComponent } from '../footer/footer.component';
import { TraineeModule } from '../trainee/trainee.module';



@NgModule({
  declarations: [
    HomeComponent,
    ContactusComponent,
    AboutusComponent,
    CoursesComponent,
    SingleCourseComponent,
    CategoryCardComponent,
    // NavbarComponent,
    // FooterComponent

  ],
  imports: [
    CommonModule,
    PagesRoutingModule,
    SharedModule,
    TraineeModule

  ]
})
export class PagesModule { }
