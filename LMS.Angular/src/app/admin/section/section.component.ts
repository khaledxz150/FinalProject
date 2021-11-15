import { Component, Input, OnInit } from '@angular/core';
import { FormControl, Validators } from '@angular/forms';
import { MatDialog } from '@angular/material/dialog';
import { faEdit, faHashtag, faInfoCircle, faTrashAlt, faUsers } from '@fortawesome/free-solid-svg-icons';
import { AlertDialogComponent } from 'src/app/alert-dialog/alert-dialog.component';
import { CourseService } from 'src/app/Service/course.service';
import { SectionService } from 'src/app/Service/section.service';
import { CreateSectionComponent } from './create-section/create-section.component';
import { UpdateSectionComponent } from './update-section/update-section.component';

@Component({
  selector: 'app-section',
  templateUrl: './section.component.html',
  styleUrls: ['./section.component.css','../../../assets/css/style1.css']
})
export class SectionComponent implements OnInit {

  faInfoCircle = faInfoCircle
  faUsers =faUsers
  faHashtag = faHashtag
  faEdit = faEdit
  faTrashAlt =faTrashAlt
  courseId = new FormControl('');

  constructor(public sectionService:SectionService,
    public courseService:CourseService,
    private dialog:MatDialog) {

      this.sectionService.getSections(0);
      this.courseService.getCourses();
  }

  ngOnInit(): void {



  }

  getSection(courseId:number){

  this.sectionService.getSections(courseId);
  }

  search(){
    let courseId = this.courseId.value;
    console.log(courseId);
    this.sectionService.getSections(courseId);
  }



  createSection(){
    this.dialog.open(CreateSectionComponent)
  }

  deleteSection(sectionId:number){


      let dialogRef = this.dialog.open(AlertDialogComponent);

      dialogRef.afterClosed().subscribe(result => {

        // NOTE: The result can also be nothing if the user presses the `esc` key or clicks outside the dialog
        if (result == 'confirm') {

          this.sectionService.deleteSection(sectionId);


        }
        })



  }


  updateSection(sectionId:number){
    debugger
    const item = this.sectionService.sections.find(i => i.sectionId == sectionId);
    this.dialog.open(UpdateSectionComponent,{data:item})
    debugger
  }

}
