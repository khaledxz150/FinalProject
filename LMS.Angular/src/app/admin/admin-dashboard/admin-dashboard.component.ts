import { Component, OnInit } from '@angular/core';
import { FormControl } from '@angular/forms';
import { faArrowUp, faShoppingCart, faUsers, faTicketAlt, faDollarSign, faBook, faSearch} from '@fortawesome/free-solid-svg-icons';
import { CourseService } from 'src/app/Service/course.service';

@Component({
  selector: 'app-admin-dashboard',
  templateUrl: './admin-dashboard.component.html',
  styleUrls: ['./admin-dashboard.component.css','../../../assets/css/style1.css']
})
export class AdminDashboardComponent implements OnInit {

  faArrowUp = faArrowUp
  faShoppingCart = faShoppingCart
  faUsers = faUsers
  faTicketAlt = faTicketAlt
  faDollarSign = faDollarSign
  faBook = faBook
  faSearch = faSearch

  constructor(public courseService:CourseService) {

    this.courseService.returnSoldCourses;
   }

  ngOnInit(): void {
    this.courseService.returnSoldCourses();
    this.courseService.getCourses();
  }

  startDate = new FormControl('');
  endDate = new FormControl('');

  filterSoldCourseBetweenDate(){

    this.courseService.filterSoldCourseBetweenDate(this.startDate,this.endDate);

  }



  clear(){
    this.courseService.soldCourse = this.courseService.annualSoldCourses;
  }
}
