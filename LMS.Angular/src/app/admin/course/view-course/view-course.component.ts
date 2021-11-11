import { Component, Inject, Input, OnInit } from '@angular/core';
import { MAT_DIALOG_DATA } from '@angular/material/dialog';
import { CourseService } from 'src/app/Service/course.service';
import { faBook, faCalendar, faChalkboard, faChartLine, faDollarSign, faPercentage, faTag } from '@fortawesome/free-solid-svg-icons';



@Component({
  selector: 'app-view-course',
  templateUrl: './view-course.component.html',
  styleUrls: ['./view-course.component.css']
})
export class ViewCourseComponent implements OnInit {

  @Input() courseId:number |undefined;
  @Input() courseName:string ="";
  @Input() courseDescripction:string|undefined
  @Input() coursePrice:number | undefined;
  @Input() image:string | undefined;
  @Input() typeName:string | undefined;
  @Input() passMark:number|undefined
  @Input() levelName:string|undefined
  @Input() categoryName:string|undefined
  @Input() tagName:string|undefined



  //Icons
  faBook = faBook
  faChartLine = faChartLine
  faTag = faTag
  faCalendar = faCalendar
  faPercentage = faPercentage
  faChalkboard = faChalkboard
  faDollarSign = faDollarSign
  constructor(@Inject(MAT_DIALOG_DATA) public data: any, public courseService: CourseService) { }

  ngOnInit(): void {

     if (this.data) {
      this.courseId = this.data.courseId;
      this.coursePrice = this.data.coursePrice;
      this.courseName = this.data.courseName;
      this.courseDescripction = this.data.courseDescripction;
      this.image = this.data.image;
      this.typeName = this.data.typeName;
      this.passMark = this.data.passMark;
      this.levelName = this.data.levelName;
      this.tagName = this.data.tagName;
      this.categoryName = this.data.categoryName;
    }
  }


  // deleteCourse(){
  //   console.log(this.courseId)
  //   if(this.courseId)
  //   this.courseService.deleteCourse(this.courseId);
  // }

}
