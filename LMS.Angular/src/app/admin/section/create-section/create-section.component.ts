import { Component, Inject, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { MatDialog, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { faInfoCircle, faTimes } from '@fortawesome/free-solid-svg-icons';
import { AlertDialogComponent } from 'src/app/alert-dialog/alert-dialog.component';
import { Section } from 'src/app/models/section';
import { CourseService } from 'src/app/Service/course.service';
import { SectionService } from 'src/app/Service/section.service';
import { TrainerService } from 'src/app/Service/trainer.service';

@Component({
  selector: 'app-create-section',
  templateUrl: './create-section.component.html',
  styleUrls: ['./create-section.component.css']
})
export class CreateSectionComponent implements OnInit {


  //Icons
  faTimes =faTimes
  faInfoCircle = faInfoCircle

  formGroup: FormGroup = new FormGroup({
    // sectionId: new FormControl('', [Validators.required]),
    noLecture: new FormControl('',[Validators.required]),
    sectionCapacity: new FormControl('',[Validators.required]),
    statusId: new FormControl('',[Validators.required]),
    sectionTimeStart: new FormControl('',[Validators.required]),
    sectionTimeEnd: new FormControl(''),
    trainerId : new FormControl('',[Validators.required]),
    courseId: new FormControl('',[Validators.required]),
    // categoryId: new FormControl('', [Validators.required]),
    // tagId: new FormControl('', [Validators.required]),
    // createdBy: new FormControl('', [Validators.required])
  });

  // sectionId:number |undefined;
  // noLecture:number |undefined;
  // sectionCapacity:number|undefined
  // statusName:string |undefined;
  // sectionTimeStart:string |undefined;
  // sectionTimeEnd:string |undefined;
  // trainerName:string |undefined;
  // courseName:string | undefined;
  constructor(
    public sectionService: SectionService,
    public trainerService:TrainerService,
    public courseService: CourseService,
    private dialog:MatDialog,
    // private dialog: MatDialogRef<CreateSectionComponent>,
    @Inject(MAT_DIALOG_DATA) public data: any
  ) {
    this.sectionService.getStatus();
    this.trainerService.getTrainer();
    this.courseService.getCourses();
  }

  ngOnInit(): void {


  }


//   Create(){

//     const section : Section = this.formGroup.value;
//     value1.courseId = this.data.courseId;
//     debugger
//    this.courseService.createCourse(course);
//    window.location.reload();

// }

createSection(){

  let dialogRef = this.dialog.open(AlertDialogComponent);

  dialogRef.afterClosed().subscribe(result => {

    // NOTE: The result can also be nothing if the user presses the `esc` key or clicks outside the dialog
    if (result == 'confirm') {

      const section : Section = this.formGroup.value;
      // const trainerId:number = this.formGroup.controls.trainerId.value;
      let trainerId = this.formGroup.controls.trainerId.value;
      debugger

        this.sectionService.createSection(section,trainerId);
      // window.location.reload();

    }
    })

}


}
