import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { CategoryService } from 'src/app/Service/category.service';
import { CourseService } from 'src/app/Service/course.service';

@Component({
  selector: 'app-create-unit',
  templateUrl: './create-unit.component.html',
  styleUrls: ['./create-unit.component.css']
})
export class CreateUnitComponent implements OnInit {

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
  constructor(private courseService: CourseService,
    public categoryService:CategoryService,) { }

  ngOnInit(): void {
  }
  Create(){}
}
