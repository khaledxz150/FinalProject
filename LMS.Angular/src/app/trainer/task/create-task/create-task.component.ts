import { CategoryService } from 'src/app/Service/category.service';
import { CourseService } from 'src/app/Service/course.service';
import { SectionService } from 'src/app/Service/section.service';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { MAT_DIALOG_DATA } from '@angular/material/dialog';
import { Component, Inject, OnInit } from '@angular/core';

@Component({
  selector: 'app-create-task',
  templateUrl: './create-task.component.html',
  styleUrls: ['./create-task.component.css']
})
export class CreateTaskComponent implements OnInit {


  selectedFile: File|null=null;
  formGroup: FormGroup = new FormGroup({
    FilePath: new FormControl('', [Validators.required]),
    Title: new FormControl('', [Validators.required]),
  });

  FileSrc: string | undefined;

  constructor(private courseService: CourseService,
    public categoryService:CategoryService,public sectionService: SectionService, @Inject(MAT_DIALOG_DATA) public data: any) { }

  ngOnInit(): void {

  }
  Create(){

  }

  Uploadfile(event: any ) {
    const reader = new FileReader();

    if (event.target.files && event.target.files.length) {
      const [file] = event.target.files;
      reader.readAsDataURL(file);

      reader.onload = () => {
        this.FileSrc = reader.result as string;
        console.log(this.FileSrc)

    }

  }

}
}
