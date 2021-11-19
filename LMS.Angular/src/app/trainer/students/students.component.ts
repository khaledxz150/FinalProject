import { Component, OnInit } from '@angular/core';
import { FormControl } from '@angular/forms';
import { CourseService } from 'src/app/Service/course.service';
import { SectionService } from 'src/app/Service/section.service';

@Component({
  selector: 'app-students',
  templateUrl: './students.component.html',
  styleUrls: ['./students.component.css']
})
export class StudentsComponent implements OnInit {

  sectionId = new FormControl('');

  constructor(public sectionService:SectionService, public courseService:CourseService) {

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

}
