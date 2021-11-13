import { Component, Inject, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { MAT_DIALOG_DATA } from '@angular/material/dialog';
import { Course } from 'src/app/models/course';
import { CategoryService } from 'src/app/Service/category.service';
import { CourseService } from 'src/app/Service/course.service';

@Component({
  selector: 'app-update-course',
  templateUrl: './update-course.component.html',
  styleUrls: ['./update-course.component.css']
})
export class UpdateCourseComponent implements OnInit {

  formGroup: FormGroup = new FormGroup({
    // courseId: new FormControl('', [Validators.required]),
    courseName: new FormControl('', [Validators.required]),
    coursePrice: new FormControl('', [Validators.required]),
    courseDescripction: new FormControl(''),
    passMark: new FormControl('',[Validators.required]),
    // image: new FormControl('', [Validators.required]),
    // typeId : new FormControl('', [Validators.required]),
    // levelId: new FormControl('', [Validators.required]),
    // categoryId: new FormControl('', [Validators.required]),
    // tagId: new FormControl('', [Validators.required]),
    // createdBy: new FormControl('', [Validators.required])
  });

  constructor(@Inject(MAT_DIALOG_DATA) public data: any, public courseService: CourseService, public categoryService:CategoryService) { }

  ngOnInit(): void {

    if (this.data) {
      // this.formGroup.controls.courseId = this.data.courseId;
      // this.formGroup.controls.coursePrice = this.data.coursePrice;
      // this.formGroup.controls.courseName = this.data.courseName;
      // this.formGroup.controls.courseDescripction = this.data.courseDescripction;
      // this.formGroup.controls.image = this.data.image;
      // this.formGroup.controls.typeName = this.data.typeName;
      // this.formGroup.controls.passMark = this.data.passMark;
      // this.formGroup.controls.levelName = this.data.levelName;
      // this.formGroup.controls.tagName = this.data.tagName;
      // this.formGroup.controls.categoryName = this.data.categoryName;
    }
  }


    updateCourse(){
      const course : Course = this.formGroup.value;
      course.courseId = this.data.courseId;
      this.courseService.updateCourse(course);
      window.location.reload();
  }


}
