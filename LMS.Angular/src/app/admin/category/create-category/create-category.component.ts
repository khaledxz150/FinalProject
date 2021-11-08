import { Component, Inject, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { MAT_DIALOG_DATA } from '@angular/material/dialog';
import { Category } from 'src/app/models/category';
import { CategoryService } from 'src/app/Service/category.service';

@Component({
  selector: 'app-create-category',
  templateUrl: './create-category.component.html',
  styleUrls: ['./create-category.component.css']
})
export class CreateCategoryComponent implements OnInit {



  formGroup: FormGroup = new FormGroup({
    // categoryId: new FormControl('', [Validators.required]),
    name:new FormControl('', [Validators.required]),
    image:new FormControl('', [Validators.required]),
    createdBy: new FormControl('', [Validators.required])
  });

  constructor(
    public categoryService:CategoryService,
    // @Inject(MAT_DIALOG_DATA) public data: any
  ) {
    this.categoryService.getCategories();
  }

  ngOnInit(): void {

    // if (this.data) {
    //   this.formGroup.controls.courseName.setValue(this.data.courseName);
    //   this.formGroup.controls.coursePrice.setValue(this.data.coursePrice);
    //   this.formGroup.controls.courseDescripction.setValue(this.data.courseDescripction);
    //   this.formGroup.controls.startDate.setValue(this.data.startDate);
    //   this.formGroup.controls.endDate.setValue(this.data.endDate);
    //   this.formGroup.controls.courseCateogry.setValue(this.data.courseCateogry);
    //   this.formGroup.controls.createdBy.setValue(this.data.createdBy);
    // }
  }


  Create(){

    const category : Category = this.formGroup.value;
    // value1.courseId = this.data.courseId;
    debugger
   this.categoryService.createCategory(category);
   window.location.reload();

}

}
