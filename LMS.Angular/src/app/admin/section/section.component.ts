import { Component, Input, OnInit } from '@angular/core';
import { FormControl, Validators } from '@angular/forms';
import { faEdit, faHashtag, faInfoCircle, faTrashAlt, faUsers } from '@fortawesome/free-solid-svg-icons';
import { CourseService } from 'src/app/Service/course.service';
import { SectionService } from 'src/app/Service/section.service';

@Component({
  selector: 'app-section',
  templateUrl: './section.component.html',
  styleUrls: ['./section.component.css','../../../assets/css/style1.css']
})
export class SectionComponent implements OnInit {

   // courseId:number = 0 //this.sectionService.sections.sectionId;

  // @Input() courseId:number | undefined;
  faInfoCircle = faInfoCircle
  faUsers =faUsers
  faHashtag = faHashtag
  faEdit = faEdit
  faTrashAlt =faTrashAlt
  courseId = new FormControl('');

  constructor(public sectionService:SectionService,
    public courseService:CourseService) {


  }

  ngOnInit(): void {


      this.sectionService.getSections(0);
      this.courseService.getCourses();
  }

  getSection(courseId:number){

  this.sectionService.getSections(courseId);
  }

  search(){
    let courseId = this.courseId.value;
    console.log(courseId);
    this.sectionService.getSections(courseId);
  }

}
