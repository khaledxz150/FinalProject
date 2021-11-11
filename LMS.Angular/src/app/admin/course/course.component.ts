import { Component, OnInit } from '@angular/core';
import { faAngleDoubleRight, faShoppingCart, faHeart, faQuoteRight, faStar, faUser, faBook, faTag, faChartLine, faCalendar, faDollarSign, faPercentage, faEdit, faInfoCircle, faTrashAlt} from '@fortawesome/free-solid-svg-icons';
import { CourseService } from 'src/app/Service/course.service';
import { CreateCourseComponent } from './create-course/create-course.component';
import { MatDialog } from '@angular/material/dialog';
import { Course } from 'src/app/models/course';
import { CategoryService } from 'src/app/Service/category.service';
import { ViewCourseComponent } from './view-course/view-course.component';
import { UpdateCourseComponent } from './update-course/update-course.component';

@Component({
  selector: 'app-course',
  templateUrl: './course.component.html',
  styleUrls: ['./course.component.css','../../../assets/css/style1.css']
})
export class CourseComponent implements OnInit {




  // Icons
  faAngleDoubleRight = faAngleDoubleRight
  faShoppingCart = faShoppingCart
  faHeart = faHeart
  faQuoteRight = faQuoteRight
  faStar = faStar
  faUser = faUser
  faBook = faBook
  faTag = faTag
  faChartLine = faChartLine
  faCalendar = faCalendar
  faDollarSign = faDollarSign
  faPercentage = faPercentage
  faEdit =faEdit
  faInfoCircle = faInfoCircle
  faTrashAlt = faTrashAlt
  // categoryName:string  = '';

  // cat:Course[]=  this.courseService.courses.filter(x=>x.categoryName == this.categoryName);
  constructor(public courseService: CourseService, private dialog:MatDialog, public categoryService:CategoryService) {
    this.courseService.getCourses();
    this.categoryService.getCategories();
  }

  ngOnInit(): void {
  }

  // deleteCourse(courseId:number){
  //   this.courseService.deleteCourse(courseId);


  // }

  createCourse(){
    this.dialog.open(CreateCourseComponent)
  }





  viewCourse(courseId:number){
    console.log(courseId)

    const courseDetails = this.courseService.courses.find(i =>i.courseId == courseId);


    this.dialog.open(ViewCourseComponent,{data:courseDetails})
  }

  updateCourse(courseId:number){
    const course = this.courseService.courses.find(i =>i.courseId == courseId);


    this.dialog.open(UpdateCourseComponent,{data:course})
  }


  deleteCourse(courseId:number){
    this.courseService.deleteCourse(courseId);
  }
}
