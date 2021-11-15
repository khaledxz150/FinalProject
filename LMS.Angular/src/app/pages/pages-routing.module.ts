import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AdminModule } from '../admin/admin.module';
import { AboutusComponent } from './aboutus/aboutus.component';
import { ContactusComponent } from './contactus/contactus.component';
import { CoursesComponent } from './courses/courses.component';
import { HomeComponent } from './home/home.component';
import { SingleCourseComponent } from './single-course/single-course.component';

const routes: Routes = [

  {
    path:'',
    redirectTo:'home',
    pathMatch:'full'
  },
  {
    path:'home',
    component:HomeComponent
  },
  {
    path:'aboutus',
    component: AboutusComponent
  },
  {
    path:'contactus',
    component:ContactusComponent
  },
  {
    path:'courses',
    component:CoursesComponent
  },
  {
    path:'courseInfo/:id',
    component:SingleCourseComponent
  },
  {
    path:'admin',
    loadChildren: ()=> AdminModule
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class PagesRoutingModule { }
