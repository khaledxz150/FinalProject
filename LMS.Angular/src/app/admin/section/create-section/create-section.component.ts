import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
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

  formGroup: FormGroup = new FormGroup({
    // sectionId: new FormControl('', [Validators.required]),
    noLecture: new FormControl(''),
    sectionCapacity: new FormControl(''),
    statusId: new FormControl(''),
    sectionTimeStart: new FormControl(''),
    sectionTimeEnd: new FormControl(''),
    trainerId : new FormControl(''),
    courseId: new FormControl(''),
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
    // @Inject(MAT_DIALOG_DATA) public data: any
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


const section : Section = this.formGroup.value;
// const trainerId:number = this.formGroup.controls.trainerId.value;
let trainerId = this.formGroup.controls.trainerId.value;
debugger

  this.sectionService.createSection(section,trainerId);
}

}
