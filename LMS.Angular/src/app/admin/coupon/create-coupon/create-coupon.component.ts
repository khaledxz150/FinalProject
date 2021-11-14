import { Component, Inject, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { MatDialog, MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { faInfoCircle, faTimes } from '@fortawesome/free-solid-svg-icons';
import { CourseService } from 'src/app/Service/course.service';

@Component({
  selector: 'app-create-coupon',
  templateUrl: './create-coupon.component.html',
  styleUrls: ['./create-coupon.component.css']
})
export class CreateCouponComponent implements OnInit {

 //Icons
 faTimes =faTimes
 faInfoCircle = faInfoCircle

 formGroup: FormGroup = new FormGroup({
   code: new FormControl('',[Validators.required]),
   startDate: new FormControl('',[Validators.required]),
   endDate: new FormControl('',[Validators.required]),
   redemption: new FormControl(''),
   discount: new FormControl(''),
   // trainerId : new FormControl('',[Validators.required]),
   courseId: new FormControl('',[Validators.required]),
   createdBy: new FormControl(1),
 });


 constructor(

   public courseService: CourseService,
   // private dialog:MatDialog,
   private dialog: MatDialogRef<CreateCouponComponent>,
   @Inject(MAT_DIALOG_DATA) public data: any
 ) {
   this.courseService.getCourses();
   this.courseService.ReturnAllCoupon()
 }

 ngOnInit(): void {
   if (this.data) {

     this.formGroup.controls.code.setValue(this.data.code);
     this.formGroup.controls.startDate.setValue(this.data.startDate);
     this.formGroup.controls.endDate.setValue(this.data.endDate);
     this.formGroup.controls.redemption.setValue(this.data.redemption);
     this.formGroup.controls.discount.setValue(this.data.discount);
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
