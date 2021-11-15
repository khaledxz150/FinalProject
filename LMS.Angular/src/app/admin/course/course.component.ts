import { Component, OnInit } from '@angular/core';
import { faAngleDoubleRight, faShoppingCart, faHeart, faQuoteRight, faStar, faUser, faBook, faTag, faChartLine, faCalendar, faDollarSign, faPercentage, faEdit, faInfoCircle, faTrashAlt} from '@fortawesome/free-solid-svg-icons';
import { CourseService } from 'src/app/Service/course.service';
import { CreateCourseComponent } from './create-course/create-course.component';
import { MatDialog } from '@angular/material/dialog';
import { Course } from 'src/app/models/course';
import { CategoryService } from 'src/app/Service/category.service';
import { ViewCourseComponent } from './view-course/view-course.component';
import { AlertDialogComponent } from 'src/app/alert-dialog/alert-dialog.component';

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


constructor(public courseService: CourseService, private dialog:MatDialog, public categoryService:CategoryService) {
  this.courseService.getCourses();
  this.categoryService.getCategories();
}

ngOnInit(): void {
}


createCourse(){
  this.dialog.open(CreateCourseComponent).afterClosed().subscribe((course) =>{
    if(course){

      let dialogRef = this.dialog.open(AlertDialogComponent);

      dialogRef.afterClosed().subscribe(result => {

        // NOTE: The result can also be nothing if the user presses the `esc` key or clicks outside the dialog
        if (result == 'confirm') {

          this.courseService.createCourse(course);

        }
        })

    }
  });
}

viewCourse(courseId:number){
  console.log(courseId)

  const courseDetails = this.courseService.courses.find(i =>i.courseId == courseId);


  this.dialog.open(ViewCourseComponent,{data:courseDetails})
}

updateCourse(courseId:number){
  const course = this.courseService.courses.find(i =>i.courseId == courseId);


  console.log("course = ", course)
  this.dialog.open(CreateCourseComponent,{data:course}).afterClosed().subscribe((update) =>{
    if(update){

      let dialogRef = this.dialog.open(AlertDialogComponent);

      dialogRef.afterClosed().subscribe(result => {

        // NOTE: The result can also be nothing if the user presses the `esc` key or clicks outside the dialog
        if (result == 'confirm') {

          update.courseId = course?.courseId;
          this.courseService.updateCourse(update);
          // window.location.reload();

        }
        })


    }
  });

}

deleteCourse(courseId:number){

  let dialogRef = this.dialog.open(AlertDialogComponent);

  dialogRef.afterClosed().subscribe(result => {

    // NOTE: The result can also be nothing if the user presses the `esc` key or clicks outside the dialog
    if (result == 'confirm') {

      this.courseService.deleteCourse(courseId);
      window.location.reload();

    }
    })

}
}
