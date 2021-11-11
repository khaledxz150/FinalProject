import { Component, Inject, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { MAT_DIALOG_DATA } from '@angular/material/dialog';
import { Course } from 'src/app/models/course';
import { CategoryService } from 'src/app/Service/category.service';
import { CourseService } from 'src/app/Service/course.service';

@Component({
  selector: 'app-create-course',
  templateUrl: './create-course.component.html',
  styleUrls: ['./create-course.component.css']
})
export class CreateCourseComponent implements OnInit {



  formGroup: FormGroup = new FormGroup({
    courseId: new FormControl('', [Validators.required]),
    courseName: new FormControl('', [Validators.required]),
    coursePrice: new FormControl('', [Validators.required]),
    courseDescripction: new FormControl(''),
    passMark: new FormControl('',[Validators.required]),
    image: new FormControl('', [Validators.required]),
    typeId : new FormControl('', [Validators.required]),
    levelId: new FormControl('', [Validators.required]),
    categoryId: new FormControl('', [Validators.required]),
    tagId: new FormControl('', [Validators.required]),
    createdBy: new FormControl('', [Validators.required])
  });

  constructor(
    private courseService: CourseService,
    public categoryService:CategoryService,
    // @Inject(MAT_DIALOG_DATA) public data: any
  ) {
    this.categoryService.getCategories();
  }

  ngOnInit(): void {

  }


  Create(){

    const course : Course = this.formGroup.value;
    // value1.courseId = this.data.courseId;
    debugger
   this.courseService.createCourse(course);
   window.location.reload();

}
}
