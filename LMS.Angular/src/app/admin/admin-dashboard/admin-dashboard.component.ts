import { Component, OnInit } from '@angular/core';
import { faArrowUp, faShoppingCart, faUsers, faTicketAlt, faDollarSign, faBook} from '@fortawesome/free-solid-svg-icons';
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
  constructor(public courseService:CourseService) { }

  ngOnInit(): void {
  }

}
