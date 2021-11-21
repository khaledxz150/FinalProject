import { Component, OnInit } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { faEdit, faTrashAlt, faUserTag } from '@fortawesome/free-solid-svg-icons';
import { AlertDialogComponent } from 'src/app/alert-dialog/alert-dialog.component';
import { Coupon } from 'src/app/models/course';
import { CourseService } from 'src/app/Service/course.service';
import { CreateCouponComponent } from './create-coupon/create-coupon.component';

@Component({
  selector: 'app-coupon',
  templateUrl: './coupon.component.html',
  styleUrls: ['./coupon.component.css','../../../assets/css/style1.css']
})
export class CouponComponent implements OnInit {


//Icons
faUserTag =faUserTag
faEdit = faEdit
faTrashAlt = faTrashAlt

  constructor(
    public courseService: CourseService,
    private dialog:MatDialog,
  ) {
    this.courseService.ReturnAllCoupon()

   }

  ngOnInit(): void {

  }


  createCoupon(){
    this.dialog.open(CreateCouponComponent).afterClosed().subscribe((coupon) =>{
      if(coupon){

        let dialogRef = this.dialog.open(AlertDialogComponent);

        dialogRef.afterClosed().subscribe(result => {

          // NOTE: The result can also be nothing if the user presses the `esc` key or clicks outside the dialog
          if (result == 'confirm') {

            this.courseService.createCoupon(coupon);

          }
          })

      }
    });
  }


  ChangeCouponStatus(couponId:number){

    this.courseService.ChangeCouponStatus(couponId);
  }


  updateCoupon(couponId:number){
    const coupon = this.courseService.coupon.find(i =>i.couponId == couponId);

    this.dialog.open(CreateCouponComponent,{data:coupon}).afterClosed().subscribe((updatedCoupon) =>{
      if(updatedCoupon){

        let dialogRef = this.dialog.open(AlertDialogComponent);

        dialogRef.afterClosed().subscribe(result => {

          // NOTE: The result can also be nothing if the user presses the `esc` key or clicks outside the dialog
          if (result == 'confirm') {

            updatedCoupon.couponId = coupon?.couponId;
            this.courseService.updateCoupon(updatedCoupon);

          }
          })

      }
    });
  }

}
