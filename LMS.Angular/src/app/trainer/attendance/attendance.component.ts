import { Component, OnInit } from '@angular/core';
import { FormArray, FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { CourseService } from 'src/app/Service/course.service';
import { SectionService } from 'src/app/Service/section.service';

@Component({
  selector: 'app-attendance',
  templateUrl: './attendance.component.html',
  styleUrls: ['./attendance.component.css']
})
export class AttendanceComponent implements OnInit {
  checkValue(event: any){
    console.log(event);
 }
   
 formGroup: FormGroup = new FormGroup({
 

  lectureId: new FormControl('', [Validators.required]),
  isPresent: new FormControl('', [Validators.required]),
  isActive: new FormControl('', [Validators.required]),
  creationDate: new FormControl('', [Validators.required]),
  createdBy: new FormControl('', [Validators.required]),
  traineeId: new FormControl('', [Validators.required]),
  
});
  sectionId = new FormControl('');

  constructor(public sectionService:SectionService, public courseService:CourseService,private formBuilder: FormBuilder) {
    this.formGroup = this.formBuilder.group({
      website: this.formBuilder.array([], [Validators.required])
    })

  }

  ngOnInit(): void {



    this.sectionService.getSections(0);
    this.courseService.getCourses();

    let user:any = localStorage.getItem('user');

    let trainerId = JSON.parse(user);
     if(trainerId){
      this.sectionService.ReturnAllTrainerSections(parseInt(trainerId.EmployeeId));

      this.sectionService.ReturnTraineeSection(parseInt(trainerId.EmployeeId));
    }

  }

  filter(){
     this.sectionService.TraineeSection(this.sectionId);
  }

  clear(){
    this.sectionService.filterTraineeSection = this.sectionService.traineeSection;
  }



    
  onCheckboxChange(e:any) {
    const website: FormArray = this.formGroup.get('sectionService') as FormArray;
  
    if (e.target.checked) {
      website.push(new FormControl(e.target.value));
    } else {
       const index = website.controls.findIndex(x => x.value === e.target.value);
       website.removeAt(index);
    }
  }
    
  submit(){
    console.log(this.formGroup.value);
  }
   

}
