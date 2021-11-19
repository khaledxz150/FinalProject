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

  constructor(public sectionService:SectionService,
     public courseService:CourseService) {

    }

    ngOnInit(): void {

      this.sectionService.GetTraineeInSpecificSection()

    }


  RegisterAttendence(index:number,IsPresent:boolean){
    this.sectionService.studentsAttendenceArray[index].isPresent=IsPresent;
  }



  SaveAttendence(){
    this.sectionService.SaveAttendenceReport()
  }


  }
