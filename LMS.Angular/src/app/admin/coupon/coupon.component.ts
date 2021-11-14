import { Component, OnInit } from '@angular/core';
import { CourseService } from 'src/app/Service/course.service';

@Component({
  selector: 'app-coupon',
  templateUrl: './coupon.component.html',
  styleUrls: ['./coupon.component.css']
})
export class CouponComponent implements OnInit {

  constructor(
    public courseService: CourseService
  ) { }

  ngOnInit(): void {
    this.courseService.ReturnAllCoupon()
  }

}
