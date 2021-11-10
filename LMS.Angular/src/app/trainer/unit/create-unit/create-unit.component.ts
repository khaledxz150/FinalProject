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

  selectedFile: File|null=null;
  formGroup: FormGroup = new FormGroup({
    FilePath: new FormControl('', [Validators.required])
  });

newUnit:any=[];
 
  constructor(private courseService: CourseService,
    public categoryService:CategoryService,) { }

  ngOnInit(): void {
     this.newUnit= {
      SectionId:undefined,
      FilePath:undefined,
      IsActive:undefined,
      createdBy:undefined,
    }
  }
  Create(){
    this.newUnit= {
      FilePath:this.selectedFile,
      IsActive:1,
      createdBy:Date.now(),
    }
  }
  
  UploadFile(e:any) {
this.selectedFile = <File>e.target.files[0];
console.log(this.selectedFile );
}

}
 

