import { Component, Inject, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { MatDialog, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { faTimes } from '@fortawesome/free-solid-svg-icons';
import { AlertDialogComponent } from 'src/app/alert-dialog/alert-dialog.component';
import { Section } from 'src/app/models/section';
import { CourseService } from 'src/app/Service/course.service';
import { SectionService } from 'src/app/Service/section.service';
import { TrainerService } from 'src/app/Service/trainer.service';

@Component({
  selector: 'app-update-section',
  templateUrl: './update-section.component.html',
  styleUrls: ['./update-section.component.css']
})
export class UpdateSectionComponent implements OnInit {


  //Icons
  faTimes =faTimes


  formGroup: FormGroup = new FormGroup({
    // sectionId: new FormControl(''),
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
    @Inject(MAT_DIALOG_DATA) public data: any
  ) {
    this.sectionService.getStatus();
    this.sectionService.getSections(0);

    this.trainerService.getTrainer();
    this.courseService.getCourses();

  }

  ngOnInit(): void {

    if (this.data) {
      debugger
      // this.formGroup.controls.noLecture.setValue(this.data.noLecture);
      this.formGroup.controls.noLecture.setValue(this.data.noLecture);
      this.formGroup.controls.sectionCapacity.setValue(this.data.sectionCapacity);
      this.formGroup.controls.sectionTimeStart.setValue(this.data.sectionTimeStart);
      this.formGroup.controls.sectionTimeEnd.setValue(this.data.sectionTimeEnd);
      this.formGroup.controls.trainerId.setValue(this.data.trainerId);
      this.formGroup.controls.courseId.setValue(this.data.courseId);
      this.formGroup.controls.statusId.setValue(this.data.statusId);
      console.log("this.data.trainerId = ",this.data.trainerId)
    }

  }


//   Create(){

//     const section : Section = this.formGroup.value;
//     value1.courseId = this.data.courseId;
//     debugger
//    this.courseService.createCourse(course);
//    window.location.reload();

// }

updateSection(){

  debugger
  let dialogRef = this.dialog.open(AlertDialogComponent);

  dialogRef.afterClosed().subscribe(result => {

    // NOTE: The result can also be nothing if the user presses the `esc` key or clicks outside the dialog
    if (result == 'confirm') {

      const section : Section = this.formGroup.value;

      section.sectionId = this.data.sectionId;
      // section.sectionId = sectionId;
      let trainerId= this.formGroup.controls.trainerId.value;
      // let sectionId = this.data.sectionId;
      debugger

        this.sectionService.updateSection(section,trainerId);
      // window.location.reload();

    }
    })

    debugger
}
}
