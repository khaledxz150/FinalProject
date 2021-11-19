import { Component, Inject, Input, OnInit } from '@angular/core';
import { FormArray, FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { MAT_DIALOG_DATA } from '@angular/material/dialog';
import { ActivatedRoute, Router } from '@angular/router';
import { CourseService } from 'src/app/Service/course.service';
import { SectionService } from 'src/app/Service/section.service';

@Component({
  selector: 'app-attendance',
  templateUrl: './attendance.component.html',
  styleUrls: ['./attendance.component.css']
})
export class AttendanceComponent implements OnInit {

  section:any| undefined;




  constructor(public sectionService:SectionService,
     public courseService:CourseService,  private route: ActivatedRoute,
     private router: Router) {
      this.section = this.sectionService.currentsectionforLecture;

    }
    ngOnInit(): void {
      this.section = this.sectionService.currentsectionforLecture;
      this.sectionService.GetTraineeInSpecificSection(this.section);
    }
  RegisterAttendence(index:number,IsPresent:boolean){
    this.sectionService.studentsAttendenceArray[index].isPresent=IsPresent;
  }
  SaveAttendence(){
    this.sectionService.ReturnLectureBySectionId(this.section);
    this.sectionService.SaveAttendenceReport()
  }


  }
