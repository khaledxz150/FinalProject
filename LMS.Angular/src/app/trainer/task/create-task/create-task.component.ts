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

 sectionTrainerId:any|undefined;
  selectedFile: File|null=null;
   formGroup: FormGroup = new FormGroup({
    FilePath: new FormControl('', [Validators.required]),
    Title: new FormControl('', [Validators.required]),
    Note: new FormControl(''),
    Mark: new FormControl('', [Validators.required]),
    Weight: new FormControl('', [Validators.required]),
    Date: new FormControl('', [Validators.required]),
    DeadLine: new FormControl('', [Validators.required]),

  });



  FileSrc: string | undefined;

  constructor(private courseService: CourseService,
    public categoryService:CategoryService,public sectionService: SectionService, @Inject(MAT_DIALOG_DATA) public data: any) { }


  ngOnInit(): void {
    let user:any = localStorage.getItem('user');
    let trainerId = JSON.parse(user);

   this.sectionService.ReturnAllTrainerSections(parseInt(trainerId.EmployeeId));
   const current= this.sectionService.TrainerSection.find(x=>x.sectionId == this.data);

   this.sectionTrainerId=current.trainerSectionId;

  }
  CreateTask(){
    const taskData=
    {
      taskTitle: this.formGroup.value.Title,
      mark: this.formGroup.value.Mark,
      note: this.formGroup.value.Note,
      weight: this.formGroup.value.Weight,
      fileUrl: this.FileSrc,
      date: "2021-11-18T17:06:19.320Z",
      deadline: "2021-11-18T17:06:19.320Z",
      sectionTrainerId: this.sectionTrainerId,
      isActive: true,
      creationDate: "2021-11-18T17:06:19.320Z"
    }

    console.log(taskData);
    this.sectionService.CreateNewTaskForSection(taskData);
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
