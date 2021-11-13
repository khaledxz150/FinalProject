import { Component, Inject, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { faTimes } from '@fortawesome/free-solid-svg-icons';
import { CourseService } from 'src/app/Service/course.service';

@Component({
  selector: 'app-create-topic',
  templateUrl: './create-topic.component.html',
  styleUrls: ['./create-topic.component.css']
})
export class CreateTopicComponent implements OnInit {
 //Icons
 faTimes = faTimes

 formGroup: FormGroup = new FormGroup({
   topicName: new FormControl('', [Validators.required]),
   courseId: new FormControl('', [Validators.required]),
   description: new FormControl(''),
   createdBy: new FormControl(1)
 });


 constructor(

   public courseService: CourseService,
   // private dialog: MatDialog,
   @Inject(MAT_DIALOG_DATA) public data: any,
   private dialog: MatDialogRef<CreateTopicComponent>
 ) {

   this.courseService.getAllTopics(0);
   this.courseService.getCourses();
 }

 ngOnInit(): void {


   if (this.data) {
     // console.log("this.date = ",this.data)

     this.formGroup.controls.topicName.setValue(this.data.topicName);
     this.formGroup.controls.description.setValue(this.data.description);
     this.formGroup.controls.courseId.setValue(this.data.courseId);
   }
 }


 saveItem() {
   const value = this.formGroup.value;
   if (this.data) {
     this.dialog.close({
       ...value

     })
   } else {
     this.dialog.close(value)
   }
 }
}
